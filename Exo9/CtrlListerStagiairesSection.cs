using System;
using System.Collections;
using System.Text;
using System.Windows.Forms; // ajouté manuellement

namespace Exo9
{
    /// <summary>
    /// controleur du cas d'utilisation : lister les stagiaires d'une section
    /// </summary>
    public class CtrlListerStagiairesSection
    {
        /// <summary>
        /// ref au form d'affichage
        /// </summary>
        private frmExo9 leForm;

        /// <summary>
        /// ref à la section gérée par ce contrôleur
        /// </summary>
        private MSection laSection;

        /// <summary>
        /// constructeur : instancie et personnalise le form frmExo9 et l'affiche en non modal
        /// </summary>
        public CtrlListerStagiairesSection()
        {
            // pour commencer on ne travaille qu'avec la section CDI
            // chargement en DataSet des données de la section CDI
            this.initCDI();
            
            // instancier le form initial
            this.leForm = new frmExo9(this.laSection);
            // implémenter l'événement bouton ajouter clic
            this.leForm.btnAjouter.Click += new EventHandler(btnAjouter_Click);
            // implémenter l'événement bouton supprimer clic
            this.leForm.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            // implémenter l'événement double-clic en datagridview
            this.leForm.grdStagiaires.DoubleClick += new EventHandler(grdStagiaires_DoubleClick);
            // renseigner le form
            this.leForm.AfficheStagiaires(this.laSection); 
            // afficher le form
            this.leForm.MdiParent = Donnees.FrmMDI;
            this.leForm.Show();


        }

        /// <summary>
        /// double-clic sur DataGridView du form frmExo9 :
        /// instancier le form détail en y affichant
        /// le stagiaire correspondant à la ligne double-cliquée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdStagiaires_DoubleClick(object sender, EventArgs e)
        {
            // ouvrir la feuille détail en y affichant 
            // le stagiaire correspondant à la ligne double-cliquée
            MStagiaire leStagiaire;
            Int32 laCle; // clé (=numOSIA) du stagiaire dans la collection

            // récupérer clé du stagiaire cliqué en DataGridView
            laCle = (Int32)this.leForm.grdStagiaires.CurrentRow.Cells[0].Value;
            // instancier un objet stagiaire pointant vers 
            // le stagiaire d'origine dans la collection
            leStagiaire = this.laSection.RestituerStagiaire(laCle);
            // instancier un contrôleur de form détail pour ce stagiaire
            CtrlVisuModifStagiaire ctrlVisuModif = new CtrlVisuModifStagiaire(leStagiaire);
            // en sortie, impacter la MAJ en BDD et régénérer l'affichage du dataGridView
            MStagiaireDAOEFStatic.ModifieStagiaire(leStagiaire);
            this.leForm.AfficheStagiaires(this.laSection);
        }

        /// <summary>
        /// bouton supprimer du form frmExo9 :
        /// supprimer le stagiaire de la collection pour cette section
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //si un stagiaire est pointé dans la datagridview
            if (this.leForm.grdStagiaires.CurrentRow != null)
            {
                // récupérer la clé du stagiaire pointé
                Int32 cleStagiaire;
                cleStagiaire = (Int32)this.leForm.grdStagiaires.CurrentRow.Cells[0].Value;
                // demander confirmation de la suppression
                // NB: messagebox retourne une valeur exploitable !
                if (MessageBox.Show("Voulez-vous supprimer le stagiaire numéro :" + cleStagiaire.ToString(), "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // supprimer et compacter la collection
                    this.laSection.Supprimer(cleStagiaire);
                    // supprimer la ligne correspondante 
                    // impacter en BDD
                    MStagiaireDAOEFStatic.SupprimeStagiaire(cleStagiaire);

                    // réafficher la datagridview
                    this.leForm.AfficheStagiaires(this.laSection);
                }
            }
        }

        /// <summary>
        /// bouton ajouter du form frmExo9 :
        /// instancier un form de saisie via le controleur CtrlAjouterStagiaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // instancier un ctrl form de saisie de stagiaire pour afficher le form en modal
            CtrlNouveauStagiaire ctrlNouveau = new CtrlNouveauStagiaire(this.laSection);
            
            // si on sort de la saisie par OK
            if (ctrlNouveau.Resultat == DialogResult.OK)
            {
                try
                {
                    // ajouter la référence de l'objet MStagiaire créé par le ctrleur dans la collection des stagiaires de la section
                    this.laSection.Ajouter(ctrlNouveau.LeStagiaire);
                    try
                    {

                        // mettre à jour la BDD
                        // instancier l'Entity correspondante et l'ajouter au dbSet
                        // et mettre à jour la BDD à l'aide du dbcontext
                        MStagiaireDAOEFStatic.InsereStagiaire(ctrlNouveau.LeStagiaire, this.laSection);
                    }
                    catch (Exception ex) // NB : erreur BDD mais stagiaire déjà ajouté en collection
                    {
                        // afficher l'erreur
                        this.leForm.LeveErreur(ex);
                        // supprimer le MStagiaire de la collection
                        this.laSection.Supprimer(ctrlNouveau.LeStagiaire);
                        // défaire ce qui a été éventuellement fait en BDD
                        MStagiaireDAOEFStatic.SupprimeStagiaire(ctrlNouveau.LeStagiaire.NumOsia);
                    }
                }
                // gestion des erreurs en MAJ de la collection des MStagiaire de la section
                catch (Exception ex)
                {
                    this.leForm.LeveErreur(ex);
                }
                finally // dans tous les cas, erreur ou non
                {
                    // régénèrer l'affichage du dataGridView 
                    this.leForm.AfficheStagiaires(this.laSection);
                }
            }
        }

        /// <summary>
        /// initialisation section CDI et chargement des stagiaires correspondants
        /// </summary>
        private void initCDI()
        {
            // initialisation de la collection de sections
            Donnees.Sections = new MSections();
            // pour commencer, une seule section référencée "en dur" dans ce programme
            // instancie la section
            //this.laSection = new MSection("CDI", "Concepteur Développeur Informatique", null, null);
            // l'ajoute dans la collection des sections gérée par la classe de collection
            //Donnees.Sections.Ajouter(this.laSection); 
            
            // chargement section depuis la BDD
            this.laSection = MSectionDAOEFStatic.RestitueSection("CDI");
            Donnees.Sections.Ajouter(this.laSection);

            // chargement et instanciation des données Stagiaires de cette section depuis la BDD
            MStagiaireDAOEFStatic.InstancieStagiairesSection(this.laSection);
        }



    }
}
