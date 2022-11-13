using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace tp_final
{
    public class cGreedy
    {
        public List<string> template { get; set; }
        public cGreedy()
        {
            template = new List<string>();
        }

        public List<cPedido> ordenarPedidos(List<cPedido> pedidos)
        {
            List<cPedido> pedidosOrdenados = new List<cPedido>();

            for (int i = 0; i < template.Count; i++)
            {
                for (int j = 0; j < pedidos.Count; j++)
                {
                    if (template[i] == pedidos[j].barrio)
                    {
                        pedidosOrdenados.Add(pedidos[j]);
                    }
                }
            }

            //foreach(var pedido in pedidosOrdenados)
            //{

            //}

            return pedidosOrdenados;
            
        }


    }
}
