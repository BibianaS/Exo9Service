using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo9
{
    public static class MSectionDAOEFStatic
    {
        public static void InstancieSections(MSections lesSections)
        {
            // instancier le dbContext au besoin
            if (DonneesDAO.DbContextFormation == null) DonneesDAO.DbContextFormation = new FormationsContainer();

            var query = from a in DonneesDAO.DbContextFormation.SectionsSet
                        select a;
            // ref d'objet 
            MSection laSection;
            // parcourt les lignes de l'Entity
            foreach (Sections item in query)
            {

                laSection = new MSection(item.Idsection, item.NomSection, 
                    item.DateDebut, item.DateFin);
                lesSections.Ajouter(laSection);
            }

        }




        public static MSection RestitueSection(String unCodeSection)
        {
            // instancier le dbContext au besoin
            if (DonneesDAO.DbContextFormation == null) DonneesDAO.DbContextFormation = new FormationsContainer();

            MSection laSection;
            Sections leStage = DonneesDAO.DbContextFormation.SectionsSet.Find(unCodeSection);
            laSection = new MSection(leStage.Idsection, leStage.NomSection, leStage.DateDebut, leStage.DateFin);
            return laSection;
        }
    }
}
