using System;
using System.Collections.Generic;
using IronNinja.IConsumableClass;
using IronNinja.NinjaClass;

namespace IronNinja.SweetToothClass
{
    class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get { return IsFull; }
            set { IsFull = value; }
        }

        public override void Consume (IConsumable item)
        {
            if (calorieIntake > 1500)
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

                if (item.IsSweet)
                {
                    calorieIntake += 10;
                }

                ConsumptionHistory.Add (item);
                item.GetInfo ();
            }
            if (IsFull)
            {
                Console.WriteLine ("Sweet Tooth is full and cannot eat anymore!");
            }
        }
    }
}