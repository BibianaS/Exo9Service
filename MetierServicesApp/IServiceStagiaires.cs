using Exo9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace MetierServicesApp
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IServiceStagiaires
    {
        /// <summary>
        /// Permet de récupérer une section
        /// </summary>
        /// <param name="value"></param>
        /// <returns>MSection</returns>
        [OperationContract]
        MSection GetSection(String codeSection);

        /// <summary>
        /// Permet de récuperer la liste de stagiaires d'une section
        /// </summary>
        /// <param name="codeSection"></param>
        /// <returns>IList MStagiare</returns>
        [OperationContract]
        IList<MStagiaire> GetStagiairesSection(String codeSection);

        /// <summary>
        /// Insérer un stagiare
        /// </summary>
        /// <param name="newStagiaire"></param>
        /// <param name="laSection"></param>
        /// <returns>Retourne un string vide en cas de succes et un message d'erreur ou cas ou</returns>
        [OperationContract]
        String AddStagiaire(MStagiaire newStagiaire, MSection laSection);

        /// <summary>
        /// Modifie un stagiare
        /// </summary>
        /// <param name="leStagiaire"></param>
        /// <returns>Retourne un string vide en cas de succes  et un message en cas d'échec</returns>
        [OperationContract]
        String UpdateStagiaire(MStagiaire leStagiaire);

        /// <summary>
        /// Supprimer un stagiare
        /// </summary>
        /// <param name="laCleStagiaire"></param>
        /// <returns>Retourne true si oket false si pas OK</returns>
        [OperationContract]
        Boolean DeleteStagiaire(Int32 laCleStagiaire);
    }


}
