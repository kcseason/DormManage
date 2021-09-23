namespace DormManage
{
    partial class FRM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            this.Btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.TB_userName = new DevExpress.XtraEditors.TextEdit();
            this.TB_password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TB_userName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_login
            // 
            this.Btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_login.Location = new System.Drawing.Point(206, 179);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(75, 23);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.Text = "登录";
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_cancel.Location = new System.Drawing.Point(287, 179);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancel.TabIndex = 1;
            this.Btn_cancel.Text = "取消";
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // TB_userName
            // 
            this.TB_userName.Location = new System.Drawing.Point(242, 103);
            this.TB_userName.Name = "TB_userName";
            this.TB_userName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TB_userName.Properties.Appearance.Options.UseFont = true;
            this.TB_userName.Size = new System.Drawing.Size(120, 26);
            this.TB_userName.TabIndex = 2;
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(242, 135);
            this.TB_password.Name = "TB_password";
            this.TB_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TB_password.Properties.Appearance.Options.UseFont = true;
            this.TB_password.Properties.UseSystemPasswordChar = true;
            this.TB_password.Size = new System.Drawing.Size(120, 26);
            this.TB_password.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(179, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "用户名:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(179, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "密   码:";
            // 
            // FRM_Login
            // 
            this.AcceptButton = this.Btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.CancelButton = this.Btn_cancel;
            this.ClientSize = new System.Drawing.Size(386, 237);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_userName);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.Shown += new System.EventHandler(this.FRM_Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TB_userName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Btn_login;
        private DevExpress.XtraEditors.SimpleButton Btn_cancel;
        private DevExpress.XtraEditors.TextEdit TB_userName;
        private DevExpress.XtraEditors.TextEdit TB_password;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}