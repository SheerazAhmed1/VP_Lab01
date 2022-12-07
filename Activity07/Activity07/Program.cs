using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;



namespace Activity07
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            MathClass.Calc();








            /*
            string input1, input2;
            int num1, num2;

            Console.WriteLine("Enter the Dividened");
            input1 = Console.ReadLine();

            Console.WriteLine("Enter the Divisor");
            input2 = Console.ReadLine();

            num1 = int.Parse(input1);
            num2 = int.Parse(input2);

            DivideWithoutOperator(num1, num2);*/
        }

        static void DivideWithoutOperator(int dividend,int divisor)
        {
            int iterator = 0;
            
            while (dividend>divisor)
            {
                dividend -= divisor;
                iterator++;
            }
            Console.WriteLine("The Result of Division is " +iterator+" and Remainder is "+dividend);
        }
    }
}