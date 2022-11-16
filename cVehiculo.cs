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
        public bool flagCombustible { get; set; }
        protected cCombustible combustible;
        public static uint maxID = 0;

        /// <summary>
        /// Constructor principal para inicializar los vehiculos
        /// </summary>
        /// <param name="anchoMax">Ancho maximo del vehiculo</param>
        /// <param name="largoMax">Largo maximo del vehiculo</param>
        /// <param name="altoMax">Alto maximo del vehiculo</param>
        /// <param name="pesoMax">Peso maximo del vehiculo</param>
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
            this.flagCombustible = false;
        }

        /// <summary>
        /// Algoritmo que permite repartir los pedidos de la lista interna del vehiculo, y ademas limpiar los elementos 
        /// cargados previamente de la lista total
        /// </summary>
        /// <param name="pedidosTotal">Lista de pedidos TOTAL</param>
        public void repartirPedidos(List<cPedido> pedidosTotal)
        {
            int i;
            this.flagCombustible = false;
            for (i = 0; i < pedidos.Count; i++)
            {
                this.nodosRecorridos++;
                if (combustible.getActual(this) != 0)
                {
                    this.pedidos.Remove(pedidos[i]);
                }
                else
                {
                    this.flagCombustible = true;
                    this.combustible.actual = 100;
                }
            }
            // reseteo count a 0
            this.pedidos.Clear();
            i = 0;
            while (pedidosTotal[i].cargado == true)
            {
                pedidosTotal.Remove(pedidosTotal[i]);
                i++;
            }
        }

   

    }
}
