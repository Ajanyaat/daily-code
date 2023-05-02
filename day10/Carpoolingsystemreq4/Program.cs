using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpoolingsystemreq4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("id");
                long id = long.Parse(Console.ReadLine());
                Console.WriteLine("name");
                string name = Console.ReadLine();
                Console.WriteLine("type");
                string type = Console.ReadLine();
                Console.WriteLine("distance");
                double distance = double.Parse(Console.ReadLine());



                Car car;//since it is a abstract cannot use Car car=new car.....

                if (type ==" HatchBack")
                {

                    Console.WriteLine("power windows");
                    bool powerWindowsEnabled = bool.Parse(Console.ReadLine());
                    Console.WriteLine("automatic");
                    bool automaticGear = bool.Parse(Console.ReadLine());
                    car = new HatchBack(powerWindowsEnabled, automaticGear, id, name);

                }



                else if(type== "Sedan")
                {
                    
                    Console.WriteLine("abs enabled");
                    bool absEnabled = bool.Parse(Console.ReadLine());
                    Console.WriteLine("boot space");
                    int bootspace=int.Parse(Console.ReadLine());
                    car = new Sedan(absEnabled, bootspace,id, name);
                }
                else
                {


                Console.WriteLine("rear cooling vents");
                bool rearCoolingVents = bool.Parse(Console.ReadLine());
                car = new UtilityCar(rearCoolingVents, id, name);
                }


                double cost = car.CalculateDriveCost(distance);
                Console.WriteLine("Cost is Rs", + cost);

            
        }
    }
}