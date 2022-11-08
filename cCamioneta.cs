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
        public cCamioneta() : base(100, 1441, 3092, 1233) 
        {
            this.dSuelo = 186;
        }
    }
}
