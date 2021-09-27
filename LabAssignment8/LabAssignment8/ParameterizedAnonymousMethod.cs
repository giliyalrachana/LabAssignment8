using System;


namespace LabAssignment8
{
    // This program demo. parameterized anonymous method to print whether given parameter value is even or odd
    class ParameterizedAnonymousMethod
    {
        public delegate void Print(int value);
        static void Main()
        {
            Print printDel = delegate (int value)
            if (value % 2 == 0) 
            {
                Console.WriteLine($"Anonymous method value is even:{value}");
            };
            else
            {
                Console.WriteLine($"Anonymous method value is odd:{value}");

            };
            printDel(100);
            Console.ReadLine();


        }
    }
}
