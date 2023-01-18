namespace AITBirthday
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.créationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entitéAITEKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAnniversairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créationToolStripMenuItem,
            this.gestionAnniversairesToolStripMenuItem,
            this.paramètresEmailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // créationToolStripMenuItem
            // 
            this.créationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posteToolStripMenuItem,
            this.directionToolStripMenuItem,
            this.entitéAITEKToolStripMenuItem});
            this.créationToolStripMenuItem.Name = "créationToolStripMenuItem";
            this.créationToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.créationToolStripMenuItem.Text = "Création";
            // 
            // posteToolStripMenuItem
            // 
            this.posteToolStripMenuItem.Name = "posteToolStripMenuItem";
            this.posteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.posteToolStripMenuItem.Text = "Poste";
            this.posteToolStripMenuItem.Click += new System.EventHandler(this.posteToolStripMenuItem_Click);
            // 
            // directionToolStripMenuItem
            // 
            this.directionToolStripMenuItem.Name = "directionToolStripMenuItem";
            this.directionToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.directionToolStripMenuItem.Text = "Direction";
            this.directionToolStripMenuItem.Click += new System.EventHandler(this.directionToolStripMenuItem_Click);
            // 
            // entitéAITEKToolStripMenuItem
            // 
            this.entitéAITEKToolStripMenuItem.Name = "entitéAITEKToolStripMenuItem";
            this.entitéAITEKToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.entitéAITEKToolStripMenuItem.Text = "Entité AITEK";
            this.entitéAITEKToolStripMenuItem.Click += new System.EventHandler(this.entitéAITEKToolStripMenuItem_Click);
            // 
            // gestionAnniversairesToolStripMenuItem
            // 
            this.gestionAnniversairesToolStripMenuItem.Name = "gestionAnniversairesToolStripMenuItem";
            this.gestionAnniversairesToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.gestionAnniversairesToolStripMenuItem.Text = "Gestion Anniversaires";
            this.gestionAnniversairesToolStripMenuItem.Click += new System.EventHandler(this.gestionAnniversairesToolStripMenuItem_Click);
            // 
            // paramètresEmailToolStripMenuItem
            // 
            this.paramètresEmailToolStripMenuItem.Name = "paramètresEmailToolStripMenuItem";
            this.paramètresEmailToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.paramètresEmailToolStripMenuItem.Text = "Paramètres Email";
            this.paramètresEmailToolStripMenuItem.Click += new System.EventHandler(this.paramètresEmailToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 359);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Anniversaires AITEK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem créationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entitéAITEKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionAnniversairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresEmailToolStripMenuItem;
    }
}

