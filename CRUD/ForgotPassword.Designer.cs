using System.ComponentModel;

namespace CRUD
{
    partial class ForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbForgotMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkForgot = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Address:";
            // 
            // tbForgotMail
            // 
            this.tbForgotMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbForgotMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForgotMail.Location = new System.Drawing.Point(283, 115);
            this.tbForgotMail.Name = "tbForgotMail";
            this.tbForgotMail.Size = new System.Drawing.Size(370, 36);
            this.tbForgotMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(82, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password has been sent to the above mail.\r\nPlease check the mail and enter the pa" + "ssword.\r\n\r\n";
            // 
            // linkForgot
            // 
            this.linkForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgot.LinkColor = System.Drawing.Color.Green;
            this.linkForgot.Location = new System.Drawing.Point(257, 302);
            this.linkForgot.Name = "linkForgot";
            this.linkForgot.Size = new System.Drawing.Size(240, 42);
            this.linkForgot.TabIndex = 13;
            this.linkForgot.TabStop = true;
            this.linkForgot.Text = "back to Login";
            this.linkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgot_LinkClicked);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkForgot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbForgotMail);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.LinkLabel linkForgot;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox tbForgotMail;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}