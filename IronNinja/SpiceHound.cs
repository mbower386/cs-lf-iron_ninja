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
            get { return IsFull; }
            set { IsFull = value; }
        }

        public override void Consume (IConsumable item)
        {

            if (calorieIntake > 1200)
            {
                IsFull = true;
            }
            else
            {
                IsFull = false;
            }
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