using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    internal class cProgDinamica
    {
        // W = vehiculo.volumenMax
        // wt = pedidos[].volumen
        // val = pedidos[].prioridad
        // n = pedidos.len
        static void cargarPedidos(List<cPedido> pedidos, cVehiculo vehiculo)
        {
            int[,] solucion = new int[pedidos.Count, vehiculo.volumenMax];

            int i, j;

            for(i = 0; i <= pedidos.Count; i++)
            {
                for(j = 0; j <= vehiculo.volumenMax; j++)
                {
                    if(i == 0 || j == 0)
                    {
                        solucion[i, j] = 0;
                    }
                    else if (pedidos[i - 1].volumen <= j)
                    {
                        solucion[i, j] = Math.Max(pedidos[i - 1].prioridad + solucion[i - 1, j - pedidos[i - 1].volumen],
                                                  solucion[i - 1, j]);
                        if (pedidos[i - 1].prioridad + solucion[i - 1, j - pedidos[i - 1].volumen] > solucion[i - 1, j] && pedidos[i - 1].cargado == false)
                        {
                            vehiculo.pedidos.Add(pedidos[i - 1]);
                            pedidos[i - 1].cargado = true;
                        }
                    }
                    else
                    {
                        solucion[i, j] = solucion[i - 1, j];
                    }
                }
            }
        }
    }
}
