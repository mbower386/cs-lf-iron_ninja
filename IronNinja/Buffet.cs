using System;
using System.Collections.Generic;
using IronNinja.FoodClass;
using IronNinja.IConsumableClass;

namespace IronNinja.BuffetClass
{
  class Buffet
  {
    public List<Food> Menu;
    public List<IConsumable> Drinks;

    //constructor
    public Buffet ()
    {
      Menu = new List<Food> ()
      {
        new Food ("Pizza", 300, false, false),
        new Food ("Cheeseburger", 500, false, false),
        new Food ("Burrito", 700, true, false),
        new Food ("Orange Chicken", 400, true, true),
        new Food ("Cesar Salad", 200, false, false),
        new Food ("Korean Fried Chicken", 500, true, false),
        new Food ("Black Forest Cake", 300, false, true)
      };

      Drinks = new List<IConsumable> ()
      {
        new Food ("Coke", 140, false, false),
        new Food ("Corona Light", 80, false, false),
        new Food ("Whiskey Ember", 200, true, false),
        new Food ("Sangria", 300, false, true),
        new Food ("Tequila Manhattan", 300, true, true)
      };
    }

    public Food Serve (List<Food> Menu)
    {
      Random rand = new Random ();
      int randNum = rand.Next (0, Menu.Count);

      return Menu[randNum];
    }
  }

}