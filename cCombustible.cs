using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    public class cCombustible
    {
        public float actual { get; set; } // en porcentaje (%)

        public cCombustible() 
        {
            this.actual = 100;
        }

        public float getActual(cVehiculo vehiculo)
        {
            if(vehiculo is cFurgon)
            {
                return this.actual -= ((vehiculo.nodosRecorridos * 21.2F) / 33.3F) * cFurgon.ahorroFurgon;
            }
            else if(vehiculo is cFurgoneta)
            {
                return this.actual -= ((vehiculo.nodosRecorridos * 7.6F) / 33.3F);
            }
            else
            {
                return this.actual -= ((vehiculo.nodosRecorridos * 15.2F) / 33.3F);
            }
            
        }



    }
}
