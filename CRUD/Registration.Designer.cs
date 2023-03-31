using System.ComponentModel;

namespace CRUD
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbconfirmPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMail = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbPass = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbPasswordMatch = new System.Windows.Forms.Label();
            this.lbUserCheck = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Address:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password:";
            // 
            // tbMail
            // 
            this.tbMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(292, 51);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(363, 36);
            this.tbMail.TabIndex = 4;
            this.tbMail.TextChanged += new System.EventHandler(this.tbMail_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(292, 144);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(363, 36);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbconfirmPass
            // 
            this.tbconfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbconfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbconfirmPass.Location = new System.Drawing.Point(292, 263);
            this.tbconfirmPass.Name = "tbconfirmPass";
            this.tbconfirmPass.Size = new System.Drawing.Size(363, 36);
            this.tbconfirmPass.TabIndex = 6;
            this.tbconfirmPass.UseSystemPasswordChar = true;
            this.tbconfirmPass.TextChanged += new System.EventHandler(this.tbconfirmPass_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register Now";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMail
            // 
            this.lbMail.Location = new System.Drawing.Point(292, 90);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(172, 23);
            this.lbMail.TabIndex = 8;
            this.lbMail.Text = "Invalid Email Address";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // lbPass
            // 
            this.lbPass.Location = new System.Drawing.Point(292, 183);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(496, 52);
            this.lbPass.TabIndex = 9;
            this.lbPass.Text = "Password Should contain at least one digit .At least one upper case.At least one " + "lower case.At least one of the special characters[@,!,$,-,&,_]\r\n";
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // lbPasswordMatch
            // 
            this.lbPasswordMatch.Location = new System.Drawing.Point(295, 305);
            this.lbPasswordMatch.Name = "lbPasswordMatch";
            this.lbPasswordMatch.Size = new System.Drawing.Size(291, 36);
            this.lbPasswordMatch.TabIndex = 10;
            this.lbPasswordMatch.Text = "Incorrect Password";
            // 
            // lbUserCheck
            // 
            this.lbUserCheck.Location = new System.Drawing.Point(295, 113);
            this.lbUserCheck.Name = "lbUserCheck";
            this.lbUserCheck.Size = new System.Drawing.Size(271, 28);
            this.lbUserCheck.TabIndex = 11;
            this.lbUserCheck.Text = "User Email Already registered...!";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbUserCheck);
            this.Controls.Add(this.lbPasswordMatch);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbconfirmPass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbUserCheck;

        private System.Windows.Forms.Label lbPasswordMatch;

        private System.Windows.Forms.ErrorProvider errorProvider2;

        private System.Windows.Forms.Label lbPass;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.Label lbMail;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbconfirmPass;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMail;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}