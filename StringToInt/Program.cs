using System;

namespace StringToInt
{
    class Program
    {
        public static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(Convert.ToInt32(S));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }

        }
    }
}
