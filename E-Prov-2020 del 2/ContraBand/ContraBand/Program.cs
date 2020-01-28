using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContraBand
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            List<Bil> carList = new List<Bil>() { };

            Console.WriteLine("Hur många bilar vill du kolla?");

            int amountOfCars = CheckIfNumber(Console.ReadLine(), 100);



            for (int i = 0; i < amountOfCars; i++)
            {

                if(generator.Next(99) > 74)
                {

                    CleanCar newCar = new CleanCar();
                    carList.Add(newCar);

                }
                else
                {

                    ContrabandCar newCar = new ContrabandCar();
                    carList.Add(newCar);

                }




            }

            Console.Clear();

            Console.WriteLine(carList.Count() + " bilar kör fram till tullen");

            bool checkedAllCars = false;

            while (checkedAllCars == false)
            {

                Console.WriteLine("Vilken bil vill du kolla?");

                int selectedCar = CheckIfNumber(Console.ReadLine(), carList.Count) -1;



                if (carList[selectedCar].alreadyChecked == true)
                {

                    Console.WriteLine("den bilen har du redan kollat!");

                }
                else
                {

                    if (carList[selectedCar].Investigate())
                    {

                        Console.WriteLine("Bilen hade " + carList[selectedCar].contrabandAmount + " Olagliga saker i sig!");

                    }
                    else
                    {

                        Console.WriteLine("Bilen är ren!");

                    }

                }

                int amountOfCarsChecked = 0;

                foreach (var item in carList)
                {



                    if (item.alreadyChecked)
                    {

                        amountOfCarsChecked += 1;

                    }

                }

                if(amountOfCarsChecked == carList.Count())
                {

                    checkedAllCars = true;

                }

            }

            Console.WriteLine("\nDu har nu kollat alla bilar, Bra jobbat!");

            Console.ReadLine();
        }

        public static int CheckIfNumber(string input, int maxInput)
        {

            bool validNumber = false;
            int number = 0;

            while (validNumber == false)
            {


                validNumber = int.TryParse(input, out number);

                if(number > maxInput)
                {

                    validNumber = false;

                }

                if (validNumber == false)
                {

                    Console.WriteLine("That's not a valid number");


                    input = Console.ReadLine();

                }
                else
                {

                    

                }

            };

            return number;

        }

    }
}
