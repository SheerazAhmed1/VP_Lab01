namespace Activity06
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string input1, input2,opt;
        
            Console.WriteLine("Enter First Input ");
            input1 = Console.ReadLine();
            
            Console.WriteLine("Enter Second Input ");
            input2 = Console.ReadLine();

        label1:

            Console.WriteLine("Enter  The Operation You Want To Perform ");
            opt = Console.ReadLine();

            int num1=int.Parse(input1);
            int num2=int.Parse(input2);
            int result;

          
            switch (opt)
            {
                case "+":
                    result = num1+num2;
                    Console.WriteLine("Addition of "+num1+" and "+num2+" is "+result);
                    break;
               case "-":
                    result = num1 - num2;
                    Console.WriteLine("Subtraction of " + num1 + " and " + num2 + " is " + result);
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Mltiplication of " + num1 + " and " + num2 + " is " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Division of " + num1 + " and " + num2 + " is " + result);
                    break;

                    default:
                    Console.WriteLine("Wrong Operation Pleas try again");
                         goto label1;
                    
            }
        }
    }
}