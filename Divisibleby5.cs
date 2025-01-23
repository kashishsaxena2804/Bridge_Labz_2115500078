using System;
class Divisibleby5{
	// public static void Main(string[] args){
		
		//variabl to take the input value
		Console.Write("Enter the Value:-");
		int number=Convert.ToInt32(Console.ReadLine());
		
		//Check if number is divisible by 5 or not and display the result
		if (number%5==0){
			Console.WriteLine($"is the number {number} divivible by 5? Yes");
		}
		else{
			Console.WriteLine($"is the number {number} divivible by 5? No");
		}
	}
}
