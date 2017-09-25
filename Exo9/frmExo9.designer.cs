namespace Exo9
{
    partial class frmExo9
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
            this.grdStagiaires = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblErreur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdStagiaires)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStagiaires
            // 
            this.grdStagiaires.AllowUserToAddRows = false;
            this.grdStagiaires.AllowUserToDeleteRows = false;
            this.grdStagiaires.AllowUserToOrderColumns = true;
            this.grdStagiaires.AllowUserToResizeColumns = false;
            this.grdStagiaires.AllowUserToResizeRows = false;
            this.grdStagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStagiaires.Location = new System.Drawing.Point(12, 40);
            this.grdStagiaires.Name = "grdStagiaires";
            this.grdStagiaires.Size = new System.Drawing.Size(725, 243);
            this.grdStagiaires.TabIndex = 0;
            this.grdStagiaires.SelectionChanged += new System.EventHandler(this.grdStagiaires_SelectionChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(581, 329);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFermer.Location = new System.Drawing.Point(662, 329);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(500, 329);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lblErreur
            // 
            this.lblErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(12, 294);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(482, 58);
            this.lblErreur.TabIndex = 4;
            this.lblErreur.Text = " ";
            // 
            // frmExo9
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFermer;
            this.ClientSize = new System.Drawing.Size(749, 364);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.grdStagiaires);
            this.Name = "frmExo9";
            this.Text = "Visulisation des Stagiaires de la section ";
            ((System.ComponentModel.ISupportInitialize)(this.grdStagiaires)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        internal System.Windows.Forms.DataGridView grdStagiaires;
        internal System.Windows.Forms.Button btnAjouter;
        internal System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblErreur;
    }
}

