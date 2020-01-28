using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraBand
{
    class Bil
    {

        protected static Random generator = new Random();
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked = false;

        public bool Investigate()
        {

            alreadyChecked = true;

            if(contrabandAmount > 0)
            {

                return true;

            }
            else
            {

                return false;

            }


        } 

    }

}
