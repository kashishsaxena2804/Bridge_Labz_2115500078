using System;
class PenDistribution{
	public static void Main(string[] args){
		
		//total number of pens
		int totalpen = 14;
		//Number of students
		int students = 3;
		
		//remaining pens
		int remaining = totalpen % students;
		//number of pens per student
		int perstudent= totalpen / students;
		
		//print the result distribution
		Console.WriteLine("The Pen Per Student is " + perstudent + " and the remaining pen not distributed is " + remaining);
		
	}
}