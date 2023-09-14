namespace ProyectoExamen
{
    public partial class FormLogin : Form
    {


        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Recupera los datos ingresados en los textbox para permitirnos o denegarnos el ingreso
            /// </summary>
            //la idea es cuando estemos con diccionarios, generar un diccionario con clave de operario y valor el valor tenga guardada la contrasena
            //por ahora solo probamos funcionamiento
            //con los objetos operario y supervisor por separados se pueden cagar directamente listas de cada uno con sus respectivos users y pass
            FormAdmin formAdmin = new FormAdmin();

            string[] validUser = { "OPR", "SUP" };//operario o supervisor
            string user = txtUser.Text;
            string[] validPassword = { "opr1234", "sup1234" };//operario o supervisor password

            string password = txtPassword.Text;


            for (int i = 0; i < validUser.Length; i++)
            {
                if (user == validUser[i] && password == validPassword[i])//agregar validaciones de quien se registro 
                                                                         //si un operario o un supervisor, para poder largar el form que corresponde
                                                                         //salto de un formulario login a el formulario de administracion
                                                                         //y oculto el de login (podria volver despues)
                {
                    MessageBox.Show("usuario valido ", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formAdmin.Show();
                    formAdmin.Activate();
                    this.Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("usuario no valido o password no valido", "User LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}