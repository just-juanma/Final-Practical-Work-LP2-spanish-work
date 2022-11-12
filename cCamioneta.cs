using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    internal class cCamioneta : cVehiculo
    {
        private float dSuelo;
        public cCamioneta() : base(100, 900, 300, 600, 750) 
        {
            this.dSuelo = 186;
        }
    }
}
