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
        // protected cCombustible combustible;
        public static uint maxID = 0;
        protected float nodosRecorridos;

        public cVehiculo(float velocidadMedia, float anchoMax, float largoMax, float altoMax)
        {
            ID = maxID++;
            this.velocidadMedia = velocidadMedia;
            this.anchoMax = anchoMax;
            this.largoMax = largoMax;
            this.altoMax = altoMax;
            this.nodosRecorridos = 0;
        }

   

    }
}
