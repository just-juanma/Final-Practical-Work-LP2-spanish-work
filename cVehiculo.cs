using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    internal class cVehiculo
    {
        protected readonly uint ID;
        protected float velocidadMedia;
        protected float anchoMax;
        protected float largoMax;
        protected float altoMax;
        public int volumenMax { get; set; }
        public int nodosRecorridos { get; set; } 
        public List<cPedido> pedidos { get; set; }
        protected cCombustible combustible;
        public static uint maxID = 0;

        public cVehiculo(float velocidadMedia, float anchoMax, float largoMax, float altoMax)
        {
            ID = maxID++;
            this.velocidadMedia = velocidadMedia;
            this.anchoMax = anchoMax;
            this.largoMax = largoMax;
            this.altoMax = altoMax;
            this.volumenMax = Convert.ToInt32(altoMax * largoMax * anchoMax);
            this.combustible = new cCombustible();
            this.pedidos = new List<cPedido>();
        }


   

    }
}
