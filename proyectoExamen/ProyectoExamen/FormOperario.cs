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
        Dictionary<string, int> inventario = new Dictionary<string, int>();

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
            inventario["Harina de Avena"] = 5000;      // 5000 gramos de harina
            inventario["Azucar"] = 5000;      // 5000 gramos de azucar
            inventario["Manteca"] = 4500;      // 4500 gramos de Manteca
            inventario["Avena"] = 6000;      // 6000 gramos de Avena
            inventario["Huevos"] = 600;      // 600 unidades huevos
            inventario["Bicarbonato de sodio"] = 1000;      // 1000 gramos de Bicarbonato de sodio
            inventario["Sal"] = 7500;      // 7500 gramos de sal
            inventario["Extracto de vainilla"] = 1000;  // 1000 ml de bicarbonato
        }
    }
}
