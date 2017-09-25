namespace Exo9
{
    partial class frmVisuStagiaire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSaisirNote = new System.Windows.Forms.Button();
            this.lblmoyenne = new System.Windows.Forms.Label();
            this.lblValeurMoyenne = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtDE = new System.Windows.Forms.RadioButton();
            this.rbtCIF = new System.Windows.Forms.RadioButton();
            this.grpStagiaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStagiaire
            // 
            this.grpStagiaire.Controls.Add(this.lblmoyenne);
            this.grpStagiaire.Controls.Add(this.lblValeurMoyenne);
            this.grpStagiaire.Controls.Add(this.rbtCIF);
            this.grpStagiaire.Controls.Add(this.rbtDE);
            this.grpStagiaire.Controls.Add(this.label1);
            this.grpStagiaire.Size = new System.Drawing.Size(429, 335);
            this.grpStagiaire.Controls.SetChildIndex(this.label1, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.rbtDE, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.rbtCIF, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.lblValeurMoyenne, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.lblmoyenne, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtCodePostal, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtVille, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtAdresse, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtPrenom, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtNom, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtOSIA, 0);
            // 
            // txtOSIA
            // 
            this.txtOSIA.ReadOnly = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(366, 353);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(204, 353);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "&Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(285, 353);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSaisirNote
            // 
            this.btnSaisirNote.Location = new System.Drawing.Point(123, 353);
            this.btnSaisirNote.Name = "btnSaisirNote";
            this.btnSaisirNote.Size = new System.Drawing.Size(75, 23);
            this.btnSaisirNote.TabIndex = 4;
            this.btnSaisirNote.Text = "Saisir note";
            this.btnSaisirNote.UseVisualStyleBackColor = true;
            // 
            // lblmoyenne
            // 
            this.lblmoyenne.AutoSize = true;
            this.lblmoyenne.Location = new System.Drawing.Point(36, 268);
            this.lblmoyenne.Name = "lblmoyenne";
            this.lblmoyenne.Size = new System.Drawing.Size(94, 13);
            this.lblmoyenne.TabIndex = 12;
            this.lblmoyenne.Text = "Moyenne actuelle:";
            // 
            // lblValeurMoyenne
            // 
            this.lblValeurMoyenne.AutoSize = true;
            this.lblValeurMoyenne.Location = new System.Drawing.Point(198, 268);
            this.lblValeurMoyenne.Name = "lblValeurMoyenne";
            this.lblValeurMoyenne.Size = new System.Drawing.Size(0, 13);
            this.lblValeurMoyenne.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(36, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Statut pour info :";
            // 
            // rbtDE
            // 
            this.rbtDE.AutoSize = true;
            this.rbtDE.Checked = true;
            this.rbtDE.Enabled = false;
            this.rbtDE.Location = new System.Drawing.Point(201, 301);
            this.rbtDE.Name = "rbtDE";
            this.rbtDE.Size = new System.Drawing.Size(40, 17);
            this.rbtDE.TabIndex = 15;
            this.rbtDE.TabStop = true;
            this.rbtDE.Text = "DE";
            this.rbtDE.UseVisualStyleBackColor = true;
            // 
            // rbtCIF
            // 
            this.rbtCIF.AutoSize = true;
            this.rbtCIF.Enabled = false;
            this.rbtCIF.Location = new System.Drawing.Point(292, 301);
            this.rbtCIF.Name = "rbtCIF";
            this.rbtCIF.Size = new System.Drawing.Size(41, 17);
            this.rbtCIF.TabIndex = 16;
            this.rbtCIF.Text = "CIF";
            this.rbtCIF.UseVisualStyleBackColor = true;
            // 
            // frmVisuStagiaire
            // 
            this.AcceptButton = this.btnValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(453, 389);
            this.Controls.Add(this.btnSaisirNote);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFermer);
            this.Name = "frmVisuStagiaire";
            this.Text = "Visualisation / Modification des stagiaires Section DI";
            this.Load += new System.EventHandler(this.frmVisuStagiaire_Load);
            this.Controls.SetChildIndex(this.btnFermer, 0);
            this.Controls.SetChildIndex(this.grpStagiaire, 0);
            this.Controls.SetChildIndex(this.btnValider, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.btnSaisirNote, 0);
            this.grpStagiaire.ResumeLayout(false);
            this.grpStagiaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblmoyenne;
        private System.Windows.Forms.Label lblValeurMoyenne;
        private System.Windows.Forms.RadioButton rbtDE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtCIF;
        internal System.Windows.Forms.Button btnSaisirNote;
        internal System.Windows.Forms.Button btnValider;
    }
}
