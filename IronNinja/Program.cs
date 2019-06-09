using System;
using System.Collections.Generic;
using IronNinja.BuffetClass;
using IronNinja.FoodClass;
using IronNinja.IConsumableClass;
using IronNinja.NinjaClass;
using IronNinja.SpiceHoundClass;
using IronNinja.SweetToothClass;

namespace IronNinja
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Hello World!");
            Buffet buffet = new Buffet ();
            SweetTooth st = new SweetTooth ();
            st.IsFull = false;
            SpiceHound sh = new SpiceHound ();
            sh.IsFull = false;

            while (st.IsFull == false)
            {
                Random rand = new Random ();
                int randInt = rand.Next (0, buffet.Drinks.Count);
                IConsumable item = buffet.Drinks[randInt];

                st.Consume (item);
            }

            while (sh.IsFull == false)
            {
                Random rand = new Random ();
                int randInt = rand.Next (0, buffet.Drinks.Count);
                IConsumable item = buffet.Drinks[randInt];

                sh.Consume (item);
            }

            if (st.ConsumptionHistory.Count > sh.ConsumptionHistory.Count)
            {
                Console.WriteLine ("The Sweet Tooth consumed the most items!!!");
            }
            else if (st.ConsumptionHistory.Count < sh.ConsumptionHistory.Count)
            {
                Console.WriteLine ("The Spice Hound consumed the most items!!!");
            }

        }
    }
}