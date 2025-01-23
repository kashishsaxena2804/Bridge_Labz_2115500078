using System;
class LargestNumber{
	public static void Main(string[] args){
		//variables to take all three numbers as input 
		Console.Write("Enter the Number 1:");
		int num1 = Convert.ToInt32(Console.ReadLine());//number1
		Console.Write("Enter the Number 2:");
		int num2 = Convert.ToInt32(Console.ReadLine());//number2
		Console.Write("Enter the Number 3:");
		int num3 = Convert.ToInt32(Console.ReadLine());//number3
		
		//check which number is largest
		if (num1>num2 && num1>num3){
			Console.WriteLine("Is the first number the largest? Yes.");
			Console.WriteLine("Is the second number the largest? No.");
			Console.WriteLine("Is the third number the largest? No.");
		}
		else if (num2>num1 && num2>num3){
			Console.WriteLine("Is the first number the largest? No.");
			Console.WriteLine("Is the second number the largest? Yes.");
			Console.WriteLine("Is the third number the largest? No.");
		}
		else if(num3>num1 && num3>num2){
			Console.WriteLine("Is the first number the largest? No.");
			Console.WriteLine("Is the second number the largest? No.");
			Console.WriteLine("Is the third number the largest? Yes.");
		}
		else {
            Console.WriteLine("There is a tie or all numbers are equal.");
        }
	}
}