using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Genre Category, int Runtime, List<string> Scenes) : base(Title, Category, Runtime, Scenes)
        {
            this.CurrentTime = 0;
        }
        public override void Play()
        {
            string scene;
            while (true)
            {
                try
                {
                    scene = Scenes[CurrentTime];
                    CurrentTime += 1;
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Rewind();
                    continue;
                }
            }
            Console.WriteLine($"Scene {CurrentTime}: {scene}");

        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
        public void PlayWholeMovie()
        {
            Rewind();
            for (int i = 0; i < Scenes.Count; i++)
            {
                Play();
            }
        }
    }
}
