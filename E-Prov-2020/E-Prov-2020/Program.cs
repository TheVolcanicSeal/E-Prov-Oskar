using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020
{
    class Program
    {
        static void Main(string[] args)
        {

            Student q = new ConstructionStudent();

            Console.WriteLine(q.name);
            Console.WriteLine(q.power);

            Console.ReadLine();
        }
    }
}
