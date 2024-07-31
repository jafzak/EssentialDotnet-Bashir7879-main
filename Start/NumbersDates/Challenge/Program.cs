//1. Prompt the user to enter a date or type "exit" to quit the program.
//2. Parse the entered date and check if it is valid.
//3. Compare the entered date with the current date to determine if it is in the past, present,
//or future.
//4. Display the appropriate message based on the comparison.
//5. Handle invalid date inputs gracefully by showing an error message.
//6. The program should loop until the user decides to exit.

using System;

class DateComparison
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a date (YYYY-MM-DD) or 'exit' to quit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            DateTime enteredDate;
            if (DateTime.TryParseEexact(userInput, out enteredDate))
            {
                DateTime today = DateTime.Now;
                int comparison = DateTime.Compare(enteredDate, today);
                
                {
                    Console.WriteLine($"The entered date is  in the past.");
                }
                else if (dayDifference == 0)
                {
                    Console.WriteLine("The entered date  is today.");
                }
                else
                {
                    Console.WriteLine("The entered date is in the future.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter YYYY-MM-DD.");
            }
        }
    }
}
    