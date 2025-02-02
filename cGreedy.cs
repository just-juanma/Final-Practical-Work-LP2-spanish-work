﻿using System;
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
        /// <summary>
        /// Inicializacion de la template
        /// </summary>
        public cGreedy()
        {
            template = new List<string>();
        }
        /// <summary>
        /// Ordena los pedidos mediante una lista auxiliar ordenada de ante mano
        /// </summary>
        /// <param name="pedidos">Lista de pedidos a ordenar</param>
        /// <returns>Lista de pedidos ordenada</returns>
        public List<cPedido> ordenarPedidos(List<cPedido> pedidos)
        {
            List<cPedido> pedidosOrdenados = new List<cPedido>();
            bool[] visitados = new bool[template.Count];

            for (int i = 0; i < template.Count; i++)
            {
                for (int j = 0; j < pedidos.Count; j++)
                {
                    if (template[i] == pedidos[j].barrio &&
                        visitados[i] == false)
                    {
                        pedidosOrdenados.Add(pedidos[j]);
                        visitados[i] = true;
                    }
                }
            }
            return pedidosOrdenados;
        }


    }
}
