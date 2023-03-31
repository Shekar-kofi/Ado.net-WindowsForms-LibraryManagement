using System.ComponentModel;

namespace CRUD
{
    partial class ChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.tbForgotMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassLogin = new System.Windows.Forms.TextBox();
            this.tbChangePassword = new System.Windows.Forms.Button();
            this.linkForgot = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email Address:";
            // 
            // tbForgotMail
            // 
            this.tbForgotMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbForgotMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForgotMail.Location = new System.Drawing.Point(264, 92);
            this.tbForgotMail.Name = "tbForgotMail";
            this.tbForgotMail.Size = new System.Drawing.Size(370, 36);
            this.tbForgotMail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "New Password:";
            // 
            // tbPassLogin
            // 
            this.tbPassLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassLogin.Location = new System.Drawing.Point(264, 178);
            this.tbPassLogin.Name = "tbPassLogin";
            this.tbPassLogin.Size = new System.Drawing.Size(370, 36);
            this.tbPassLogin.TabIndex = 9;
            this.tbPassLogin.UseSystemPasswordChar = true;
            this.tbPassLogin.TextChanged += new System.EventHandler(this.tbPassLogin_TextChanged);
            // 
            // tbChangePassword
            // 
            this.tbChangePassword.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChangePassword.Location = new System.Drawing.Point(264, 316);
            this.tbChangePassword.Name = "tbChangePassword";
            this.tbChangePassword.Size = new System.Drawing.Size(240, 39);
            this.tbChangePassword.TabIndex = 10;
            this.tbChangePassword.Text = "Change Password";
            this.tbChangePassword.UseVisualStyleBackColor = false;
            this.tbChangePassword.Click += new System.EventHandler(this.tbChangePassword_Click);
            // 
            // linkForgot
            // 
            this.linkForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgot.LinkColor = System.Drawing.Color.Green;
            this.linkForgot.Location = new System.Drawing.Point(264, 379);
            this.linkForgot.Name = "linkForgot";
            this.linkForgot.Size = new System.Drawing.Size(240, 42);
            this.linkForgot.TabIndex = 14;
            this.linkForgot.TabStop = true;
            this.linkForgot.Text = "back to Login";
            this.linkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgot_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // lbPass
            // 
            this.lbPass.Location = new System.Drawing.Point(264, 220);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(496, 52);
            this.lbPass.TabIndex = 15;
            this.lbPass.Text = "Password Should contain at least one digit .At least one upper case.At least one " + "lower case.At least one of the special characters[@,!,$,-,&,_]\r\n";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.linkForgot);
            this.Controls.Add(this.tbChangePassword);
            this.Controls.Add(this.tbPassLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbForgotMail);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbPass;

        private System.Windows.Forms.ErrorProvider errorProvider2;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.LinkLabel linkForgot;

        private System.Windows.Forms.Button tbChangePassword;

        private System.Windows.Forms.TextBox tbPassLogin;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox tbForgotMail;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}