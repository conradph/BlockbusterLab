using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int Runtime, List<string> Scenes) : base(Title, Category, Runtime, Scenes)
        {

        }
        public override void Play()
        {
            
            Console.WriteLine($"Which scene of the DVD {Title} would you like to watch? Select 0 to {Scenes.Count - 1}");
            string input = Console.ReadLine();
            string scene;
            int response;
            while (true)
            {
                try
                {
                    response = int.Parse(input);
                    scene = Scenes[response];
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer");
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Please enter an integer between 0 and {Scenes.Count - 1}");
                    continue;
                }
            }
            Console.WriteLine($"Scene {response}: {scene}");

        }
        public void PlayWholeMovie()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }
    }
}
