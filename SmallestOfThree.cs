using System;
class SmallestOfThree{
	public static void Main(string[] args){
		//variables to take all three numbers as input 
		Console.Write("Enter the Number 1:");
		int num1 = Convert.ToInt32(Console.ReadLine());//number1
		Console.Write("Enter the Number 2:");
		int num2 = Convert.ToInt32(Console.ReadLine());//number2
		Console.Write("Enter the Number 3:");
		int num3 = Convert.ToInt32(Console.ReadLine());//number3
		
		//check which number is smallest
		if (num1<num2 && num1<num3){
			Console.WriteLine("Is the first number the smallest? Yes.");
		}
		else{
			Console.WriteLine("Is the first number the smallest? No.");
		}
	}
}