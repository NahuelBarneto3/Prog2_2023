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
            cbOperario = new CheckBox();
            cbSupervisor = new CheckBox();
            btnPrueba = new Button();
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
            lblLogin.Size = new Size(96, 28);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "LOG IN";
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
            btnLogIn.Location = new Point(344, 356);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(100, 54);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // cbOperario
            // 
            cbOperario.AutoSize = true;
            cbOperario.Location = new Point(351, 306);
            cbOperario.Name = "cbOperario";
            cbOperario.Size = new Size(72, 19);
            cbOperario.TabIndex = 6;
            cbOperario.Text = "Operario";
            cbOperario.UseVisualStyleBackColor = true;
            cbOperario.CheckedChanged += cbOperario_CheckedChanged;
            // 
            // cbSupervisor
            // 
            cbSupervisor.AutoSize = true;
            cbSupervisor.Location = new Point(351, 331);
            cbSupervisor.Name = "cbSupervisor";
            cbSupervisor.Size = new Size(81, 19);
            cbSupervisor.TabIndex = 7;
            cbSupervisor.Text = "Supervisor";
            cbSupervisor.UseVisualStyleBackColor = true;
            cbSupervisor.CheckedChanged += cbSupervisor_CheckedChanged;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(620, 12);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(168, 62);
            btnPrueba.TabIndex = 8;
            btnPrueba.Text = "ButtonPrueba";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrueba);
            Controls.Add(cbSupervisor);
            Controls.Add(cbOperario);
            Controls.Add(btnLogIn);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Name = "FormLogin";
            Text = "Login";
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
        private CheckBox cbOperario;
        private CheckBox cbSupervisor;
        private Button btnPrueba;
    }
}