using System;
using System.Collections.Generic;
namespace Hungry_ninja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy; 
        public bool IsSweet; 
        
        public Food( string name , int calories, bool spicy , bool sweet)
        {
            this.Name = name;
            this.Calories = calories;
            this.IsSpicy = spicy;
            this.IsSweet = sweet;
        }
    }
    class Buffet
    {
        public List<Food> Menu;
     
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Chicken", 100000, true, false),
                new Food("Peas", 1010,false,false),
                new Food ("Franks", 200, true, true),
                new Food ("Bread", 10, false,true),
                new Food ("Durian", 100, false, true),
                new Food ("Ice", 0, false,false),
                new Food("Crocodile", 250,true, false)
            };
        }
     
        public Food Serve()
        {
            Random random = new Random();
            return  Menu[random.Next(0,Menu.Count)];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public bool IsFull;
        public  Ninja()
        {
            FoodHistory = new List<Food>();
        }
        public int CalorieIntake
        {
            get {return calorieIntake;}
        }
        public void calorieintake()
        {
            calorieIntake = 0;
        }
        public bool isFull
        {
            get
            {
                bool IsFull= false; 
                if (calorieIntake> 1200)
                {
                    IsFull = true;
                };
                return IsFull;
            }
        }
        public void Eat(Food item)
        {
            if (IsFull== false)
            {

                calorieIntake+= item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"This food is {item.Name}. Is it spicy? {item.IsSpicy}. Is it sweet? {item.IsSweet}");
            }
            if(IsFull ==true)
            {
                Console.WriteLine($"Ninja is full please stop feeding him this is abuse at this point");
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Buffet AllTheFood = new Buffet();
            Ninja Terry = new Ninja();
            for(int i = 1; i<6; i++)
            {
                Terry.Eat(AllTheFood.Serve());
            }
        }
    }
}
