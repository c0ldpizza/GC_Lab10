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

            MovieList.Add(new Movies("Princess Mononoke", "Animated"));
            MovieList.Add(new Movies("RWBY", "Animated"));
            MovieList.Add(new Movies("Spirited Away", "Animated"));
            MovieList.Add(new Movies("Hacksaw Ridge", "Drama"));
            MovieList.Add(new Movies("Good Will Hunting", "Drama"));
            MovieList.Add(new Movies("Fight Club", "Drama"));
            MovieList.Add(new Movies("Alfred Hitchcock's Birds", "Horror"));
            MovieList.Add(new Movies("The Matrix", "Sci-Fi"));
            MovieList.Add(new Movies("Guardians of the Galaxy", "Sci-Fi"));
            MovieList.Add(new Movies("Serenity", "Sci-Fi"));

            bool add = true;
            do
            {
                Console.WriteLine("Would you like to add a movie to the list? (y/n)");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    Console.Write("Enter the new movie title:");
                    string newTitle = Console.ReadLine();
                    Console.Write("Categories:Animated, Drama, Horror, Sci-Fi, Other");
                    Console.Write("Enter the new movie category:");
                    string newCategory = Console.ReadLine();
                    MovieList.Add(new Movies(newTitle, newCategory));
                }
                else if (input == "n")
                {
                    add = false;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            } while (add);

            do
            {
                Console.WriteLine("Which category would you like to display movies from?");
                Console.WriteLine("Options:");
                Console.WriteLine("1: Animated");
                Console.WriteLine("2: Drama");
                Console.WriteLine("3: Horror");
                Console.WriteLine("4: Sci-Fi");
                Console.WriteLine("5: Other");
                Console.WriteLine("0: All");

                int choice = Validation.GetNumberInRange(0, 4);
                Console.Clear();
                IEnumerable<Movies> orderedByTitle = MovieList.OrderBy(p => p.Title);

                foreach (Movies item in orderedByTitle)
                {
                    switch (choice)
                    {
                        case 1:
                            if (item.Category == "Animated")
                                Console.WriteLine($"{item.Title}");
                            break;

                        case 2:
                            if (item.Category == "Drama")
                                Console.WriteLine($"{item.Title}");
                            break;

                        case 3:
                            if (item.Category == "Horror")
                                Console.WriteLine($"{item.Title}");
                            break;

                        case 4:
                            if (item.Category == "Sci-Fi")
                                Console.WriteLine($"{item.Title}");
                            break;
                        case 5:
                            if (item.Category == "Other")
                                Console.WriteLine($"{item.Title}");
                            break;

                        default:
                            Console.WriteLine($"{item.Title}, {item.Category}");
                            break;
                    }
                }

            } while (Validation.Continue());
        }
    }
}
