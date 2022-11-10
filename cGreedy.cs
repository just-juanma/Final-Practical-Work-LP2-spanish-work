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
        public List<String> template { get; set; }
        public cGreedy()
        {
            template = new List<string>(generarTemplate());
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
            return pedidosOrdenados;
        }


        /// <summary>
        /// Genera una lista ordenada por la distancia de los nodos (desde Liniers)
        /// </summary>
        /// <see href="https://docs.google.com/spreadsheets/d/1favRBnx_6w94kmisbnjns-y3F3ULA8cs/edit?usp=sharing&ouid=116147555412703740669&rtpof=true&sd=true" />
        /// <returns>Lista generica</returns>
        public List<String> generarTemplate()
        {
            List<String> foo = new List<String>();
            foo.Add("liniers");
            foo.Add("versalles");
            foo.Add("villa luro");
            foo.Add("mataderos");
            foo.Add("la matanza");
            foo.Add("villa real");
            foo.Add("monte castro");
            foo.Add("velez sarfield");
            foo.Add("parque avellaneda");
            foo.Add("villa lugano");
            foo.Add("villa devoto");
            foo.Add("floresta");
            foo.Add("villa santarrita");
            foo.Add("villa del parque");
            foo.Add("villa soldati");
            foo.Add("flores");
            foo.Add("villa riachuelo");
            foo.Add("3 de febrero");
            foo.Add("lomas de zamora");
            foo.Add("villa puerryedon");
            foo.Add("agronomia");
            foo.Add("villa general mitre");
            foo.Add("la paternal");
            foo.Add("nueva pompeya");
            foo.Add("caballito");
            foo.Add("parque chacabuco");
            foo.Add("san martin");
            foo.Add("lanus");
            foo.Add("villa urquiza");
            foo.Add("parque chas");
            foo.Add("villa crespo");
            foo.Add("villa ortuzar");
            foo.Add("barracas");
            foo.Add("parque patricios");
            foo.Add("boedo");
            foo.Add("almagro");
            foo.Add("vicente lopez");
            foo.Add("avellaneda");
            foo.Add("saavedra");
            foo.Add("coghian");
            foo.Add("belgrano");
            foo.Add("colegiales");
            foo.Add("palermo");
            foo.Add("la boca");
            foo.Add("san telmo");
            foo.Add("constitucion");
            foo.Add("san cristobal");
            foo.Add("balvanera");
            foo.Add("recoleta");
            foo.Add("saavedra");
            foo.Add("nuniez");
            foo.Add("puerto madero");
            foo.Add("monserrat");
            foo.Add("san nicolas");
            foo.Add("retiro");
            return foo;
        }
    }
}
