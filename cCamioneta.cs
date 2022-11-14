using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    public class cCamioneta : cVehiculo
    {
        private float dSuelo;
        public cCamioneta() : base(176, 439.7F, 186, 688)
        {
            this.dSuelo = 186;
        }
    }
}
