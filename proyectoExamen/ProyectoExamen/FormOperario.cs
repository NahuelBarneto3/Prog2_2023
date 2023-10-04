using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoExamen
{
    public partial class FormOperario : Form
    {
        DicMateriales inventario = new DicMateriales();

        FormLogin formLogin = new FormLogin();


        public FormOperario()
        {
            InitializeComponent();
        }



        private void btnPrueba_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///Esta funcion es simplemente un boton de carga de datos de Prueba
            /// </summary>
            /// 
            inventario.CargarInventario();
            foreach (var item in inventario)
            {
                ListViewItem materiales = new ListViewItem(item.Key);

                materiales.SubItems.Add(item.Value.ToString());
                lstVStock.Items.Add(materiales);

            }
        }

        private void FormOperario_FormClosing(object sender, FormClosingEventArgs e)
        {
            ///<summary>
            ///Proporciona un menu de confirmacion para cerrar
            /// </summary>
            DialogResult res = MessageBox.Show("Quiere volver al menu de Login?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            formLogin.Show();
        }

        private void FormOperario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
