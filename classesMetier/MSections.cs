using System;
using System.Collections.Generic;
using System.Text;
using System.Data; // ajouté manuellement

namespace Exo9
{
    public class MSections
    {
        /// <summary>
        /// collection des objets MSection
        /// </summary>
        private SortedDictionary<String , MSection> lesSections;

        /// <summary>
        /// DataTable à 2 colonnes pour restituer la liste des sections
        /// </summary>
        private DataTable dtSections;

        /// <summary>
        /// constructeur par défaut
        /// (initialise la collection et le datatable)
        /// </summary>
        public MSections()
        {
            // instancier la collection 
            lesSections = new SortedDictionary<string, MSection>();
            
            // prépare la DataTable pour restituer la liste des sections
            dtSections = new DataTable();

            // ajouter à la datatable 2 colonnes personnalisées 
            this.dtSections.Columns.Add(new DataColumn("Code Section", typeof(System.String)));
            this.dtSections.Columns.Add(new DataColumn("Nom Section", typeof(System.String)));

        }

        /// <summary>
        /// ajouter une Section à la collection
        /// (reçoit la ref à la section et en déduit la clé (= codesection) pour la collection)
        /// </summary>
        /// <param name="uneSection">la référence de la section à ajouter</param>
        public void Ajouter(MSection uneSection)
        {
            this.lesSections.Add(uneSection.CodeSection, uneSection); // à sécuriser...
        }

        /// <summary>
        /// supprimer une section de la collection
        /// (reçoit la ref à la section et en déduit la clé (= codesection) pour la collection)
        /// </summary>
        /// <param name="uneSection">la référence de la section à supprimer</param>
        public void Supprimer(MSection uneSection)
        {
            this.lesSections.Remove(uneSection.CodeSection); // à sécuriser...
        }

        /// <summary>
        /// supprimer une section de la collection
        /// (reçoit la clé de la section (= codesection) pour la collection)
        /// </summary>
        /// <param name="unCodeSection">la clé (= code section) de la section à supprimer</param>
        /// <exception cref="Exception">Si code section reçu non trouvé en collection</exception>
        public void Supprimer(String unCodeSection)
        {
            // suppression sécurisée
            if (this.lesSections.ContainsKey(unCodeSection))
            {
                this.lesSections.Remove(unCodeSection);
            }
            else
            {
                throw new Exception("Erreur : code Section non trouvé dans la collection");
            }
        }
        /// <summary>
        /// modifier les données d'une section
        /// tout est modifiable sauf le code section (= clé de la collection)
        /// </summary>
        /// <param name="uneSection">la référence au nouvel objet MSection pour cette clé</param>
        public void Remplacer(MSection uneSection)
        {
            // il suffit de modifier la référence à l'objet MSection
            // dans la collection pour ce code Section
            
            //modifier la référence de section stockée dans la collection            
            this.lesSections[uneSection.CodeSection] = uneSection; // à sécuriser...

        }

        /// <summary>
        /// Rechercher une section dans la liste en connaissant sa clé
        /// </summary>
        /// <param name="unCodeSection">le code section (=la clé) de la section à rechercher</param>
        /// <exception cref="Exception">Si code section reçu non trouvé en collection</exception>
        /// <returns>la référence à la section</returns>
        public MSection RestituerSection(String unCodeSection)
        {
            MSection laSection;
            laSection = this.lesSections[unCodeSection] as MSection;
            if (laSection == null)
            {
                throw new Exception("Aucune section trouvée pour le code Section " + unCodeSection);
            }
            else
            {
                return laSection;
            }
        }

        /// <summary>
        /// générer et retourner une datatable
        /// qui liste les codeSection et nomSection
        /// de toutes les sections de la collection
        /// </summary>
        /// <returns>une référence de datatable à 2 colonnes</returns>
        public DataTable ListerSections()
        {
            DataRow dr;   // ligne de la datatable
            //Msection uneSection; // la section en cours dans la collection

            this.dtSections.Clear();
            // boucle de remplissage de la datatable à partir de la collection
            foreach (MSection uneSection in this.lesSections.Values)
            {
                // instanciation datarow (=ligne)
                dr = this.dtSections.NewRow();
                // affectation des 3 colonnes
                // récupérer le valeur de clé
                dr[0] = uneSection.CodeSection;
                // affecter l'autre colonne des valeurs de prop. de l'objet MSection
                dr[1] = uneSection.NomSection;
                // ajouter la ligne à la datatable
                this.dtSections.Rows.Add(dr);
            }
            // retourne la référence à la datatable
            return this.dtSections;
        }

    }
}
