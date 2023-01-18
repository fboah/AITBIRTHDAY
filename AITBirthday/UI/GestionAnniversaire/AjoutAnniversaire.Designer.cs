namespace AITBirthday.UI.GestionAnniversaire
{
    partial class AjoutAnniversaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutAnniversaire));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.sBtnFermer = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnEnregistrer = new DevExpress.XtraEditors.SimpleButton();
            this.dateNaissance = new DevExpress.XtraEditors.DateEdit();
            this.CmbEntiteAITEK = new DevExpress.XtraEditors.LookUpEdit();
            this.CmbDirection = new DevExpress.XtraEditors.LookUpEdit();
            this.CmbPoste = new DevExpress.XtraEditors.LookUpEdit();
            this.txtPrenom = new DevExpress.XtraEditors.TextEdit();
            this.txtNom = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNaissance.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNaissance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbEntiteAITEK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDirection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPoste.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrenom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtEmail);
            this.layoutControl1.Controls.Add(this.sBtnFermer);
            this.layoutControl1.Controls.Add(this.sBtnEnregistrer);
            this.layoutControl1.Controls.Add(this.dateNaissance);
            this.layoutControl1.Controls.Add(this.CmbEntiteAITEK);
            this.layoutControl1.Controls.Add(this.CmbDirection);
            this.layoutControl1.Controls.Add(this.CmbPoste);
            this.layoutControl1.Controls.Add(this.txtPrenom);
            this.layoutControl1.Controls.Add(this.txtNom);
            this.layoutControl1.Location = new System.Drawing.Point(-8, -12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(502, 214);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(394, 20);
            this.txtEmail.StyleController = this.layoutControl1;
            this.txtEmail.TabIndex = 12;
            // 
            // sBtnFermer
            // 
            this.sBtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("sBtnFermer.Image")));
            this.sBtnFermer.Location = new System.Drawing.Point(252, 180);
            this.sBtnFermer.Name = "sBtnFermer";
            this.sBtnFermer.Size = new System.Drawing.Size(238, 22);
            this.sBtnFermer.StyleController = this.layoutControl1;
            this.sBtnFermer.TabIndex = 11;
            this.sBtnFermer.Text = "Fermer";
            this.sBtnFermer.Click += new System.EventHandler(this.sBtnFermer_Click);
            // 
            // sBtnEnregistrer
            // 
            this.sBtnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("sBtnEnregistrer.Image")));
            this.sBtnEnregistrer.Location = new System.Drawing.Point(12, 180);
            this.sBtnEnregistrer.Name = "sBtnEnregistrer";
            this.sBtnEnregistrer.Size = new System.Drawing.Size(236, 22);
            this.sBtnEnregistrer.StyleController = this.layoutControl1;
            this.sBtnEnregistrer.TabIndex = 10;
            this.sBtnEnregistrer.Text = "Enregistrer";
            this.sBtnEnregistrer.Click += new System.EventHandler(this.sBtnEnregistrer_Click);
            // 
            // dateNaissance
            // 
            this.dateNaissance.EditValue = null;
            this.dateNaissance.Location = new System.Drawing.Point(96, 132);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNaissance.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNaissance.Size = new System.Drawing.Size(394, 20);
            this.dateNaissance.StyleController = this.layoutControl1;
            this.dateNaissance.TabIndex = 9;
            // 
            // CmbEntiteAITEK
            // 
            this.CmbEntiteAITEK.Location = new System.Drawing.Point(96, 108);
            this.CmbEntiteAITEK.Name = "CmbEntiteAITEK";
            this.CmbEntiteAITEK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbEntiteAITEK.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mLibelleEntiteAITEK", "Libelle")});
            this.CmbEntiteAITEK.Size = new System.Drawing.Size(394, 20);
            this.CmbEntiteAITEK.StyleController = this.layoutControl1;
            this.CmbEntiteAITEK.TabIndex = 8;
            // 
            // CmbDirection
            // 
            this.CmbDirection.Location = new System.Drawing.Point(96, 84);
            this.CmbDirection.Name = "CmbDirection";
            this.CmbDirection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbDirection.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mIntituleDirection", "Libelle")});
            this.CmbDirection.Size = new System.Drawing.Size(394, 20);
            this.CmbDirection.StyleController = this.layoutControl1;
            this.CmbDirection.TabIndex = 7;
            // 
            // CmbPoste
            // 
            this.CmbPoste.Location = new System.Drawing.Point(96, 60);
            this.CmbPoste.Name = "CmbPoste";
            this.CmbPoste.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbPoste.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mId", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("mIntitulePoste", "Libelle")});
            this.CmbPoste.Size = new System.Drawing.Size(394, 20);
            this.CmbPoste.StyleController = this.layoutControl1;
            this.CmbPoste.TabIndex = 6;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(96, 36);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(394, 20);
            this.txtPrenom.StyleController = this.layoutControl1;
            this.txtPrenom.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(96, 12);
            this.txtNom.Name = "txtNom";
            this.txtNom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Size = new System.Drawing.Size(394, 20);
            this.txtNom.StyleController = this.layoutControl1;
            this.txtNom.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(502, 214);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtNom;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(482, 24);
            this.layoutControlItem1.Text = "Nom";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPrenom;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(482, 24);
            this.layoutControlItem2.Text = "Prénoms";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CmbPoste;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(482, 24);
            this.layoutControlItem3.Text = "Poste";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.CmbDirection;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(482, 24);
            this.layoutControlItem4.Text = "Direction/Service";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CmbEntiteAITEK;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(482, 24);
            this.layoutControlItem5.Text = "Entité AITEK";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.dateNaissance;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(482, 24);
            this.layoutControlItem6.Text = "Date Naissance";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.sBtnEnregistrer;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(240, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.sBtnFermer;
            this.layoutControlItem8.Location = new System.Drawing.Point(240, 168);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(242, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtEmail;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(482, 24);
            this.layoutControlItem9.Text = "Email";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(81, 13);
            // 
            // AjoutAnniversaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 193);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AjoutAnniversaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un Anniversaire";
            this.Load += new System.EventHandler(this.AjoutAnniversaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNaissance.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNaissance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbEntiteAITEK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbDirection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbPoste.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrenom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtPrenom;
        private DevExpress.XtraEditors.TextEdit txtNom;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LookUpEdit CmbPoste;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit CmbEntiteAITEK;
        private DevExpress.XtraEditors.LookUpEdit CmbDirection;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton sBtnFermer;
        private DevExpress.XtraEditors.SimpleButton sBtnEnregistrer;
        private DevExpress.XtraEditors.DateEdit dateNaissance;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}