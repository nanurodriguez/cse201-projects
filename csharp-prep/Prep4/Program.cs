using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        List<int> listNumbers = new List<int>();
        Console.WriteLine("Hello There! Please enter a list of numbers, type 0 when you are done.");
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number:");
            string userInput = Console.ReadLine();
            int inputNumber = int.Parse(userInput);
            if (inputNumber != 0)
            {
                listNumbers.Add(inputNumber);
            }
            else if (inputNumber == 0)
            {
                userNumber = 0;
            }
        }
        //Now let's get the summary of those numbers that the user input.
        int sum = 0; //Declaring the variable here to call it later.

        foreach (int n in listNumbers)//foreach loop is the best way to go through a list and get their values.
        {
            sum += n; // sum of the numbers inside the list
        }
        Console.WriteLine($"The sum of those numbers you added is: {sum}");

        /*Let's compute the average!*/

        float average = ((float)sum) / listNumbers.Count;
        Console.WriteLine($"The Average of those numbers you added is: {average}");

        /*Find maximum using the built in function .Max() which finds the largest value in list*/
        Console.WriteLine($"The Maximum of those numbers you added is: {listNumbers.Max()}");
    }

}