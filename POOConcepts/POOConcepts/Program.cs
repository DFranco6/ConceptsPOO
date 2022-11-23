using System;

namespace POOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POO Concepts");
            Console.WriteLine("============");
            
            Date date1 = new Date(2022, 2, 11);
            Console.WriteLine(date1);

            try
            {
                Console.WriteLine(new Date(2022, 2, 29));
                Console.WriteLine(new Date(1974, 9, 23));
                Console.WriteLine(new Date(1985, 11, 45));
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }

        }
    }
}
