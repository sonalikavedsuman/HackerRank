using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
    public Student(string firstName, string lastName, int id,int[] scores){
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
        this.testScores = scores;
        
    }
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public char Calculate()
    {
        int average = testScores.Sum()/testScores.Length;
        if(average < 40)
        {
            return 'T';
        }
        else if(average >= 40 && average < 55)
        {
            return 'D';
        }
        else if(average >= 55 && average < 70)
        {
            return 'P';
        }
        else if(average >= 70 && average < 80)
        {
            return 'A';
        }
        else if(average >= 80 && average < 90)
        {
            return 'E';
        }
        else
        {
           return 'O';
        }
    }
} 

class Solution {