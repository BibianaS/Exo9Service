using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exo9
{
    /// <summary>
    /// classe accès aux données - BDD : Formations, table : StagiairesSet
    /// </summary>
    public static class MStagiaireDAOEFStatic
    {
        
        /// <summary>
        /// instancie les objets MStagiaires spécialisés correspondants aux Entities du dbSet
        /// </summary>
        /// <param name="laSection">la ref de la section qui gère la collection de ces stagiaires</param>
        public static void InstancieStagiairesSection(MSection laSection)
        {
            // instancier le dbContext au besoin
            if(DonneesDAO.DbContextFormation == null) DonneesDAO.DbContextFormation = new FormationsContainer();

            var query = from a in DonneesDAO.DbContextFormation.StagiairesSet
                        where a.Sections.Idsection == laSection.CodeSection
                        select a;
            // ref d'objet générique (pour la collection)
            MStagiaire leStagiaire;
            // parcourt les lignes de la requête
            foreach (Stagiaires item in query)
            {
                // instancie et renseigne l'objet MStagiaire spécialisé 
                if (item is StagiaireCIF)
                {
                    // cas d'un CIF : objet MStagiaireCIF
                    leStagiaire = new MStagiaireCIF(item.NumOsia,
                        item.NomStagiaire.Trim(), 
                        item.PrenomStagiaire.Trim(), 
                        item.rueStagiaire, 
                        item.VilleStagiaire.Trim(), 
                        item.CodePostalStagiaire,
                        ((StagiaireCIF)item).Fongecif,
                        ((StagiaireCIF)item).TypeCIF.Trim()
                    );
                }
                else
                {
                    // cas d'un DE : objet MStagiaireDE
                    leStagiaire = new MStagiaireDE(item.NumOsia,
                        item.NomStagiaire.Trim(),
                        item.PrenomStagiaire.Trim(),
                        item.rueStagiaire,
                        item.VilleStagiaire.Trim(),
                        item.CodePostalStagiaire.Trim(),
                        ((StagiaireDE)item).RemuAfpa
                    );
                }

                // affecter points et notes
                // on ne peut affecter directement Pointsnotes et NbreNotes
                // dans MStagiaire que si le demandeur est de ce type MStagiaireDAOEFStatic
                leStagiaire.SetPoints(Convert.ToDouble(item.PointsNotes), (int)item.NbreNotes, typeof(MStagiaireDAOEFStatic).ToString()); 
                
                // ajoute le Stagiaire à la collection de la section
                laSection.Ajouter(leStagiaire);
            }
        }

        /// <summary>
        /// insère un stagiaire dans la table Stagiaires de la BDD
        /// </summary>
        /// <param name="unStagiaire">objet MStagiaire correspondant</param>
        /// <param name="unCodeSection">identifiant de sa section</param>
        public static void InsereStagiaire(MStagiaire unStagiaire, MSection uneSection)
        {
            // instancier le dbContext au besoin
            if (DonneesDAO.DbContextFormation == null) DonneesDAO.DbContextFormation = new FormationsContainer();

            // rechercher l'Entity Section
            Sections laSection = DonneesDAO.DbContextFormation.SectionsSet.Find(uneSection.CodeSection);
            // instancie un Entity et le renseigne à partir du MStagiaire reçu
            Stagiaires unStagiaireEF = null; // pour compilateur
            if (unStagiaire is MStagiaireCIF)
            {

                unStagiaireEF = new StagiaireCIF(unStagiaire.NumOsia, unStagiaire.Nom, unStagiaire.Prenom, 
                    unStagiaire.Rue, unStagiaire.Ville, unStagiaire.CodePostal, 
                    unStagiaire.NbreNotes, Convert.ToDecimal(unStagiaire.PointsNotes), laSection, 
                    ((MStagiaireCIF)unStagiaire).Fongecif, ((MStagiaireCIF)unStagiaire).TypeCif);

            }            
            
            
            else
            {
                // cas d'un DE
                unStagiaireEF = new StagiaireDE(unStagiaire.NumOsia, unStagiaire.Nom, unStagiaire.Prenom,
                    unStagiaire.Rue, unStagiaire.Ville, unStagiaire.CodePostal,
                    unStagiaire.NbreNotes, Convert.ToDecimal(unStagiaire.PointsNotes), laSection,
                    ((MStagiaireDE)unStagiaire).RemuAfpa);
            }

            try
            {
                // ajoute l'Entity au dbSet du dbContext
                DonneesDAO.DbContextFormation.StagiairesSet.Add(unStagiaireEF);
                // déclenche la MAJ sur BDD 
                DonneesDAO.DbContextFormation.SaveChanges();
            }
            catch (Exception ex) // a ce niveau, erreur possible en cas de doublon
            {                    // avec un  autre stagiaire déjà chargé en mémoire
                throw ex;        // ou erreur d'accès à la BDD
            }
        }

        /// <summary>
        /// modifie un stagiaire en BDD
        /// </summary>
        /// <param name="unStagiaire">la ref à l'objet Mstagiaire qui a subi des modifications</param>
        public static void ModifieStagiaire(MStagiaire unStagiaire)
        {
            // instancier le dbContext au besoin
            if (DonneesDAO.DbContextFormation == null) DonneesDAO.DbContextFormation = new FormationsContainer();

            // recherche l'Entity et la renseigne à partir du MStagiaire reçu
            Stagiaires leStagiaire = DonneesDAO.DbContextFormation.StagiairesSet.Find(unStagiaire.NumOsia);
            // renseigne les colonnes à partir de l’objet MStagiaire reçu
            
            leStagiaire.NomStagiaire = unStagiaire.Nom;
            leStagiaire.PrenomStagiaire = unStagiaire.Prenom;
            leStagiaire.rueStagiaire = unStagiaire.Rue;
            leStagiaire.VilleStagiaire = unStagiaire.Ville;
            leStagiaire.CodePostalStagiaire = unStagiaire.CodePostal;
            leStagiaire.PointsNotes = (decimal?)unStagiaire.PointsNotes;
            leStagiaire.NbreNotes = unStagiaire.NbreNotes;
            // champs spécifiques dans la table en fonction du type MStagiaire spécialisé : NB : non modifable actuellement sur le form
            if (leStagiaire is StagiaireCIF)
            {
                // cas d'un CIF
                ((StagiaireCIF)leStagiaire).Fongecif = ((MStagiaireCIF)unStagiaire).Fongecif;
                ((StagiaireCIF)leStagiaire).TypeCIF = ((MStagiaireCIF)unStagiaire).TypeCif;
            }
            else
            {
                // cas d'un DE
                ((StagiaireDE)leStagiaire).RemuAfpa = ((MStagiaireDE)unStagiaire).RemuAfpa;
            }

            try
            {
                
                // déclenche la MAJ sur BDD par le dbContext
                DonneesDAO.DbContextFormation.SaveChanges();
            }
            catch (Exception ex) // a ce niveau, erreur possible en cas de doublon
            {                    // avec un  autre stagiaire déjà chargé en mémoire
                throw ex;        // ou erreur d'accès à la BDD
            }
        }

        /// <summary>
        /// supprime un stagiaire de la table Stagiaires de la BDD
        /// </summary>
        /// <param name="uneCleStagiaire">NumOSIA du stagiaire à supprimer</param>
        public static void SupprimeStagiaire(Int32 uneCleStagiaire)
        {
            // instancier le dbContext au besoin
            if (DonneesDAO.DbContextFormation == null) DonneesDAO.DbContextFormation = new FormationsContainer();

            // recherche l'Entity correspondant à la clé stagiaire fournie
            Stagiaires leStagiaire = DonneesDAO.DbContextFormation.StagiairesSet.Find(uneCleStagiaire);
            // supprime l'Entity du dbContext
            DonneesDAO.DbContextFormation.StagiairesSet.Remove(leStagiaire);
            // déclenche la MAJ sur SQL Server par le dbContext
            DonneesDAO.DbContextFormation.SaveChanges();
        }

        public static MStagiaire RestitueStagiaire()
        {
            return null; //TODO
        }
        
    }


}
