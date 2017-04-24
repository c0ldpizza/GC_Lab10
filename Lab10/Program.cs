using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize list of movies
            List<Movies> MovieList = new List<Movies>();

            MovieList.Add(new Movies("Princess Mononoke","Animated"));
            MovieList.Add(new Movies("RWBY", "Animated"));
            MovieList.Add(new Movies("Spirited Away", "Animated"));
            MovieList.Add(new Movies("Hacksaw Ridge", "Drama"));
            MovieList.Add(new Movies("Good Will Hunting", "Drama"));
            MovieList.Add(new Movies("Fight Club", "Animated"));
            MovieList.Add(new Movies("Alfred Hitchcock's Birds", "Horror"));
            MovieList.Add(new Movies("The Matrix", "Sci-Fi"));
            MovieList.Add(new Movies("Guardians of the Galaxy", "Sci-Fi"));
            MovieList.Add(new Movies("Serenity", "Sci-Fi"));
            
            do
            {
                Console.WriteLine("Which category would you like to display movies from?");
                Console.WriteLine("Options:");
                Console.WriteLine("1: Animated");
                Console.WriteLine("2: Drama");
                Console.WriteLine("3: Horror");
                Console.WriteLine("4: Sci-Fi");

                int choice = Validation.GetNumberInRange(1, 4);
                Console.Clear();




            } while (Validation.Continue());
        }
    }
}
