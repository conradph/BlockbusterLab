using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>();
        public Blockbuster()
        {
            List<string> scenes = new List<string>() { "First Scene", "Second Scene", "Third Scene", "Fourth Scene" };
            Movies.Add(new DVD("Shawshank Redemption", Genre.Drama, 115, scenes));
            Movies.Add(new DVD("The Shining", Genre.Horror, 105, scenes));
            Movies.Add(new DVD("The Dark Knight", Genre.Action, 132, scenes));
            Movies.Add(new VHS("Love Actually", Genre.Romance, 98, scenes));
            Movies.Add(new VHS("Happy Gilmore", Genre.Comedy, 106, scenes));
            Movies.Add(new VHS("Pulp Fiction", Genre.Drama, 115, scenes));
            Movies = Movies.OrderBy(x => x.Title).ToList();
        }
        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i+1}) {Movies[i].Title}");
            }
        }
        public void StoreFunction()
        {
            Console.WriteLine("Welcome to GC Blockbuster");
            Movie mov = CheckOut();
            PlayMovie(mov);
            Console.WriteLine();
            Console.WriteLine("Goodbye");

        }
        public Movie CheckOut()
        {
            Console.WriteLine("Welcome to GC Blockbuster");
            PrintMovies();
            string response = "";
            int index = 0;
            Movie mov = null;
            while (true)
            {
                try
                {
                    response = GetInput("Please select a movie you would like to watch:");
                    index = int.Parse(response);
                    mov = Movies[index-1];
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer");
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Please enter an integer between 0 and {Movies.Count}");
                    continue;
                }
            }
            return mov;

        }
        public void PlayMovie(Movie mov)
        {
            Console.WriteLine(mov);
            Console.WriteLine();
            bool watch = GetYesOrNo("Would you like to watch the movie (y/n)");
            while (watch)
            {
                mov.Play();
                watch = GetYesOrNo("Would you like to watch another scene (y/n)");
            }
 
        }
        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public bool GetYesOrNo(string prompt)
        {
            while (true)
            {
                string resp = GetInput(prompt);
                if (resp.ToLower() == "y")
                {
                    return true;
                }
                else if (resp.ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter only a y or an n");
                    continue;
                }
            }

        }
    }
}
