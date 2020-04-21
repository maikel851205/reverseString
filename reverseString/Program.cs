using System;

namespace reverseString
{
    class Program
    {
        static void Main()
        {
            static void ReverseString(string str)
            {
                string reverse = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverse += str[i];
                }

                Console.WriteLine(reverse);
            }


            string str = "123456";

            ReverseString(str);
            Console.ReadLine();
        }
    }
}
