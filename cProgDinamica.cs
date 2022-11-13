﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    internal class cProgDinamica
    {
        /// <summary>
        /// Carga los pedidos, optimizando el volumen-prioridad de cada pedido, en relacion con el del vehiculo
        /// </summary>
        /// <param name="pedidos">lista de pedidos a cargar</param>
        /// <param name="vehiculo">vehiculo a cargar pedidos</param>
        public void cargarPedidos(List<cPedido> pedidos, cVehiculo vehiculo)
        {
            cPedido foo;
            int i, j;
            float sumVol = 0;
            int nuevaCantPedidos = 0;
            int sumaPeso = 0;

            for (i = 0; i < pedidos.Count - 1; i++)
                for (j = i + 1; j < pedidos.Count; j++)
                    if (pedidos[i].volumen > pedidos[j].volumen)
                    {
                        foo = pedidos[i];
                        pedidos[i] = pedidos[j];
                        pedidos[j] = foo;
                    }

            for (i = 0; i < pedidos.Count; i++)
            {
                if (sumVol <= vehiculo.volumenMax)
                {
                    sumVol += pedidos[i].volumen;
                    nuevaCantPedidos++;
                }
                else break;
            }

            int[,] solucion = new int[nuevaCantPedidos + 1, vehiculo.pesoMax + 1];


            for(i = 0; i <= nuevaCantPedidos; i++)
            {
                for(j = 0; j <= vehiculo.pesoMax; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        solucion[i, j] = 0;
                    }
                    else if (pedidos[i - 1].peso <= j)
                    {
                        solucion[i, j] = Math.Max(pedidos[i - 1].prioridad + solucion[i - 1, j - pedidos[i - 1].peso],
                                                  solucion[i - 1, j]);
                        if (pedidos[i - 1].prioridad + solucion[i - 1, j - pedidos[i - 1].peso] > solucion[i - 1, j] // hubo modificaciones en la matriz prog. dinamica?
                            && pedidos[i - 1].cargado == false // se cargo el pedido anteriormente?
                            && sumaPeso + pedidos[i - 1].peso < vehiculo.pesoMax) // se excede el peso del vehiculo?
                        {
                            vehiculo.pedidos.Add(pedidos[i - 1]); 
                            pedidos[i - 1].cargado = true;
                            sumaPeso += pedidos[i - 1].peso;
                        }
                    }
                    else
                    {
                        solucion[i, j] = solucion[i - 1, j];
                    }
                }
            }
            Console.WriteLine(sumaPeso);
        }
    }
}
