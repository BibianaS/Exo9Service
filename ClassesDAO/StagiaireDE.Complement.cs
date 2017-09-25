using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo9
{
    public partial class StagiaireDE
    {
        public StagiaireDE()
            : base()
        {

        }
        public StagiaireDE(int unNumOsia, String unNom, String unPrenom, String uneRue, String uneVille, String unCodePostal, int? unNbreNotes, Decimal? unPointsNotes, Sections unStage, Boolean uneRemu)
            : base(unNumOsia, unNom, unPrenom, uneRue, uneVille, unCodePostal, unNbreNotes, unPointsNotes, unStage)
        {
            this.RemuAfpa = uneRemu;
        }
    }
}
