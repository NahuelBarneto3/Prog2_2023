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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoExamen
{
    public partial class FormAdmin : Form
    {
        DicMateriales inventario = new DicMateriales();

        //Dictionary<string, int> inventario = new Dictionary<string, int>();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("god no ?");
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            //traer el inventario con algun getter   
            inventario.CargarInventario();
            foreach (var item in inventario)
            {
                ListViewItem materiales = new ListViewItem(item.Key);

                materiales.SubItems.Add(item.Value.ToString());
                lstVProductos.Items.Add(materiales);

            }
        }

        private void lstVProductos_Click(object sender, EventArgs e)
        {
            if (lstVProductos.SelectedItems.Count > 0)
            {
                txtProducto.Text = lstVProductos.SelectedItems[0].SubItems[0].Text;
                txtCantidadActual.Text = lstVProductos.SelectedItems[0].SubItems[1].Text;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidadProducto = 0;
            int nuevaCantidad = 0;
            if (lstVProductos.SelectedItems.Count > 0)
            {
                cantidadProducto = Int32.Parse(lstVProductos.SelectedItems[0].SubItems[1].Text);

                nuevaCantidad = (int)(cantidadProducto + numCantidadAgregar.Value);

                lstVProductos.SelectedItems[0].SubItems[1].Text = nuevaCantidad.ToString();
            }
        }


    }
}
