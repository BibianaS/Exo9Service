using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Exo9
{
    /// <summary>
    /// classe des stagiaires
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(MStagiaireCIF))]
    [KnownType(typeof(MStagiaireDE))]

    public class MStagiaire // abstract
    {

        /// <summary>
        /// constructeur par défaut  ==> proscrit...
        /// initialise nbrepoints et nbrenotes
        /// </summary>
        //public MStagiaire()
        //{
        //    this.NbreNotes = 0;
        //    this.PointsNotes = 0;

        //}

        /// <summary>
        /// constructeur d'initialisation
        /// </summary>
        /// <param name="unNumosia">Numéro OSIA</param>
        /// <param name="unNom">nom</param>
        /// <param name="unPrenom">prénom</param>
        /// <param name="uneRue">adresse</param>
        /// <param name="uneVille">ville</param>
        /// <param name="UnCodePostal">code postal</param>
        public MStagiaire(Int32 unNumosia, String unNom, String unPrenom, String uneRue, String uneVille, String UnCodePostal)
        {
            // utilise les property set sauf pour numosia
            this.numOsia = unNumosia;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Rue = uneRue;
            this.Ville = uneVille;
            this.CodePostal = UnCodePostal;
            this.nbreNotes = 0;
            this.pointsNotes = 0;

        }


        /// <summary>
        /// numéro du stagiaire
        /// </summary>
        private Int32 numOsia;
        /// <summary>
        /// obtient le numéro OSIA du stagiaire
        /// </summary>
        [DataMember]
        public Int32 NumOsia
        {
            get { return numOsia; }
            private set { this.numOsia = value; }
        }

        
        /// <summary>
        /// le nom du stagiaire
        /// </summary>
        protected String nomStagiaire;
        /// <summary>
        /// obtient ou définit le nom du stagiaire (forcé en majuscules)
        /// </summary>
        [DataMember]
        public String Nom
        {
            get { return nomStagiaire; } // en lecture, retourne la var privée
            // cette portion de code sert à l’affectation d’une nouvelle valeur ;
            // c’est ici que l’on effectue des contrôles de saisie ou de format
            // ici : mettre le nom en majuscules :
            set { nomStagiaire = value.Trim().ToUpper(); } // mettre le nom en majuscules 
        }


        /// <summary>
        /// le prénom de stagiaire
        /// </summary>
        protected String prenomStagiaire;
        /// <summary>
        /// obtient ou définit le prénom de stagiaire (forcé en minuscules)
        /// </summary>
        [DataMember]
        public String Prenom
        {
            get { return prenomStagiaire; } // en lecture, retourne la var privée
            set { prenomStagiaire = value.Trim().ToLower(); } // mettre le prénom en minuscules 
        }


        /// <summary>
        /// immeuble, rue et numéro, le format est libre
        /// </summary>
        private String rue;
        /// <summary>
        /// obtient ou définit rue et numéro, le format est libre
        /// </summary>
        [DataMember]
        public String Rue
        {
            get { return rue; }
            set { rue = value; }
        } 

        
        /// <summary>
        /// le nom de la ville
        /// </summary>
        protected String villeStagiaire;
        /// <summary>
        /// obtient ou définit le nom de la ville (forcé en majuscules)
        /// </summary>
        [DataMember]
        public String Ville
        {
            get { return villeStagiaire; } // en lecture, retourne la var privée
            set { villeStagiaire = value.Trim().ToUpper(); } // mettre la ville en majuscules 
        }

        
        /// <summary>
        /// le code postal, l'appelant devra prendre garde à passer 
        /// un code postal valide à 5 chiffres
        /// </summary>
        protected String codePostalStagiaire;
        /// <summary>
        /// obtient ou définit le code postal (contrôle : 5 car tous chiffres)
        /// </summary>
        /// <exception cref="Exception">le code postal n'est pas constitué de 5 chiffres</exception>
        [DataMember]
        public  String CodePostal          
        {
            get { return codePostalStagiaire; } // en lecture, retourne la var privée
            set 
            {
                // l'appelant doit fournir un code postal valide à 5 chiffres
                Int32 i ;               // variable  de boucle
                Boolean erreur = false; // indicateur erreur
                if (value.Length == 5 ) // 5 car. attendus : OK ==> contrôler un à un
                {
                    for (i = 0; i< value.Length; i++)  // controle chiffres par boucle
                    {
                        if (! (Char.IsDigit(value[i]))) // charabia ??
                            {erreur = true;}
                        
                    } // fin de boucle controle chiffres
                    if (erreur) //on a rencontre un non-chiffre
                    {
                        // levée d'exception
                        throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres");
                    }
                    else
                    {
                        codePostalStagiaire = value;  // tout est bon, on affecte la propriété
                    }
                }
                else // il n'y a pas 5 caractères
                {
                    // levée d'exception
                    throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins");
                }

            }
          
        }



        /// <summary>
        /// nombre de notes obtenues
        /// </summary>
        private Int32? nbreNotes;
        /// <summary>
        /// obtient le nombre de notes du stagiaire
        /// </summary>
        [DataMember]
        public Int32? NbreNotes
        {
            get { return nbreNotes; }
            private set { this.nbreNotes = value; }
        }


        /// <summary>
        /// cumul des points obtenus
        /// </summary>
        private Double pointsNotes;
        /// <summary>
        /// obtient le nombre de points du stagiaire
        /// </summary>
        [DataMember]
        public Double PointsNotes
        {
            get { return pointsNotes; }
            private set { this.pointsNotes = value; }
        } 
        
        /// <summary>
        /// permet d'alimenter NbreNotes et PointsNotes
        /// </summary>
        /// <param name="laNote">la nouvelle note à prendre en compte</param>
        public void RecevoirNote(Single laNote)
        {
            this.nbreNotes++;
            this.pointsNotes += laNote;
        }

        /// <summary>
        /// obtient la moyenne des notes reçues
        /// </summary>
        /// <returns>nouvelle moyenne des notes</returns>
        public Double? DonnerMoyenne()            
        {
            if (this.nbreNotes > 0)
            {
                return this.pointsNotes / this.nbreNotes;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// obtient un libellé en clair (numosia + nom et prénom)
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "Stagiaire " + this.NumOsia + " : " + this.Nom.Trim() + " " + this.Prenom.Trim();
        }            

        /// <summary>
        /// Affecte points et notes d'un Stagiaire
        /// Utilisable uniquement par classe DAO pour restaurer un objet Métier depuis la BDD
        /// </summary>
        /// <param name="desPoints">nombre de points</param>
        /// <param name="desNotes">nombre de notes</param>
        /// <param name="undemandeur">nom du type de la classe demandeur</param>
        public void SetPoints(Double desPoints, Int32 desNotes, String  undemandeur)
        {
            if ((undemandeur == "Exo9.MStagiaireDAOStatic") || (undemandeur == "Exo9.MStagiaireDAOEFStatic"))
            {
                this.pointsNotes = desPoints;
                this.nbreNotes = desNotes;
            }
            else
            {
                throw new Exception("Violation d'accès aux notes Stagiaires");
            }
        }
    }


}
