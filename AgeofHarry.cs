using System;
class AgeofHarry{
	public static void Main(string[] args){
		
		//create a variable for Harry's birth year
		int birthyear= 2000;
		// create a variable for the cutrent year
		int curryear=2024;
		
		//compute Harry's age
		int age= curryear-birthyear;
		//print Harry's age
		 Console.WriteLine("Harry's age in " + curryear +" is "+age);
	}
}