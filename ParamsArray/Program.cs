using System;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Utils.Sum(null));
            //Console.WriteLine(Utils.Sum());
            Console.WriteLine(Utils.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));

            //Given a choice between
            //a method that takes optional parameters and
            //a method that takes a parameter list,
            //the C# compiler uses the method that takes optional parameters.
            Console.WriteLine(Utils.Sum(2, 4, 6, 8));
            Console.WriteLine(Utils.Sum(2, 4, 6));

            //more arguments are provided than the method that takes
            //optional parameters specifies, so the compiler generated code that calls
            //the method that takes a parameter array.
            Console.WriteLine(Utils.Sum(2, 4, 6, 8, 10));

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
