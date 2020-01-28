using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraBand
{
    class CleanCar : Bil
    {

        public CleanCar()
        {

            passengers = generator.Next(3);
            contrabandAmount = 0;

        }

    }
}
