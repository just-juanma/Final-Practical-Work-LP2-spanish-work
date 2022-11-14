using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    public class cVehiculo
    {
        public readonly uint ID;
        protected float velocidadMedia;
        protected float anchoMax;
        protected float largoMax;
        protected float altoMax;
        public int pesoMax { get; set; }
        public float volumenMax { get; set; }
        public int pesoActual { get; set; }
        public float volumenActual { get; set; }
        public int nodosRecorridos { get; set; } 
        public List<cPedido> pedidos { get; set; }
        protected cCombustible combustible;
        public static uint maxID = 0;

        public cVehiculo(float anchoMax, float largoMax, float altoMax, int pesoMax)
        {
            ID = maxID++;
            this.anchoMax = anchoMax;
            this.largoMax = largoMax;
            this.altoMax = altoMax;
            this.pesoMax = pesoMax;
            this.volumenMax = altoMax * largoMax * anchoMax;
            this.combustible = new cCombustible();
            this.pedidos = new List<cPedido>();
        }

        public void repartirPedidos(List<cPedido> pedidosTotal)
        {
            int i;
            for (i = 0; i < pedidos.Count; i++)
            {
                if (combustible.getActual(this) != 0)
                {
                    pedidos.Remove(pedidos[i]);
                }
                else
                {
                    Console.WriteLine("Vehiculo sin combustible ... Recargando...");
                    combustible.actual = 100;
                }
            }
            // reseteo count a 0
            pedidos.Clear();
            while (pedidosTotal[i].cargado == true)
            {
                pedidosTotal.Remove(pedidosTotal[i]);
                i++;
            }
        }

   

    }
}
