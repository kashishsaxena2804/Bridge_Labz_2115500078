using System;
class NaturalNumber{
	public static void Main(string[] args){
		//variable to take the user input
		Console.Write("Enter a Number: ");
		int number;
		if (int.TryParse(Console.ReadLine(), out number)) {
            // Check if the number is a natural number (non-negative integer)
            if (number >= 0) {
                // Calculate the sum of the first n natural numbers
                int sum = number * (number + 1) / 2;
                
                // Display the results
                Console.WriteLine($"The number {number} is a natural number.");
                Console.WriteLine($"The sum of the first {number} natural numbers is: {sum}");
            } else {
                Console.WriteLine("The number is not a natural number (it must be a non-negative integer).");
            }
        } else {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
			
		
	}
}