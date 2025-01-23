using System;
class PositiveNegative{
	public static void Main(string[] args){
		
		//take the user input
		Console.Write("Enter the Number : ");
		string input = Console.ReadLine();
		bool isNumeric = int.TryParse(input, out int number);
		
		//check the number is positive, negative or zero
		if (isNumeric) {
            // Determine if the number is positive, negative, or zero
            if (number > 0) {
                Console.WriteLine("The number is positive.");
            } else if (number < 0) {
                Console.WriteLine("The number is negative.");
            } else {
                Console.WriteLine("The number is zero.");
            }
        } else {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
	}
	
}