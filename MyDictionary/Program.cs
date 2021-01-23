using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> ArabaMarkası = new MyDictionary<string>();
            ArabaMarkası.Add("Seat");
            ArabaMarkası.Add("Skoda");
            ArabaMarkası.Add("bmw");
        }
    }
}
