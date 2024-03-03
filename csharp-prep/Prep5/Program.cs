using System;

class Program
{
    static void Main(string[] args)
    {
        DisaplayMessage();
        string userName = PromptUserName();
        int userNUmber = PromptUserNumber();
        int squaredNumber = squareNumber(userNUmber);
        DisplayResult(userName, squaredNumber);
    }    
    
    static void DisaplayMessage()
        {
             Console.WriteLine("Welcome to the program!");
        }
    static string PromptUserName()
    {
         Console.Write("What is your name? ");
         string name =  Console.ReadLine();
         return name;

    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
         
}