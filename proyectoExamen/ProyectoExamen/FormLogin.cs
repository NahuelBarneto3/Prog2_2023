using Entidades;
using System.Runtime.Serialization;

namespace ProyectoExamen
{
    public partial class FormLogin : Form
    {
        //listas de operarios y supervisores
        List<Operario> listOperarios = new List<Operario>();


        List<Supervisor> listSupervisores = new List<Supervisor>();


        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Recupera los datos ingresados en los textbox para permitirnos o denegarnos el ingreso
            /// </summary
            FormAdmin formAdmin = new FormAdmin();
            FormOperario formOperario = new FormOperario();
            string passwordIngresada = txtPassword.Text;
            string userIngresado = txtUser.Text;
            bool userEncontrado = false;

            string userABuscar = "";
            string passwordABuscar = "";

            //agregar validaciones de quien se registro 
            //si un operario o un supervisor, para poder largar el form que corresponde
            //salto de un formulario login a el formulario de administracion
            //y oculto el de login (podria volver despues)
            if (cbOperario.Checked)
            {
                foreach (Operario operario in listOperarios)
                {
                    userABuscar = operario.User;
                    passwordABuscar = operario.Password;
                    if (userABuscar == userIngresado && passwordABuscar == passwordIngresada)
                    {
                        formOperario.Show();
                        formOperario.Activate();
                        this.Hide();
                        userEncontrado = true;
                        break;
                    }


                }
                if (userEncontrado == false)
                {
                    MessageBox.Show("usuario operario invalido ", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else if (cbSupervisor.Checked)
            {
                foreach (Supervisor supervisor in listSupervisores)
                {
                    if (supervisor.User == userIngresado && supervisor.Password == passwordIngresada)
                    {

                        formAdmin.Show();
                        formAdmin.Activate();
                        this.Hide();
                        userEncontrado = true;
                        break;
                    }


                }
                if (userEncontrado == false)
                {
                    MessageBox.Show("usuario supervisor invalido ", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("seleccione usuario ", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void cbOperario_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOperario.Checked)
            {
                cbSupervisor.Checked = false;
            }
        }

        private void cbSupervisor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSupervisor.Checked)
            {
                cbOperario.Checked = false;
            }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

            Operario operarioPrueba1 = new Operario("OPERARIO1", "CONTRASENA1");
            Operario operarioPrueba2 = new Operario("OPERARIO2", "CONTRASENA2");
            listOperarios.Add(operarioPrueba1);
            listOperarios.Add(operarioPrueba2);
            Supervisor supervisorPrueba1 = new Supervisor("SUPERVISOR1", "CONTRASENA1");
            Supervisor supervisorPrueba2 = new Supervisor("SUPERVISOR2", "CONTRASENA2");
            listSupervisores.Add(supervisorPrueba1);
            listSupervisores.Add(supervisorPrueba2);
            MessageBox.Show("Datos cargados", "test", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUser.Text = "OPERARIO1";
            txtPassword.Text = "CONTRASENA1";
            cbOperario.Checked = true;



        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Quiere cerrar la aplicacion?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }


        }
    }
}
