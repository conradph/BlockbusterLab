using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; } 
        public int RunTime { get; set; }
        public List<string> Scenes = new List<string>();
        public Movie(string Title, Genre Category, int Runtime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = Runtime;
            this.Scenes = Scenes;
        }

        public override string ToString()
        {
            string output = $"Title: {Title}\n" +
                $"Category: {Category}\n" +
                $"Runtime: {RunTime}";
            return output;
        }
        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
        }
        public virtual void Play()
        {

        }

    }
}
