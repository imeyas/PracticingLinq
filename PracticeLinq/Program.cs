using System;
using System.Linq;
using System.Collections.Generic;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Game1Seven", "Game2FortyFive", "Game3Five", "Game4Three", "Game5Fifty", "Game6Sixty", "Game7Seventy" };

            var order = list.OrderBy(x => x.Length ).ToList();

            foreach (var item in order)
            {
                Console.WriteLine(item);
            }
        }

        /*
         * (Using Method Syntax)
        Create a list of video game names..
        Order the list of games by length of the game name.
        Use the lambda expression in this exercise as well.
        */
    }
}
