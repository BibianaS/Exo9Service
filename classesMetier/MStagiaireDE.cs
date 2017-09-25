using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Exo9
{
    /// <summary>
    /// stagiaire spécialisé statut Demandeur d'emploi
    /// </summary>
    [DataContract]
    public class MStagiaireDE : MStagiaire
    {
        /// <summary>
        /// constructeur par défaut  ==> proscrit...
        /// (appelle le constructeur classe de base)
        /// </summary>
        //public MStagiaireDE()
        //    : base()
        //{
        //    this.RemuAfpa = false;
        //}


        /// <summary>
        /// constructeur d'initialisation
        /// (appelle le constructeur d'initialisation de la classe de base)
        /// </summary>
        /// <param name="unNumosia">numéro OSIA</param>
        /// <param name="unNom">Nom</param>
        /// <param name="unPrenom">Prénom</param>
        /// <param name="uneRue">Adresse</param>
        /// <param name="uneVille">Ville</param>
        /// <param name="UnCodePostal">Code Postal</param>
        /// <param name="unRemuAfpa">Rémunaration par l'Afpa</param>
        public MStagiaireDE(Int32 unNumosia, String unNom, String unPrenom, String uneRue, String uneVille, String UnCodePostal,
            Boolean unRemuAfpa)
            : base(unNumosia, unNom, unPrenom, uneRue, uneVille, UnCodePostal)
        {
            this.RemuAfpa = unRemuAfpa;
        }

        /// <summary>
        /// Rémuneration par l'Afpa
        /// </summary>
        private Boolean remuAfpa;

        /// <summary>
        /// obtient ou définit Rémuneration par l'Afpa
        /// </summary>
        [DataMember]
        public Boolean RemuAfpa
        {
            get
            {
                return this.remuAfpa;
            }
            set
            {
                this.remuAfpa = value;
            }
        }

    }
}
