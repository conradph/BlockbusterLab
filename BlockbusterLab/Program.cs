using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster store = new Blockbuster();
            store.StoreFunction();
        }
    }
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
}
