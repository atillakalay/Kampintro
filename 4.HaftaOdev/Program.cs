using System;

namespace _4.HaftaOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enlish to Tuskish dictionary");
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("One", "Bir");
            myDictionary.Add("Two", "İki");
            myDictionary.Add("Three", "Üç");
            myDictionary.Add("Four", "Dört");
            myDictionary.Add("Five", "Beş");
    

            myDictionary.Read();
        }
    }
}
