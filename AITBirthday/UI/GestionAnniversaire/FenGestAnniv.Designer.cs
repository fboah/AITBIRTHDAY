namespace AITBirthday.UI.GestionAnniversaire
{
    partial class FenGestAnniv
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sBtnAjouter = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnSupprimer = new DevExpress.XtraEditors.SimpleButton();
            this.gCAnniversaire = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colmId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmPrenoms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmIdPoste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmDateAnniversaire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmLibellePoste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmIdDirection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmLibelleDirection = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmIdEntiteAITEK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmLibelleEntiteAITEK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmDateNaissance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmIsDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmUserCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmUserLastModification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmDateCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmDateLastModification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCAnniversaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sBtnAjouter);
            this.layoutControl1.Controls.Add(this.sBtnModifier);
            this.layoutControl1.Controls.Add(this.sBtnSupprimer);
            this.layoutControl1.Controls.Add(this.gCAnniversaire);
            this.layoutControl1.Location = new System.Drawing.Point(-9, -9);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(932, 442);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sBtnAjouter
            // 
            this.sBtnAjouter.Location = new System.Drawing.Point(12, 408);
            this.sBtnAjouter.Name = "sBtnAjouter";
            this.sBtnAjouter.Size = new System.Drawing.Size(287, 22);
            this.sBtnAjouter.StyleController = this.layoutControl1;
            this.sBtnAjouter.TabIndex = 7;
            this.sBtnAjouter.Text = "Ajouter";
            this.sBtnAjouter.Click += new System.EventHandler(this.sBtnAjouter_Click);
            // 
            // sBtnModifier
            // 
            this.sBtnModifier.Location = new System.Drawing.Point(303, 408);
            this.sBtnModifier.Name = "sBtnModifier";
            this.sBtnModifier.Size = new System.Drawing.Size(321, 22);
            this.sBtnModifier.StyleController = this.layoutControl1;
            this.sBtnModifier.TabIndex = 6;
            this.sBtnModifier.Text = "Modifier";
            // 
            // sBtnSupprimer
            // 
            this.sBtnSupprimer.Location = new System.Drawing.Point(628, 408);
            this.sBtnSupprimer.Name = "sBtnSupprimer";
            this.sBtnSupprimer.Size = new System.Drawing.Size(292, 22);
            this.sBtnSupprimer.StyleController = this.layoutControl1;
            this.sBtnSupprimer.TabIndex = 5;
            this.sBtnSupprimer.Text = "Supprimer";
            // 
            // gCAnniversaire
            // 
            this.gCAnniversaire.Location = new System.Drawing.Point(12, 12);
            this.gCAnniversaire.MainView = this.gridView1;
            this.gCAnniversaire.Name = "gCAnniversaire";
            this.gCAnniversaire.Size = new System.Drawing.Size(908, 392);
            this.gCAnniversaire.TabIndex = 4;
            this.gCAnniversaire.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmId,
            this.colmNom,
            this.colmPrenoms,
            this.colmIdPoste,
            this.colmDateAnniversaire,
            this.colmLibellePoste,
            this.colmIdDirection,
            this.colmLibelleDirection,
            this.colmIdEntiteAITEK,
            this.colmLibelleEntiteAITEK,
            this.colmDateNaissance,
            this.gridColumn1,
            this.colmIsDelete,
            this.colmUserCreation,
            this.colmUserLastModification,
            this.colmDateCreation,
            this.colmDateLastModification,
            this.colmEmail});
            this.gridView1.GridControl = this.gCAnniversaire;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(932, 442);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gCAnniversaire;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(912, 396);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sBtnSupprimer;
            this.layoutControlItem2.Location = new System.Drawing.Point(616, 396);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(296, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sBtnModifier;
            this.layoutControlItem3.Location = new System.Drawing.Point(291, 396);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(325, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sBtnAjouter;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 396);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(291, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // colmId
            // 
            this.colmId.Caption = "Id";
            this.colmId.FieldName = "mId";
            this.colmId.Name = "colmId";
            // 
            // colmNom
            // 
            this.colmNom.Caption = "Nom";
            this.colmNom.FieldName = "mNom";
            this.colmNom.Name = "colmNom";
            this.colmNom.Visible = true;
            this.colmNom.VisibleIndex = 0;
            // 
            // colmPrenoms
            // 
            this.colmPrenoms.Caption = "Prenoms";
            this.colmPrenoms.FieldName = "mPrenoms";
            this.colmPrenoms.Name = "colmPrenoms";
            this.colmPrenoms.Visible = true;
            this.colmPrenoms.VisibleIndex = 1;
            // 
            // colmIdPoste
            // 
            this.colmIdPoste.Caption = "IdPoste";
            this.colmIdPoste.FieldName = "mIdPoste";
            this.colmIdPoste.Name = "colmIdPoste";
            // 
            // colmDateAnniversaire
            // 
            this.colmDateAnniversaire.Caption = "Date Anniversaire";
            this.colmDateAnniversaire.FieldName = "mDateAnniversaire";
            this.colmDateAnniversaire.Name = "colmDateAnniversaire";
            this.colmDateAnniversaire.Visible = true;
            this.colmDateAnniversaire.VisibleIndex = 2;
            // 
            // colmLibellePoste
            // 
            this.colmLibellePoste.Caption = "Libelle Poste";
            this.colmLibellePoste.FieldName = "mLibellePoste";
            this.colmLibellePoste.Name = "colmLibellePoste";
            this.colmLibellePoste.Visible = true;
            this.colmLibellePoste.VisibleIndex = 3;
            // 
            // colmIdDirection
            // 
            this.colmIdDirection.Caption = "IdDirection";
            this.colmIdDirection.FieldName = "mIdDirection";
            this.colmIdDirection.Name = "colmIdDirection";
            // 
            // colmLibelleDirection
            // 
            this.colmLibelleDirection.Caption = "Libelle Direction";
            this.colmLibelleDirection.FieldName = "mLibelleDirection";
            this.colmLibelleDirection.Name = "colmLibelleDirection";
            this.colmLibelleDirection.Visible = true;
            this.colmLibelleDirection.VisibleIndex = 4;
            // 
            // colmIdEntiteAITEK
            // 
            this.colmIdEntiteAITEK.Caption = "IdEntiteAITEK";
            this.colmIdEntiteAITEK.FieldName = "mIdEntiteAITEK";
            this.colmIdEntiteAITEK.Name = "colmIdEntiteAITEK";
            // 
            // colmLibelleEntiteAITEK
            // 
            this.colmLibelleEntiteAITEK.Caption = "Libelle Entite AITEK";
            this.colmLibelleEntiteAITEK.FieldName = "mLibelleEntiteAITEK";
            this.colmLibelleEntiteAITEK.Name = "colmLibelleEntiteAITEK";
            this.colmLibelleEntiteAITEK.Visible = true;
            this.colmLibelleEntiteAITEK.VisibleIndex = 5;
            // 
            // colmDateNaissance
            // 
            this.colmDateNaissance.Caption = "DateNaissance";
            this.colmDateNaissance.FieldName = "mDateNaissance";
            this.colmDateNaissance.Name = "colmDateNaissance";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "DateNaissance";
            this.gridColumn1.FieldName = "mDateNaissance";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colmIsDelete
            // 
            this.colmIsDelete.Caption = "mIsDelete";
            this.colmIsDelete.FieldName = "mIsDelete";
            this.colmIsDelete.Name = "colmIsDelete";
            // 
            // colmUserCreation
            // 
            this.colmUserCreation.Caption = "mUserCreation";
            this.colmUserCreation.FieldName = "mUserCreation";
            this.colmUserCreation.Name = "colmUserCreation";
            // 
            // colmUserLastModification
            // 
            this.colmUserLastModification.Caption = "mUserLastModification";
            this.colmUserLastModification.FieldName = "mUserLastModification";
            this.colmUserLastModification.Name = "colmUserLastModification";
            // 
            // colmDateCreation
            // 
            this.colmDateCreation.Caption = "mDateCreation";
            this.colmDateCreation.FieldName = "mDateCreation";
            this.colmDateCreation.Name = "colmDateCreation";
            // 
            // colmDateLastModification
            // 
            this.colmDateLastModification.Caption = "mDateLastModification";
            this.colmDateLastModification.FieldName = "mDateLastModification";
            this.colmDateLastModification.Name = "colmDateLastModification";
            // 
            // colmEmail
            // 
            this.colmEmail.Caption = "Email";
            this.colmEmail.FieldName = "mEmail";
            this.colmEmail.Name = "colmEmail";
            this.colmEmail.Visible = true;
            this.colmEmail.VisibleIndex = 6;
            // 
            // FenGestAnniv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 424);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FenGestAnniv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FenGestAnniv";
            this.Load += new System.EventHandler(this.FenGestAnniv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCAnniversaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sBtnAjouter;
        private DevExpress.XtraEditors.SimpleButton sBtnModifier;
        private DevExpress.XtraEditors.SimpleButton sBtnSupprimer;
        private DevExpress.XtraGrid.GridControl gCAnniversaire;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colmId;
        private DevExpress.XtraGrid.Columns.GridColumn colmNom;
        private DevExpress.XtraGrid.Columns.GridColumn colmPrenoms;
        private DevExpress.XtraGrid.Columns.GridColumn colmIdPoste;
        private DevExpress.XtraGrid.Columns.GridColumn colmDateAnniversaire;
        private DevExpress.XtraGrid.Columns.GridColumn colmLibellePoste;
        private DevExpress.XtraGrid.Columns.GridColumn colmIdDirection;
        private DevExpress.XtraGrid.Columns.GridColumn colmLibelleDirection;
        private DevExpress.XtraGrid.Columns.GridColumn colmIdEntiteAITEK;
        private DevExpress.XtraGrid.Columns.GridColumn colmLibelleEntiteAITEK;
        private DevExpress.XtraGrid.Columns.GridColumn colmDateNaissance;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colmIsDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colmUserCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colmUserLastModification;
        private DevExpress.XtraGrid.Columns.GridColumn colmDateCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colmDateLastModification;
        private DevExpress.XtraGrid.Columns.GridColumn colmEmail;
    }
}