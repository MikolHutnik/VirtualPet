using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikolHutnikProject3
{
    class Program
    {
        static void Main(string[] args)
        {

            Pet Dragon = new Pet("Dragon", 26, 26, 26);
            Dragon.DragonPic();
            Console.WriteLine("Welcome to the Virtual Pet Program");
            Console.WriteLine("Please type Yes to manage your {0}!", Dragon.Name);
            string userResponse = Console.ReadLine().ToLower();
            while (userResponse.Equals("yes"))
            {
                Dragon.DragonPic();
                Console.WriteLine("Please select from the following to manage your {0}.", Dragon.Name);

                Console.WriteLine("Select 1 to get the status of your {0}.", Dragon.Name);
                Console.WriteLine("Select 2 to feed your {0}.", Dragon.Name);
                Console.WriteLine("Select 3 to water the {0}.", Dragon.Name);
                Console.WriteLine("Select 4 to walk your {0}.", Dragon.Name);
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Dragon.Tick();
                        if (Dragon.HungerAlert)
                        {
                            Console.WriteLine("The {0} is hungry and needs to be fed.", Dragon.Name);
                            Console.WriteLine("Please enter a new food amount for the {0}.", Dragon.Name);
                            int hungerAlert = int.Parse(Console.ReadLine());
                            Dragon.SetHunger(hungerAlert);

                        }
                        if (Dragon.ThirstAlert)
                        {
                            Console.WriteLine("The {0}'s thirst levels are high and he needs water.", Dragon.Name);
                            Console.WriteLine("Please enter a new water level for the {0}.", Dragon.Name);
                            int thirstAlert = int.Parse(Console.ReadLine());
                            Dragon.SetThirst(thirstAlert);

                        }
                        if (Dragon.WasteAlert)
                        {
                            Console.WriteLine("The {0} is {1} deep and needs to be fed.", Dragon.Name, Dragon.WasteAlert);
                            Console.WriteLine("Please enter a new food amount for the {0}.", Dragon.Name);
                            int wasteAlert = int.Parse(Console.ReadLine());
                            Dragon.SetWaste(wasteAlert);

                        }
                        Console.WriteLine("The {0}'s levels for Hunger: {1} Thirst: {2} Waste {3}", Dragon.Name, Dragon.Hunger, Dragon.Thirst, Dragon.Waste);

                        break;
                    case 2:
                        Dragon.Tick();
                        Console.WriteLine("Enter a new food amount.");
                        int hunger = int.Parse(Console.ReadLine());
                        Dragon.SetHunger(hunger);
                        Console.WriteLine("The new food amount for the {0} is {1}", Dragon.Name, Dragon.Hunger);
                        break;
                    case 3:
                        Dragon.Tick();
                        Console.WriteLine("Enter a new water amount level.");
                        int thirst = int.Parse(Console.ReadLine());
                        Dragon.SetThirst(thirst);
                        Console.WriteLine("The new thirst level of the {0} is {1}", Dragon.Name, Dragon.Thirst);
                        break;
                    case 4:
                        Dragon.Tick();
                        Console.WriteLine("Enter a new amount of time outside.");
                        int waste = int.Parse(Console.ReadLine());
                        Dragon.SetWaste(waste);
                        Console.WriteLine("The new poo level of the {0} is {1}", Dragon.Name, Dragon.Waste);
                        break;
                    default:
                        break;

                }
                Dragon.Tick();
                Console.WriteLine("Please type Yes to manage your {0}!", Dragon.Name);
                userResponse = Console.ReadLine().ToLower();
            }




        }
    }
}
