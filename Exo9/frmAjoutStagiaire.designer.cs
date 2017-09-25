namespace Exo9
{
    partial class frmAjoutStagiaire
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRemuAfpa = new System.Windows.Forms.CheckBox();
            this.grpTypeCIF = new System.Windows.Forms.GroupBox();
            this.txtFongecif = new System.Windows.Forms.TextBox();
            this.lblFongecif = new System.Windows.Forms.Label();
            this.rbtTT = new System.Windows.Forms.RadioButton();
            this.rbtCDD = new System.Windows.Forms.RadioButton();
            this.rbtCDI = new System.Windows.Forms.RadioButton();
            this.rbtDE = new System.Windows.Forms.RadioButton();
            this.rbtCIF = new System.Windows.Forms.RadioButton();
            this.grpStagiaire.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpTypeCIF.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStagiaire
            // 
            this.grpStagiaire.Controls.Add(this.groupBox1);
            this.grpStagiaire.Size = new System.Drawing.Size(429, 393);
            this.grpStagiaire.Controls.SetChildIndex(this.groupBox1, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtCodePostal, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtVille, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtAdresse, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtPrenom, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtNom, 0);
            this.grpStagiaire.Controls.SetChildIndex(this.txtOSIA, 0);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(285, 411);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(366, 411);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRemuAfpa);
            this.groupBox1.Controls.Add(this.grpTypeCIF);
            this.groupBox1.Controls.Add(this.rbtDE);
            this.groupBox1.Controls.Add(this.rbtCIF);
            this.groupBox1.Location = new System.Drawing.Point(32, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statut";
            // 
            // chkRemuAfpa
            // 
            this.chkRemuAfpa.AutoSize = true;
            this.chkRemuAfpa.Location = new System.Drawing.Point(45, 52);
            this.chkRemuAfpa.Name = "chkRemuAfpa";
            this.chkRemuAfpa.Size = new System.Drawing.Size(101, 17);
            this.chkRemuAfpa.TabIndex = 6;
            this.chkRemuAfpa.Text = "Rému par l\'Afpa";
            this.chkRemuAfpa.UseVisualStyleBackColor = true;
            // 
            // grpTypeCIF
            // 
            this.grpTypeCIF.Controls.Add(this.txtFongecif);
            this.grpTypeCIF.Controls.Add(this.lblFongecif);
            this.grpTypeCIF.Controls.Add(this.rbtTT);
            this.grpTypeCIF.Controls.Add(this.rbtCDD);
            this.grpTypeCIF.Controls.Add(this.rbtCDI);
            this.grpTypeCIF.Enabled = false;
            this.grpTypeCIF.Location = new System.Drawing.Point(189, 34);
            this.grpTypeCIF.Name = "grpTypeCIF";
            this.grpTypeCIF.Size = new System.Drawing.Size(195, 65);
            this.grpTypeCIF.TabIndex = 5;
            this.grpTypeCIF.TabStop = false;
            // 
            // txtFongecif
            // 
            this.txtFongecif.Location = new System.Drawing.Point(89, 16);
            this.txtFongecif.Name = "txtFongecif";
            this.txtFongecif.Size = new System.Drawing.Size(100, 20);
            this.txtFongecif.TabIndex = 6;
            // 
            // lblFongecif
            // 
            this.lblFongecif.AutoSize = true;
            this.lblFongecif.Location = new System.Drawing.Point(9, 19);
            this.lblFongecif.Name = "lblFongecif";
            this.lblFongecif.Size = new System.Drawing.Size(74, 13);
            this.lblFongecif.TabIndex = 5;
            this.lblFongecif.Text = "Fond gestion :";
            // 
            // rbtTT
            // 
            this.rbtTT.AutoSize = true;
            this.rbtTT.Location = new System.Drawing.Point(133, 42);
            this.rbtTT.Name = "rbtTT";
            this.rbtTT.Size = new System.Drawing.Size(39, 17);
            this.rbtTT.TabIndex = 2;
            this.rbtTT.Text = "TT";
            this.rbtTT.UseVisualStyleBackColor = true;
            // 
            // rbtCDD
            // 
            this.rbtCDD.AutoSize = true;
            this.rbtCDD.Location = new System.Drawing.Point(63, 42);
            this.rbtCDD.Name = "rbtCDD";
            this.rbtCDD.Size = new System.Drawing.Size(48, 17);
            this.rbtCDD.TabIndex = 1;
            this.rbtCDD.Text = "CDD";
            this.rbtCDD.UseVisualStyleBackColor = true;
            // 
            // rbtCDI
            // 
            this.rbtCDI.AutoSize = true;
            this.rbtCDI.Checked = true;
            this.rbtCDI.Location = new System.Drawing.Point(6, 42);
            this.rbtCDI.Name = "rbtCDI";
            this.rbtCDI.Size = new System.Drawing.Size(43, 17);
            this.rbtCDI.TabIndex = 0;
            this.rbtCDI.TabStop = true;
            this.rbtCDI.Text = "CDI";
            this.rbtCDI.UseVisualStyleBackColor = true;
            // 
            // rbtDE
            // 
            this.rbtDE.AutoSize = true;
            this.rbtDE.Checked = true;
            this.rbtDE.Location = new System.Drawing.Point(34, 19);
            this.rbtDE.Name = "rbtDE";
            this.rbtDE.Size = new System.Drawing.Size(122, 17);
            this.rbtDE.TabIndex = 1;
            this.rbtDE.TabStop = true;
            this.rbtDE.Text = "Demandeur d\'Emploi";
            this.rbtDE.UseVisualStyleBackColor = true;
            this.rbtDE.CheckedChanged += new System.EventHandler(this.rbtDE_CheckedChanged);
            // 
            // rbtCIF
            // 
            this.rbtCIF.AutoSize = true;
            this.rbtCIF.Location = new System.Drawing.Point(189, 19);
            this.rbtCIF.Name = "rbtCIF";
            this.rbtCIF.Size = new System.Drawing.Size(41, 17);
            this.rbtCIF.TabIndex = 0;
            this.rbtCIF.Text = "CIF";
            this.rbtCIF.UseVisualStyleBackColor = true;
            this.rbtCIF.CheckedChanged += new System.EventHandler(this.rbtCIF_CheckedChanged);
            // 
            // frmAjoutStagiaire
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnAnnuler;
            this.ClientSize = new System.Drawing.Size(453, 446);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Name = "frmAjoutStagiaire";
            this.Text = "Ajouter un Stagiaire";
            this.Controls.SetChildIndex(this.grpStagiaire, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.grpStagiaire.ResumeLayout(false);
            this.grpStagiaire.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTypeCIF.ResumeLayout(false);
            this.grpTypeCIF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtDE;
        private System.Windows.Forms.RadioButton rbtCIF;
        private System.Windows.Forms.GroupBox grpTypeCIF;
        private System.Windows.Forms.RadioButton rbtTT;
        private System.Windows.Forms.RadioButton rbtCDD;
        private System.Windows.Forms.RadioButton rbtCDI;
        private System.Windows.Forms.TextBox txtFongecif;
        private System.Windows.Forms.Label lblFongecif;
        private System.Windows.Forms.CheckBox chkRemuAfpa;
        internal System.Windows.Forms.Button btnOK;
    }
}
