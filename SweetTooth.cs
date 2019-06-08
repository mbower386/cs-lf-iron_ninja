using System;
using IronNinja.NinjaClass;

namespace IronNinja.SweetToothClass
{
    class SweetTooth : Ninja
    {
        public override bool IsFull ()
        {
            if (calorieIntake > 1500)
            {
                IsFull = true;
            }
            else
            {
                IsFull = false;
            }

            return IsFull;
        }

        public override void Consume (IronNinja.IConsumable item)
        {
            if (!IsFull)
            {
                calorieIntake += item.calories;

                if (IsSweet)
                {
                    calorieIntake += 10;
                }

                ConsumptionHistory.add (item);
                GetInfo ();
            }
            if (IsFull)
            {
                Console.WriteLine ("Sweet Tooth is full and cannot eat anymore!");
            }
        }
    }
}