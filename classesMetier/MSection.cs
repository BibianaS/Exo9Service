using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.Serialization;

namespace Exo9
{
    /// <summary>
    /// classe des sections de stagiaires
    /// </summary>
    [Serializable]
    [DataContract]
    public class MSection
    {

        /// <summary>
        /// code de la section = sa clé 
        /// ==> en lecture seule et initialisé dans le constructeur
        /// </summary>
        private String leCodeSection;


        /// <summary>
        /// obtient le code de la section (lecture seule)
        /// </summary>
        [DataMember]
        public String CodeSection
        {
            get { return leCodeSection; }
            private set { this.leCodeSection = value; }
        }



        /// <summary>
        /// libellé de la section
        /// (non initialisé dans le constructeur)
        /// </summary>        
        private String leNomSection;
        /// <summary>
        /// obtient ou définit le libellé de la section
        /// </summary>
        [DataMember]
        public String NomSection
        {
            get { return leNomSection; }
            set { leNomSection = value; }
        }



        /// <summary>
        /// date de début de la formation
        /// </summary>
        private DateTime? debutFormation;
        /// <summary>
        /// obtient ou définit  la date de début de la formation
        /// </summary>
        [DataMember]
        public DateTime? DebutFormation
        {
            get
            {
                return this.debutFormation;
            }
            set
            {
                this.debutFormation = value;
            }
        }


        /// <summary>
        /// date de fin de la formation
        /// </summary>
        private DateTime? finFormation;
        /// <summary>
        /// obtient ou définit la date de fin de la formation
        /// </summary>
        [DataMember]
        public DateTime? FinFormation
        {
            get
            {
                return this.finFormation;
            }
            set
            {
                this.finFormation = value;
            }
        }


        /// <summary>
        /// collection des stagiaires de cette section 
        /// sous forme de idctionnaire trié
        /// </summary>
        private SortedDictionary<Int32, MStagiaire> lesStagiaires;

        /// <summary>
        /// datatable des stagiaires pour affichages en datagridview 
        /// et pour exporter/importer en XML
        /// </summary>
        private DataTable dtStagiaires;
                       
        /// <summary>
        /// constructeur 
        /// </summary>
        /// <param name="leCode">le code de la section</param>
        /// <param name="leNom">le libellé de la section</param>
        public  MSection(String leCode, String leNom, DateTime? laDateDebut, DateTime? laDateFin )
        {
            // initialise les code et nom de la section
            this.leCodeSection = leCode;
            this.NomSection = leNom;
            this.DebutFormation = laDateDebut;
            this.FinFormation = laDateFin;
            // instancie un dictionnaire vide pour les stagiaires
            lesStagiaires = new SortedDictionary<int,MStagiaire>();
            // datatable : pour recopier les stagiaires (stockés en collection)
            // et à fournir aux composants de présentation 
            dtStagiaires = new DataTable();

            // ajout à la datatable de 3 colonnes personnalisées 
            this.dtStagiaires.Columns.Add(new DataColumn("Numéro OSIA", typeof(System.Int32)));
            this.dtStagiaires.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            this.dtStagiaires.Columns.Add(new DataColumn("Prénom", typeof(System.String)));

        }

        /// <summary>
        /// ajouter un stagiaire à la collection
        /// (reçoit la ref au stagiaire et en déduit la clé (= numOsia) pour la collection)
        /// </summary>
        /// <param name="unStagiaire">la référence du stagiaire à ajouter</param>
        public void Ajouter(MStagiaire unStagiaire)
        {
            this.lesStagiaires.Add(unStagiaire.NumOsia, unStagiaire);
        }

        /// <summary>
        /// supprimer un stagaire de la collection
        /// (reçoit la ref au stagiaire et en déduit la clé (= numOsia) pour la collection)
        /// </summary>
        /// <param name="unStagiaire">la référence au stagiaire à supprimer</param>
        public void Supprimer(MStagiaire unStagiaire)
        {
            this.lesStagiaires.Remove(unStagiaire.NumOsia); // à sécuriser...
        }

        /// <summary>
        /// supprimer un stagaire de la collection
        /// (reçoit la clé du stagiaire (= numOsia) pour la collection
        /// </summary>
        /// <param name="unNumOSIA">la clé (= numOsia) du stagiaire à supprimer</param>
        /// <exception cref="Exception">Si numOSIA reçu non trouvé en collection</exception>
        public void Supprimer(Int32 unNumOSIA)
        {
            // suppression sécurisée
            if (this.lesStagiaires.ContainsKey(unNumOSIA))
            {
                this.lesStagiaires.Remove(unNumOSIA);
            }
            else
            {
                throw new Exception("Erreur : numéro OSIA non trouvé dans la collection");
            }
        }

        /// <summary>
        /// modifier les données d'un stagiaire
        /// tout est modifiable sauf le numOsia (= clé de la collection)
        /// </summary>
        /// <param name="unStagiaire">la référence au nouvel objet MStagiaire pour cette clé</param>
        public void Remplacer(MStagiaire unStagiaire)
        {
            // il suffit de modifier la référence à l'objet MStagiaire
            // dans la collection pour ce numOsia

            //modifier la référence de stagiaire stockée dans la collection            
            this.lesStagiaires[unStagiaire.NumOsia] = unStagiaire;

        }
        
        /// <summary>
        /// Rechercher un stagiaire dans la liste en connaissant sa clé
        /// </summary>
        /// <param name="unNumOsia">le numéro OSIA (=la clé) du stagiaire à rechercher</param>
        /// <returns>la référence au stagiaire (ou bien lève une erreur)</returns>
        public MStagiaire RestituerStagiaire(Int32 unNumOsia)
        {
            MStagiaire leStagiaire;
            leStagiaire = this.lesStagiaires[unNumOsia] ;
            if (leStagiaire == null)
            {
                throw new Exception("Aucun stagiaire pour le numéro OSIA " + unNumOsia.ToString());
            }
            else
            {
                return leStagiaire;
            }
        }
        
        /// <summary>
        /// générer et retourner une datatable
        /// qui liste les nomOsia, nom et prenom
        /// de tous les stagaires de la collection
        /// </summary>
        /// <returns>une référence de datatable à 3 colonne</returns>
        public DataTable ListerStagiaires()
        {
            
            // boucle de remplissage de la datatable à partir de la collection
            this.dtStagiaires.Clear();
            foreach( MStagiaire unStagiaire in this.lesStagiaires.Values)
            {
                // instanciation datarow (=ligne)
                DataRow dr;   // ligne de la datatable
                dr = this.dtStagiaires.NewRow();
                // affectation des 3 colonnes
                dr[0] = unStagiaire.NumOsia;
                dr[1] = unStagiaire.Nom;
                dr[2] = unStagiaire.Prenom;
                // ajouter la ligne à la datatable
                this.dtStagiaires.Rows.Add(dr);
            }
            // retourne la référence à la datatable
            return this.dtStagiaires;
        }

    }
}
