using System;
class VotingEligibility{
	public static void Main(string[] args){
		//take the user's age as input
		Console.Write("Enter your age : ");
		string input = Console.ReadLine();
		bool isNumeric = int.TryParse(input, out int age);
		
		//check the valid input
		if (isNumeric && age>=0){
			//check the eligibility of person to vote
			if (age>=18){
				Console.WriteLine($"The person's age is {age} and can vote.");
			}
			else{
				Console.WriteLine($"The person's age is {age} and cannot vote.");
			}
		}
		else{
			Console.WriteLine("Invalid input. Please enter a valid age.");
		}
	}
}