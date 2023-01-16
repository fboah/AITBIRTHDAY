namespace AITBirthday.UI.EntiteAITEK
{
    partial class FenEntiteAITEK
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
            this.gCEntiteAITEK = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colmId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmLibelleEntiteAITEK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmIdPays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmLibellePays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmIsDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmUserCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmUserLastModification = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmDateCreation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmDateLastModification = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCEntiteAITEK)).BeginInit();
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
            this.layoutControl1.Controls.Add(this.gCEntiteAITEK);
            this.layoutControl1.Location = new System.Drawing.Point(-10, -10);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(604, 371);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sBtnAjouter
            // 
            this.sBtnAjouter.Location = new System.Drawing.Point(12, 337);
            this.sBtnAjouter.Name = "sBtnAjouter";
            this.sBtnAjouter.Size = new System.Drawing.Size(190, 22);
            this.sBtnAjouter.StyleController = this.layoutControl1;
            this.sBtnAjouter.TabIndex = 7;
            this.sBtnAjouter.Text = "Ajouter";
            this.sBtnAjouter.Click += new System.EventHandler(this.sBtnAjouter_Click);
            // 
            // sBtnModifier
            // 
            this.sBtnModifier.Location = new System.Drawing.Point(206, 337);
            this.sBtnModifier.Name = "sBtnModifier";
            this.sBtnModifier.Size = new System.Drawing.Size(198, 22);
            this.sBtnModifier.StyleController = this.layoutControl1;
            this.sBtnModifier.TabIndex = 6;
            this.sBtnModifier.Text = "Modifier";
            this.sBtnModifier.Click += new System.EventHandler(this.sBtnModifier_Click);
            // 
            // sBtnSupprimer
            // 
            this.sBtnSupprimer.Location = new System.Drawing.Point(408, 337);
            this.sBtnSupprimer.Name = "sBtnSupprimer";
            this.sBtnSupprimer.Size = new System.Drawing.Size(184, 22);
            this.sBtnSupprimer.StyleController = this.layoutControl1;
            this.sBtnSupprimer.TabIndex = 5;
            this.sBtnSupprimer.Text = "Supprimer";
            this.sBtnSupprimer.Click += new System.EventHandler(this.sBtnSupprimer_Click);
            // 
            // gCEntiteAITEK
            // 
            this.gCEntiteAITEK.Location = new System.Drawing.Point(12, 12);
            this.gCEntiteAITEK.MainView = this.gridView1;
            this.gCEntiteAITEK.Name = "gCEntiteAITEK";
            this.gCEntiteAITEK.Size = new System.Drawing.Size(580, 321);
            this.gCEntiteAITEK.TabIndex = 4;
            this.gCEntiteAITEK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmId,
            this.colmLibelleEntiteAITEK,
            this.colmIdPays,
            this.colmLibellePays,
            this.colmIsDelete,
            this.colmUserCreation,
            this.colmUserLastModification,
            this.colmDateCreation,
            this.colmDateLastModification});
            this.gridView1.GridControl = this.gCEntiteAITEK;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(604, 371);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gCEntiteAITEK;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(584, 325);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.sBtnSupprimer;
            this.layoutControlItem2.Location = new System.Drawing.Point(396, 325);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sBtnModifier;
            this.layoutControlItem3.Location = new System.Drawing.Point(194, 325);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(202, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sBtnAjouter;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 325);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(194, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // colmId
            // 
            this.colmId.Caption = "Id";
            this.colmId.FieldName = "mId";
            this.colmId.Name = "colmId";
            // 
            // colmLibelleEntiteAITEK
            // 
            this.colmLibelleEntiteAITEK.Caption = "Libelle Entite AITEK";
            this.colmLibelleEntiteAITEK.FieldName = "mLibelleEntiteAITEK";
            this.colmLibelleEntiteAITEK.Name = "colmLibelleEntiteAITEK";
            this.colmLibelleEntiteAITEK.Visible = true;
            this.colmLibelleEntiteAITEK.VisibleIndex = 0;
            // 
            // colmIdPays
            // 
            this.colmIdPays.Caption = "IdPays";
            this.colmIdPays.FieldName = "mIdPays";
            this.colmIdPays.Name = "colmIdPays";
            // 
            // colmLibellePays
            // 
            this.colmLibellePays.Caption = "Pays";
            this.colmLibellePays.FieldName = "mLibellePays";
            this.colmLibellePays.Name = "colmLibellePays";
            this.colmLibellePays.Visible = true;
            this.colmLibellePays.VisibleIndex = 1;
            // 
            // colmIsDelete
            // 
            this.colmIsDelete.Caption = "IsDelete";
            this.colmIsDelete.FieldName = "mIsDelete";
            this.colmIsDelete.Name = "colmIsDelete";
            // 
            // colmUserCreation
            // 
            this.colmUserCreation.Caption = "UserCreation";
            this.colmUserCreation.FieldName = "mUserCreation";
            this.colmUserCreation.Name = "colmUserCreation";
            // 
            // colmUserLastModification
            // 
            this.colmUserLastModification.Caption = "UserLastModification";
            this.colmUserLastModification.FieldName = "mUserLastModification";
            this.colmUserLastModification.Name = "colmUserLastModification";
            // 
            // colmDateCreation
            // 
            this.colmDateCreation.Caption = "DateCreation";
            this.colmDateCreation.FieldName = "mDateCreation";
            this.colmDateCreation.Name = "colmDateCreation";
            // 
            // colmDateLastModification
            // 
            this.colmDateLastModification.Caption = "DateLastModification";
            this.colmDateLastModification.FieldName = "mDateLastModification";
            this.colmDateLastModification.Name = "colmDateLastModification";
            // 
            // FenEntiteAITEK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 353);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FenEntiteAITEK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FenEntiteAITEK";
            this.Load += new System.EventHandler(this.FenEntiteAITEK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCEntiteAITEK)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gCEntiteAITEK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colmId;
        private DevExpress.XtraGrid.Columns.GridColumn colmLibelleEntiteAITEK;
        private DevExpress.XtraGrid.Columns.GridColumn colmIdPays;
        private DevExpress.XtraGrid.Columns.GridColumn colmLibellePays;
        private DevExpress.XtraGrid.Columns.GridColumn colmIsDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colmUserCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colmUserLastModification;
        private DevExpress.XtraGrid.Columns.GridColumn colmDateCreation;
        private DevExpress.XtraGrid.Columns.GridColumn colmDateLastModification;
    }
}