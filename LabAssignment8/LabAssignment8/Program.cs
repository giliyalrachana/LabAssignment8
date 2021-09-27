using System;

namespace LabAssignment8
{
    // Multicast delegate
    class Program
    {
        // To declare delegate

        public delegate void DelMulti(int firstNum, int secondNum);
        // Methods to work with delegates
        public void Add(int firstNum, int secondNum)
        {
            Console.WriteLine($"The sum of two numbers is :{firstNum+secondNum}");
        }
        public void Sub(int firstNum, int secondNum)
        {
            Console.WriteLine($"The result of two numbers is :{firstNum - secondNum}");
        }
        public void Mul(int firstNum, int secondNum)
        {
            Console.WriteLine($"The product of two numbers is :{firstNum * secondNum}");
        }
        public void Div(int firstNum, int secondNum)
        {
            Console.WriteLine($"The result of two numbers is :{firstNum / secondNum}");
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            // To set function reference to delegate
            DelMulti delMulti = new DelMulti(program.Add);
            delMulti += program.Sub;
            delMulti += program.Mul;
            delMulti += program.Div;

            // To invoke delegate
            delMulti(200, 50);


            Console.ReadLine();
        }
    }
}
