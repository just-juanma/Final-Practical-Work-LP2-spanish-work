using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tp_final
{
    public class cFurgon : cVehiculo
    {
        public const float ahorroFurgon = 0.4F;

        /// <summary>
        /// Datos de referencia iniciales para el furgon
        /// </summary>
        public cFurgon() : base(219, 725.4F, 289.4F, 2519) { }

    }
}
