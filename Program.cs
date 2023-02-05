using System;

public class Program
    {
        static void Main(string[] args)
        {
        int choice;
            Console.WriteLine("Welcome to our game guess the number 1-10 and win a prize");
            int y = new Random().Next(1, 11);
            choice = int.Parse(Console.ReadLine());

        while (choice !=y)
        {
            Console.WriteLine("Try again");
            choice = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You win");
    }
  }
