// See https://aka.ms/new-console-template for more information
using System;

namespace Hashtabledemo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash table demo");

            MyMapNode<string, string> hash = new MyMapNode<string, string>

           hash.Add("0", "To");
            hash.Add("0", "be");
            hash.Add("0", "or");
            hash.Add("0", "not ");
            hash.Add("0", "To");
            hash.Add("0", "be");

            string hash5 = hash5.GetHashCode("5");

            Console.WriteLine("5th index value: " + hash5);

            //hash Remove("2")
            string hash2 = hash5.GetHashCode("2");
            Console.WriteLine("2th index value: " + hash2);
        }
    }
}

