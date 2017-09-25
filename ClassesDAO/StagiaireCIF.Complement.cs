using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo9
{
    public partial class StagiaireCIF
    {
        public StagiaireCIF()
            : base()
        {

        }
        public StagiaireCIF(int unNumOsia, String unNom, String unPrenom, String uneRue, String uneVille, String unCodePostal, int? unNbreNotes, Decimal? unPointsNotes, Sections unStage, String unFongecif, String unTypeCIF)
            : base(unNumOsia, unNom, unPrenom, uneRue, uneVille, unCodePostal, unNbreNotes, unPointsNotes, unStage)
        {
            this.Fongecif = unFongecif;
            this.TypeCIF = unTypeCIF;
        }
    }
}
