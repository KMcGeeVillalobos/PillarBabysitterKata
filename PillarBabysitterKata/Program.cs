using System;
using PillarBabysitterKata.Classes;

namespace PillarBabysitterKata
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, Babysitter!");
            BabysitterInterface babysitterInterface = new BabysitterInterface();
            babysitterInterface.RunInterface();
        }
    }
}

