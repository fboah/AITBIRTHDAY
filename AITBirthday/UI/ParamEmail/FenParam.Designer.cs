namespace AITBirthday.UI.ParamEmail
{
    partial class FenParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenParam));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSmtp = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSmtpPassword = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sNumPort = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sBtnEnregistrer = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sBtnFermer = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSmtp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSmtpPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNumPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sBtnFermer);
            this.layoutControl1.Controls.Add(this.sBtnEnregistrer);
            this.layoutControl1.Controls.Add(this.sNumPort);
            this.layoutControl1.Controls.Add(this.txtSmtpPassword);
            this.layoutControl1.Controls.Add(this.txtSmtp);
            this.layoutControl1.Controls.Add(this.txtMail);
            this.layoutControl1.Location = new System.Drawing.Point(-10, -9);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(478, 118);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
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
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(478, 118);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(89, 12);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(377, 20);
            this.txtMail.StyleController = this.layoutControl1;
            this.txtMail.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMail;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(458, 24);
            this.layoutControlItem1.Text = "Email";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 13);
            // 
            // txtSmtp
            // 
            this.txtSmtp.Location = new System.Drawing.Point(89, 36);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(377, 20);
            this.txtSmtp.StyleController = this.layoutControl1;
            this.txtSmtp.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSmtp;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(458, 24);
            this.layoutControlItem2.Text = "Smtp";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // txtSmtpPassword
            // 
            this.txtSmtpPassword.Location = new System.Drawing.Point(89, 60);
            this.txtSmtpPassword.Name = "txtSmtpPassword";
            this.txtSmtpPassword.Properties.UseSystemPasswordChar = true;
            this.txtSmtpPassword.Size = new System.Drawing.Size(147, 20);
            this.txtSmtpPassword.StyleController = this.layoutControl1;
            this.txtSmtpPassword.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtSmtpPassword;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(228, 24);
            this.layoutControlItem3.Text = "Smtp Password";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 13);
            // 
            // sNumPort
            // 
            this.sNumPort.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sNumPort.Location = new System.Drawing.Point(317, 60);
            this.sNumPort.Name = "sNumPort";
            this.sNumPort.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sNumPort.Size = new System.Drawing.Size(149, 20);
            this.sNumPort.StyleController = this.layoutControl1;
            this.sNumPort.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.sNumPort;
            this.layoutControlItem4.Location = new System.Drawing.Point(228, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(230, 24);
            this.layoutControlItem4.Text = "Port";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // sBtnEnregistrer
            // 
            this.sBtnEnregistrer.Image = ((System.Drawing.Image)(resources.GetObject("sBtnEnregistrer.Image")));
            this.sBtnEnregistrer.Location = new System.Drawing.Point(12, 84);
            this.sBtnEnregistrer.Name = "sBtnEnregistrer";
            this.sBtnEnregistrer.Size = new System.Drawing.Size(224, 22);
            this.sBtnEnregistrer.StyleController = this.layoutControl1;
            this.sBtnEnregistrer.TabIndex = 8;
            this.sBtnEnregistrer.Text = "Enregistrer";
            this.sBtnEnregistrer.Click += new System.EventHandler(this.sBtnEnregistrer_Click);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sBtnEnregistrer;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(228, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // sBtnFermer
            // 
            this.sBtnFermer.Image = ((System.Drawing.Image)(resources.GetObject("sBtnFermer.Image")));
            this.sBtnFermer.Location = new System.Drawing.Point(240, 84);
            this.sBtnFermer.Name = "sBtnFermer";
            this.sBtnFermer.Size = new System.Drawing.Size(226, 22);
            this.sBtnFermer.StyleController = this.layoutControl1;
            this.sBtnFermer.TabIndex = 9;
            this.sBtnFermer.Text = "Fermer";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.sBtnFermer;
            this.layoutControlItem6.Location = new System.Drawing.Point(228, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(230, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // FenParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 99);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FenParam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres Email Envoi";
            this.Load += new System.EventHandler(this.FenParam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSmtp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSmtpPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sNumPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton sBtnFermer;
        private DevExpress.XtraEditors.SimpleButton sBtnEnregistrer;
        private DevExpress.XtraEditors.SpinEdit sNumPort;
        private DevExpress.XtraEditors.TextEdit txtSmtpPassword;
        private DevExpress.XtraEditors.TextEdit txtSmtp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}