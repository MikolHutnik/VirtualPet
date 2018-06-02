using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikolHutnikProject3
{
    class Pet
    {
        // fields
        private int hunger;
        private int thirst;
        private int waste;
        private bool hungerAlert;
        private bool thirstAlert;
        private bool wasteAlert;
        private string name;

        // properties
        public bool HungerAlert
        {
            get { return this.hungerAlert; }
            set { this.hungerAlert = value; }
        }

        public bool ThirstAlert
        {
            get { return this.thirstAlert; }
            set { this.thirstAlert = value; }
        }

        public bool WasteAlert
        {
            get { return this.wasteAlert; }
            set { this.wasteAlert = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        //default constructor
        public Pet()
        {
            //default constructor
        }

        public Pet(string name, int hunger, int thirst, int waste)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Waste = waste;
        }

        // Tick 
        public void Tick()
        {
            Hunger++;
            if (Hunger > 35)
            {
                StarveAlert(true);
            }
            else
            {
                StarveAlert(false);
            }

            Thirst++;
            if (Thirst > 35)
            {
                DehydrationAlert(true);
            }
            else
            {
                DehydrationAlert(false);
            }

            Waste++;
            if (Waste > 35)
            {
                PooAlert(true);
            }
            else
            {
               PooAlert(false);
            }
        }//tick end

        public bool StarveAlert(bool status)
        {
            HungerAlert = status;
            return HungerAlert;
        }

        public bool DehydrationAlert(bool status)
        {
            ThirstAlert = status;
            return ThirstAlert;
        }

        public bool PooAlert(bool status)
        {
            WasteAlert = status;
            return WasteAlert;
        }

        public int SetHunger(int num)
        {
            this.Hunger = num;
            return Hunger;
        }
        public int SetThirst(int num)
        {
            this.Thirst = num;
            return Thirst;
        }

        public int SetWaste(int num)
        {
            this.Waste = num;
            return Waste;
        }

        public string SetName(string name)
        {
            this.Name = name;
            return Name;
        }

        public void DragonPic()
        {

            Console.WriteLine(@"//                     ___====-_  _-====___                        //");
            Console.WriteLine(@"//              __--^^^      //     \\     ^^^--_                  //");
            Console.WriteLine(@"//             _-^         // (    ) \\         ^-_                //");
            Console.WriteLine(@"//            -           //  |\^^/|  \\           -               //");
            Console.WriteLine(@"//          _/           //   (0::0)   \\            \_            //");
            Console.WriteLine(@"//         /            ((     \\//     ))             \           //");
            Console.WriteLine(@"//       -               \\    (oo)    //               -          //");
            Console.WriteLine(@"//      -                 \\  / \/ \  //                 -         //");
            Console.WriteLine(@"//     -                   \\/      \//                   -        //");
            Console.WriteLine(@"//   / /|           /\      (        )      /\           |\ \      //");
            Console.WriteLine(@"//   |/ | /\_/\_/\_/  \_/\  (   /\   )  /\_/  \_/\_/\_/\ | \|      //");
            Console.WriteLine(@"//   `  |/  V  V  `    V  \_(| |  | |)_/  V    '  V  V  \|  '      //");
            Console.WriteLine(@"//      `   `  `       `   / | |  | | \   '       '  '   '         //");
            Console.WriteLine(@"//                       <(  | |  | |  )>                          //");
            Console.WriteLine(@"//                      <__\_| |  | |_\__>                         //");
            Console.WriteLine(@"//                      ^^^^ ^^^  ^^^ ^^^^^                        //");

        }


    }//class end
}//namespace end
