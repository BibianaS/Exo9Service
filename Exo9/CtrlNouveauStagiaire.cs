using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms; // ajouté manuellement


namespace Exo9
{
    /// <summary>
    /// controleur du cas d'utilisation : ajout de stagiaire à une section
    /// </summary>
    public class CtrlNouveauStagiaire
    {
        /// <summary>
        /// ref au form frmAjoutStagiaire
        /// </summary>
        private frmAjoutStagiaire leForm;

        /// <summary>
        /// ref au stagiaire saisi par ce form
        /// </summary>
        private MStagiaire leStagiaire;
        
        /// <summary>
        /// obtient la ref au stagiaire saisi par le form frmAjoutStagiaire
        /// </summary>
        public MStagiaire LeStagiaire
        {

            get
            {
                return this.leStagiaire;
            }
        }

        /// <summary>
        /// ref à la section du stagiaire traité
        /// </summary>
        private MSection laSection;

        /// <summary>
        /// résultat du dialogue modal assuré par le form frmAjoutStagiaire
        /// </summary>
        private DialogResult resultat;

        /// <summary>
        /// obtient le résultat du dialogue modal assuré par le form frmAjoutStagiaire
        /// </summary>
        public DialogResult Resultat
        {
            get
            {
                return this.resultat;
            }
        }

        /// <summary>
        /// constructeur : instancie et personnalise le form et l'affiche en modal;
        /// récupère ensuite le résultat du dialogue et la ref du stagiaire instancié
        /// </summary>
        /// <param name="uneSection">la section du stagiaire à créer</param>
        public CtrlNouveauStagiaire(MSection uneSection)
        {
            this.laSection = uneSection;
            // instancier le form initial
            this.leForm = new frmAjoutStagiaire(this.laSection);
            this.leForm.Text += this.laSection.ToString();
            // variante avec plus de contrôle du from par le Contrôleur
            this.leForm.btnOK.Click += new EventHandler(this.btnOK_Click);
            // afficher le form
            this.leForm.ShowDialog();
            // en fin de dialogue modal récupérer la ref du stagiaire spécialisé instancié par le form
            this.leStagiaire = this.leForm.LeStagiaire;
        }

        /// <summary>
        /// bouton OK du form : demande au form de se contrôler puis
        /// d'instancier un objet MStagiaire spécialisé 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            // controle vraissemblance des données saisies sur le form
            if (this.leForm.Controle())
            {

                //  instancie l'objet MStagiaire spécialisé   
                if (this.leForm.Instancie())
                {
                    this.leForm.DialogResult = DialogResult.OK; // fermer le form si OK
                    // en fin de dialogue modal récupérer le résultat de la saisie
                    this.resultat = this.leForm.DialogResult;
                }
                else // erreur d'instanciation objet stagiaire
                {
                    this.resultat = DialogResult.No; // erreur à remonter
                }
            }
        }


    }
}
