using System;
using System.Collections.Generic;
using IronNinja.IConsumableClass;
using IronNinja.NinjaClass;

namespace IronNinja.SpiceHoundClass
{
    class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get { return calorieIntake > 1200; }
        }

        public override void Consume (IConsumable item)
        {

            if (!IsFull)
            {
                calorieIntake += item.Calories;

                if (item.IsSpicy)
                {
                    calorieIntake -= 5;
                }

                ConsumptionHistory.Add (item);
                item.GetInfo ();
            }
            if (IsFull)
            {
                Console.WriteLine ("Spice Hound is full and cannot eat anymore!");
            }
        }
    }
}