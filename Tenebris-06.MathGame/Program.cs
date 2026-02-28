using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t====== Math Game ======\nPick an Option:");
        Console.WriteLine("[1] Addition \n[2] Subtraction \n[3] Multiplication \n[4] Division");

        int userChoice;
        if (int.TryParse(Console.ReadLine(), out userChoice))
        {
            
        } else
        {
            Console.WriteLine("Invalid Input!");
        }

        for (int i = 0; i <= 4; i++)
        {
            // cast the userChoice to it's corresponding enum option

            Problem generatedProblem = ProblemGenerator.generateProblem((MenuOption)userChoice);
            Console.WriteLine($"\t == Problem {i}: ==");
            Console.WriteLine($"{generatedProblem.Text}");
            Console.Write("=>");
            int.TryParse(Console.ReadLine(), out int userAnswer);
            
            if (userAnswer == generatedProblem.Answer)
            {
                Console.WriteLine("Correct!");
            }
        }

    }
}