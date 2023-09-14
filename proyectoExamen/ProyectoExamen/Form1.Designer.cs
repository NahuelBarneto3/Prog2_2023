namespace ProyectoExamen
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lblLogin = new Label();
            lblUser = new Label();
            lblPassword = new Label();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.CharacterCasing = CharacterCasing.Upper;
            txtUser.Location = new Point(344, 233);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.CharacterCasing = CharacterCasing.Lower;
            txtPassword.Location = new Point(344, 277);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(344, 181);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(90, 28);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "LOGIN";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(300, 236);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(30, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(281, 280);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(344, 328);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(100, 54);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogIn);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Label lblLogin;
        private Label lblUser;
        private Label lblPassword;
        private Button btnLogIn;
    }
}