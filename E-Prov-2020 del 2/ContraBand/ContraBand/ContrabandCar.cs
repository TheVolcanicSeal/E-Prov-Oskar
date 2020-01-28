using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraBand
{
    class ContrabandCar : Bil
    {


        public ContrabandCar()
        {

            passengers = generator.Next(4);
            contrabandAmount = generator.Next(1, 6);


        }


    }
}
