using System.ComponentModel;

namespace CRUD
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMailLogin = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPassLogin = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbInvalid = new System.Windows.Forms.Label();
            this.lbLoginpass = new System.Windows.Forms.Label();
            this.lbNotRegistered = new System.Windows.Forms.Label();
            this.btShowPass = new System.Windows.Forms.Button();
            this.btPassHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // tbMailLogin
            // 
            this.tbMailLogin.BackColor = System.Drawing.SystemColors.Window;
            this.tbMailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMailLogin.Location = new System.Drawing.Point(301, 76);
            this.tbMailLogin.Name = "tbMailLogin";
            this.tbMailLogin.Size = new System.Drawing.Size(305, 36);
            this.tbMailLogin.TabIndex = 3;
            this.tbMailLogin.TextChanged += new System.EventHandler(this.tbMailLogin_TextChanged);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(230, 291);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(240, 39);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(142, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Don\'t have account? Create";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPassLogin
            // 
            this.tbPassLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassLogin.Location = new System.Drawing.Point(301, 185);
            this.tbPassLogin.Name = "tbPassLogin";
            this.tbPassLogin.Size = new System.Drawing.Size(305, 36);
            this.tbPassLogin.TabIndex = 6;
            this.tbPassLogin.UseSystemPasswordChar = true;
            this.tbPassLogin.TextChanged += new System.EventHandler(this.tbPassLogin_TextChanged);
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
            // lbInvalid
            // 
            this.lbInvalid.Location = new System.Drawing.Point(301, 115);
            this.lbInvalid.Name = "lbInvalid";
            this.lbInvalid.Size = new System.Drawing.Size(237, 33);
            this.lbInvalid.TabIndex = 7;
            this.lbInvalid.Text = "Invalid Email Address";
            // 
            // lbLoginpass
            // 
            this.lbLoginpass.Location = new System.Drawing.Point(301, 224);
            this.lbLoginpass.Name = "lbLoginpass";
            this.lbLoginpass.Size = new System.Drawing.Size(284, 27);
            this.lbLoginpass.TabIndex = 8;
            this.lbLoginpass.Text = "Password does not match";
            // 
            // lbNotRegistered
            // 
            this.lbNotRegistered.Location = new System.Drawing.Point(301, 137);
            this.lbNotRegistered.Name = "lbNotRegistered";
            this.lbNotRegistered.Size = new System.Drawing.Size(138, 22);
            this.lbNotRegistered.TabIndex = 9;
            this.lbNotRegistered.Text = "Email not registerd";
            // 
            // btShowPass
            // 
            this.btShowPass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btShowPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShowPass.Image = ((System.Drawing.Image)(resources.GetObject("btShowPass.Image")));
            this.btShowPass.Location = new System.Drawing.Point(560, 185);
            this.btShowPass.Name = "btShowPass";
            this.btShowPass.Size = new System.Drawing.Size(46, 36);
            this.btShowPass.TabIndex = 10;
            this.btShowPass.UseVisualStyleBackColor = false;
            this.btShowPass.Click += new System.EventHandler(this.btShowPass_Click);
            // 
            // btPassHide
            // 
            this.btPassHide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPassHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPassHide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPassHide.FlatAppearance.BorderSize = 0;
            this.btPassHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPassHide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPassHide.Image = ((System.Drawing.Image)(resources.GetObject("btPassHide.Image")));
            this.btPassHide.Location = new System.Drawing.Point(560, 185);
            this.btPassHide.Name = "btPassHide";
            this.btPassHide.Size = new System.Drawing.Size(46, 36);
            this.btPassHide.TabIndex = 11;
            this.btPassHide.UseVisualStyleBackColor = false;
            this.btPassHide.Click += new System.EventHandler(this.btPassHide_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPassHide);
            this.Controls.Add(this.btShowPass);
            this.Controls.Add(this.lbNotRegistered);
            this.Controls.Add(this.lbLoginpass);
            this.Controls.Add(this.lbInvalid);
            this.Controls.Add(this.tbPassLogin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbMailLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btPassHide;

        private System.Windows.Forms.Button btShowPass;

        private System.Windows.Forms.Label lbNotRegistered;

        private System.Windows.Forms.Label lbLoginpass;

        private System.Windows.Forms.Label lbInvalid;

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPassLogin;

        private System.Windows.Forms.TextBox tbMailLogin;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}