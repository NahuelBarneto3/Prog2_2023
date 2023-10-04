using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DicMateriales
    {
        private Dictionary<string, int> inventario;

        public DicMateriales()
        {
            
        }

        
        public void CargarInventario()
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
