using System;

namespace ParamsArray
{
    internal class Utils
    {
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Using paramter list");
            if (paramList == null)
            {
                throw new ArgumentNullException("Utils.Sum: null parameter list");
            }

            if (paramList.Length == 0)
            {
                throw new ArgumentException("Utils.Sum: empty parameter list");
            }

            int sumTotal = 0;
            foreach (int i in paramList)
            {
                sumTotal += i;
            }
            return sumTotal;
        }

        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            return param1 + param2 + param3 + param4;
        }
    }
}
