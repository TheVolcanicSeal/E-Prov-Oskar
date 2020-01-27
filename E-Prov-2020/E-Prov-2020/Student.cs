using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020
{
    class Student
    {
        //En static generator som alla elever kan använda sig av
        protected static Random generator = new Random();


        //Arrayer med krafter såväl som namn som änvänds i konstruktorn 
        protected static string[] names = { "Henry", "Bismillah", "Konrad", "Louis", "Tiffany" };


        //Här lägger jag till generella krafter, sådana som kan hittas i alla skolans linjer
        protected static List<string> avaliblePowers = new List<string> {"Telepathic", "Super Speedy", "Teleporting"};

        
        //Elevens namn och individuella kraft
        public string name;
        public string power;



    }
}
