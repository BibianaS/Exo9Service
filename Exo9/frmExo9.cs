using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections; // ajouté manuellement


namespace Exo9
{
    /// <summary>
    /// form de démarrage : datagridview des stagiaires de la section DI
    /// </summary>
    public partial class frmExo9 : Form
    {

        /// <summary>
        /// la section de stagiaires gérée par ce form
        /// </summary>
        private MSection laSection; 
        
        /// <summary>
        /// Constructeur 
        /// </summary>
        public frmExo9(MSection uneSection)
        {
            InitializeComponent();
            this.Text += uneSection.NomSection; // personnalise le titre de la fenêtre
            this.laSection = uneSection;
        }

        /// <summary>
        /// rétablit la source de données de la dataGridView
        /// et rafraîchit son affichage
        /// </summary>
        public void AfficheStagiaires(MSection laSection)
        {
            // déterminer l'origine des données à afficher : 
            // appel de la méthode de la classe MSection 
            // qui alimente et retourne une datatable
            // à partir de sa collection de stagiaires
            this.grdStagiaires.DataSource = laSection.ListerStagiaires(); 
            // refraîchir l'affichage
            this.grdStagiaires.Refresh();
            // gestion bouton supprimer
            // admirer la syntaxe...
            this.btnSupprimer.Enabled = (this.grdStagiaires.CurrentRow == null ? false: true);
        }

        

        

        /// <summary>
        /// bouton fermer : fermer le form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// active ou désactive le bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdStagiaires_SelectionChanged(object sender, EventArgs e)
        {
            // gestion bouton supprimer
            // admirer la syntaxe...
            this.btnSupprimer.Enabled = (this.grdStagiaires.CurrentRow == null ? false : true);

        }

        /// <summary>
        /// affiche le label d'erreur
        /// </summary>
        /// <param name="ex"></param>
        public void LeveErreur(Exception ex)
        {
            this.lblErreur.Text = ex.Message;
        }

  
    }
    
}