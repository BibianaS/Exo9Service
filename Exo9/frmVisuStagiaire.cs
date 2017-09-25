using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exo9
{
    /// <summary>
    /// form de visu / modif d'un stagiaire
    /// </summary>
    public partial class frmVisuStagiaire : frmStagiaire
    {

        /// <summary>
        /// le stagiaire à afficher / modifier
        /// (on ne travaille pas directement sur le stagiaire fourni
        /// et l'utilisateur pourra abandonner par bouton Annuler)
        /// </summary>
        private MStagiaire leStagiaire;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unStagiaire"></param>
        public frmVisuStagiaire(MStagiaire unStagiaire) 
        {
            InitializeComponent();

            this.leStagiaire = unStagiaire;


        }


        /// <summary>
        /// fermer sans incidence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// abandon de modif en cours ==> réafficher anciennes valeurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            // réafficher le stagiaire d'origine
            this.AfficheStagiaire(this.leStagiaire);

        }

        /// <summary>
        /// impacter les modifications saisies sur le form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void Valider()
        {
            try
            {
                // modifier les valeurs du stagiaire pointé par la ref temporaire
                // (sauf numéro OSIA non modifiable)
                this.leStagiaire.Nom = this.txtNom.Text;
                this.leStagiaire.Prenom = this.txtPrenom.Text;
                this.leStagiaire.Rue = this.txtAdresse.Text;
                this.leStagiaire.Ville = this.txtVille.Text;
                this.leStagiaire.CodePostal = this.txtCodePostal.Text;
                // fermer le form
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : \n" + ex.Message, "Modification de stagiaire");

            }
        }


        /// <summary>
        /// au démarrage, afficher le stagiaire reçu sur le form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVisuStagiaire_Load(object sender, EventArgs e)
        {
            // afficher le stagiaire temporaire
            this.AfficheStagiaire(this.leStagiaire);
        }


        /// <summary>
        /// affiche en textbox les données d'un stagiaire reçu
        /// </summary>
        /// <param name="unStagiaire">la référence du stagiaire à afficher</param>
        public void AfficheStagiaire(MStagiaire unStagiaire)
        {
            // affecter les textbox
            this.txtOSIA.Text = unStagiaire.NumOsia.ToString();
            this.txtNom.Text = unStagiaire.Nom;
            this.txtPrenom.Text = unStagiaire.Prenom;
            this.txtAdresse.Text = unStagiaire.Rue;
            this.txtVille.Text = unStagiaire.Ville;
            this.txtCodePostal.Text = unStagiaire.CodePostal;
            this.AfficheMoyenne(this.leStagiaire);
            if (unStagiaire is MStagiaireCIF)
            {
                this.rbtCIF.Checked = true;
            }
            else
            {
                this.rbtDE.Checked = true;
            }
            // placer le curseur sur le nom
            this.txtNom.Focus();

        }

        /// <summary>
        /// affiche la mot=yenne actualisée
        /// </summary>
        public void AfficheMoyenne(MStagiaire unStagiaire)
        {
            this.lblValeurMoyenne.Text = unStagiaire.DonnerMoyenne().ToString();
        }

        
    }
}

