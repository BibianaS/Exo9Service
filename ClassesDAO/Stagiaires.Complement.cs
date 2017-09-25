using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo9
{
    public partial class Stagiaires
    {
        /// <summary>
        /// constructeur standard utilisé par Entity Framework
        /// </summary>
        public Stagiaires()
        {

        }
        /// <summary>
        /// constructeur d'initialisation utilisé par les classes DAO
        /// </summary>
        /// <param name="unNumOsia"></param>
        /// <param name="unNom"></param>
        /// <param name="unPrenom"></param>
        /// <param name="uneRue"></param>
        /// <param name="uneVille"></param>
        /// <param name="unCodePostal"></param>
        /// <param name="unNbreNotes"></param>
        /// <param name="unPointsNotes"></param>
        /// <param name="unStage"></param>
        public Stagiaires(int unNumOsia, String unNom, String unPrenom, String uneRue, String uneVille, String unCodePostal, int? unNbreNotes, Decimal? unPointsNotes, Sections unStage)

        {
            this.NumOsia = unNumOsia;
            this.NomStagiaire = unNom;
            this.PrenomStagiaire = unPrenom;
            this.rueStagiaire = uneRue;
            this.VilleStagiaire = uneVille;
            this.CodePostalStagiaire = unCodePostal;
            this.NbreNotes = unNbreNotes;
            this.PointsNotes = unPointsNotes;
            this.Sections = unStage;
        }
    }
}
