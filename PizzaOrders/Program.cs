//Pizza Orders – Joe’s Pizza Palace needs a program to calculate the number of slices a pizza of any size can be divided into.
//The program should also report the number of pizzas someone should order for a party.Assume each person at the party will eat 3 slices each.
//The program should prompt the user for the diameter of the pizzas they wish to order and the number of people who will be at the party.
//The program should then calculate and display the number of slices per pizza and the number of pizzas needed for the party. 


//A slice must have an area of 14.125 inches
//Number of slices per pizza is the area of the pizza divided by the area of a slice
//Area of a pizza is calculated with Area = PI * r2 where PI = 3.14159 and r is the radius of the pizza
//The number of slices should be fixed point and rounded to one decimal place
//PI must be a named constant


//#DONE calculate the number of slices a pizza of any size can be divided into
//#TODO report the number of pizzas someone should order for a party. Assume each person at the party will eat 3 slices each
//#DONE prompt the user for the diameter of the pizzas
//#DONE prompt the number of people who will be at the party
//#TODO calculate and display the number of slices per pizza
//#TODO calculate and display the number of pizzas needed for the party

using System;

namespace PizzaOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            const double PI = Math.PI;
            const double sliceArea = 14.125;

            //inputs
            Console.Write("How large would you like your pizza? ");
            var Diameter = Console.ReadLine();
            Console.Write("How many people will you need fed? ");
            var people = Console.ReadLine();

            //outlining the area of the pizza and the radius
            var radius = Convert.ToDouble(Diameter) / 2;
            var area = PI * radius * radius;
            //There is no power in c# apparently..

            var slicePerPizza = area / sliceArea;
            Console.WriteLine(slicePerPizza + " = Slice per pizza");
            var slicesNeeded = Convert.ToDouble(people) * 3;
            var pizzaNeeded = slicesNeeded / slicePerPizza;

            //Output

            Console.WriteLine("You will need " + slicesNeeded + " slices of pizza for your party, if you get a " + Diameter + " inch pizza and have " + people + " people attending.");

            Console.WriteLine("You will need " + Math.Ceiling(pizzaNeeded) + " pizzas for your party, if you get a " + Diameter + " Inch pizza and have " + people + " people attending.");

            

            


        }
    }
}
