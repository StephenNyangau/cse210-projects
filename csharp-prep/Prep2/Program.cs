using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, what's your percentage please?");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine("Your grade is: " + letter);

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course");
        }
        else
        {
            Console.WriteLine("Don't worry, I can see you have a potential to improve. Keep trying!");
        }

    }
}