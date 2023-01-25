using System;

namespace Program
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Skriv en addition ( tex 1+1 ) : ");
            string addition = Convert.ToString(Console.ReadLine());
            int index = addition.IndexOf("+");

            string tal1 = addition[..index];
            string tal2 = addition[(index+1)..];

            int tal11=Convert.ToInt32(tal1);
            int tal22=Convert.ToInt32(tal2);    

            Console.WriteLine(tal11 + " + " + tal22 + " = " + (tal11+tal22));

        }

    }

}