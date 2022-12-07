using System;

namespace test {

	public class testclass{
	public static void Main(string[] args){

		string sign=args[0];
		int num1=int.Parse(args[1]);
		int num2=int.Parse(args[2]);
		if(sign=="+"){
		int add=num1+num2;
			Console.WriteLine("Additon is :"+add);	
				}
		else if(sign=="-"){
		int sub=num1-num2;
		Console.WriteLine("Subtraction is :"+sub);
		}
		else if(sign=="/"){
		int div=num1/num2;
		Console.WriteLine("Division is :"+div);
		}
		else if(sign=="*"){
		int mult=num1*num2;
		Console.WriteLine("Multiplication is :"+mult);
		}
			
			
							  }
				   }

		  }