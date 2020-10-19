using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVL1POODavidMalcaT3BN
{
    public class Elecktra : Producto
    {

        public override double flete()
        {
            switch (linea)
            {
                case "Audio Video":
                    return 30.00;
                case "Blanca":
                    return 45.00;
                  
                case "Menaje":
                   return  40.00;
                   
            }
            return flete();
        }

    }
}

    


