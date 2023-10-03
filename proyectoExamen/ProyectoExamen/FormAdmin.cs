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

        Dictionary<string, int> inventario = new Dictionary<string, int>();

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
            inventario["Harina de Avena"] = 5000;      // 5000 gramos de harina
            inventario["Azucar"] = 5000;      // 5000 gramos de azucar
            inventario["Manteca"] = 4500;      // 4500 gramos de Manteca
            inventario["Avena"] = 6000;      // 6000 gramos de Avena
            inventario["Huevos"] = 600;      // 600 unidades huevos
            inventario["Bicarbonato de sodio"] = 1000;      // 1000 gramos de Bicarbonato de sodio
            inventario["Sal"] = 7500;      // 7500 gramos de sal
            inventario["Extracto de vainilla"] = 1000;  // 1000 ml de bicarbonato
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
