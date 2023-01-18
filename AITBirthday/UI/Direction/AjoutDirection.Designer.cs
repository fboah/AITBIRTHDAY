namespace AITBirthday.UI.Direction
{
    partial class AjoutDirection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutDirection));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sBtnEnregistrer = new DevExpress.XtraEditors.SimpleButton();
            this.sBtnFermer = new DevExpress.XtraEditors.SimpleButton();
            this.rTBDescription = new System.Windows.Forms.RichTextBox();
            this.txtIntituleDirection = new DevExpress.XtraEditors.TextEdit();
            this.txtCodeDirection = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntituleDirection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeDirection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sBtnEnregistrer);
            this.layoutControl1.Controls.Add(this.sBtnFermer);
            this.layoutControl1.Controls.Add(this.rTBDescription);
            this.layoutControl1.Controls.Add(this.txtIntituleDirection);
            this.layoutControl1.Controls.Add(this.txtCodeDirection);
            this.layoutControl1.Location = new System.Drawing.Point(-9, -8);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(483, 290);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sBtnEnregistrer
            // 
            this.sBtnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("sBtnEnregistrer.Image")));
            this.sBtnEnregistrer.Location = new System.Drawing.Point(12, 256);
            this.sBtnEnregistrer.Name = "sBtnEnregistrer";
            this.sBtnEnregistrer.Size = new System.Drawing.Size(227, 22);
            this.sBtnEnregistrer.StyleController = this.layoutControl1;
            this.sBtnEnregistrer.TabIndex = 8;
            this.sBtnEnregistrer.Text = "Enregistrer";
            this.sBtnEnregistrer.Click += new System.EventHandler(this.sBtnEnregistrer_Click);
            // 
            // sBtnFermer
            // 
            this.sBtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("sBtnFermer.Image")));
            this.sBtnFermer.Location = new System.Drawing.Point(243, 256);
            this.sBtnFermer.Name = "sBtnFermer";
            this.sBtnFermer.Size = new System.Drawing.Size(228, 22);
            this.sBtnFermer.StyleController = this.layoutControl1;
            this.sBtnFermer.TabIndex = 7;
            this.sBtnFermer.Text = "Fermer";
            this.sBtnFermer.Click += new System.EventHandler(this.sBtnFermer_Click);
            // 
            // rTBDescription
            // 
            this.rTBDescription.Location = new System.Drawing.Point(94, 60);
            this.rTBDescription.Name = "rTBDescription";
            this.rTBDescription.Size = new System.Drawing.Size(377, 192);
            this.rTBDescription.TabIndex = 6;
            this.rTBDescription.Text = "";
            // 
            // txtIntituleDirection
            // 
            this.txtIntituleDirection.Location = new System.Drawing.Point(94, 36);
            this.txtIntituleDirection.Name = "txtIntituleDirection";
            this.txtIntituleDirection.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIntituleDirection.Size = new System.Drawing.Size(377, 20);
            this.txtIntituleDirection.StyleController = this.layoutControl1;
            this.txtIntituleDirection.TabIndex = 5;
            // 
            // txtCodeDirection
            // 
            this.txtCodeDirection.Location = new System.Drawing.Point(94, 12);
            this.txtCodeDirection.Name = "txtCodeDirection";
            this.txtCodeDirection.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodeDirection.Size = new System.Drawing.Size(377, 20);
            this.txtCodeDirection.StyleController = this.layoutControl1;
            this.txtCodeDirection.TabIndex = 4;
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
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(483, 290);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCodeDirection;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(463, 24);
            this.layoutControlItem1.Text = "Code Direction";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtIntituleDirection;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(463, 24);
            this.layoutControlItem2.Text = "Intitule Direction";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.rTBDescription;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(463, 196);
            this.layoutControlItem3.Text = "Description";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sBtnFermer;
            this.layoutControlItem4.Location = new System.Drawing.Point(231, 244);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(232, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sBtnEnregistrer;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 244);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(231, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // AjoutDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 272);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AjoutDirection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une Direction";
            this.Load += new System.EventHandler(this.AjoutDirection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIntituleDirection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeDirection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton sBtnEnregistrer;
        private DevExpress.XtraEditors.SimpleButton sBtnFermer;
        private System.Windows.Forms.RichTextBox rTBDescription;
        private DevExpress.XtraEditors.TextEdit txtIntituleDirection;
        private DevExpress.XtraEditors.TextEdit txtCodeDirection;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}