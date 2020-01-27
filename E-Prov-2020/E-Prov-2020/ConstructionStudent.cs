using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Prov_2020
{

    //Här är klassen för elever som går konstruktionslinjen, dessa kan ha alla de generiska krafterna men det finns även elever med andra krafter
    //Som automatiskt blir placerade i denna linje.
    class ConstructionStudent : Student
    {

        //Här lägger jag till en lista med krafter som är unika för Konstruktionselever, krafter som inte finns i andra linjer
        List<string> uniquePowers = new List<string>() {"Telekinetic", "Super Strong" };
        


        public ConstructionStudent()
        {

            foreach (string item in avaliblePowers)
            {

                uniquePowers.Add(item);

            }

            power = uniquePowers[generator.Next(uniquePowers.Count)];
            name = names[generator.Next(names.Length)];

        }

    }
}
