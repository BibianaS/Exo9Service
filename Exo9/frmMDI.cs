using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exo9
{
    public partial class frmMDI : Form
    {
        //private int childFormNumber = 0;

        public frmMDI()
        {
            InitializeComponent();
            // mémo globale du form MDI 
            Donnees.FrmMDI = this;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //// Créez une nouvelle instance du formulaire enfant.
            //Form childForm = new Form();
            //// Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
            //childForm.MdiParent = this;
            //childForm.Text = "Fenêtre " + childFormNumber++;
            //childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //    // TODO : ajoutez le code ici pour ouvrir le fichier.
            //}

            // instancier le controleur Lister les stagiaires d'une section
            CtrlListerStagiairesSection ctrl = new CtrlListerStagiairesSection();

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            //if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = saveFileDialog.FileName;
            //    // TODO : ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
            //}
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO : utilisez System.Windows.Forms.Clipboard pour insérer le texte ou les images sélectionnés dans le Presse-papiers
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO : utilisez System.Windows.Forms.Clipboard pour insérer le texte ou les images sélectionnés dans le Presse-papiers
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO : utilisez System.Windows.Forms.Clipboard.GetText() ou System.Windows.Forms.GetData pour extraire les informations du Presse-papiers.
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void openCDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instancier le controleur Lister les stagiaires d'une section
            CtrlListerStagiairesSection ctrl = new CtrlListerStagiairesSection();
        }
    }
}
