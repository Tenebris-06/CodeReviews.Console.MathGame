using System.Net;

class Program
{
    static void Main(string[] args)
    {

        List<Game> gameHistory = new List<Game>();

        while (true) {

        Console.WriteLine("\t====== Math Game ======\nPick an Option:");
        Console.WriteLine("[1] Addition \n[2] Subtraction \n[3] Multiplication \n[4] Division \n[5] History \n[0] Exit");
        Console.Write("=> ");

        int userChoice;
        if (int.TryParse(Console.ReadLine(), out userChoice))
        {
            
        } else
        {
            Console.WriteLine("Invalid Input!");
        }

        if ((MenuOption)userChoice == MenuOption.History)
            {
                Console.WriteLine("\t=== Game History ===");
                
                for (int i = 0; i <= gameHistory.Count - 1; i++)
                {
                    Console.WriteLine($"\n[Game {i + 1}] (Score: {gameHistory[i].score})");
                    Console.WriteLine($"{"Problem".PadRight(12)}{"Your Answer".PadRight(12)}{"Correct Answer".PadRight(12)}{"Status".PadLeft(10)}");
                    foreach (Problem p in gameHistory[i].problemSet)
                    {
                        Console.WriteLine(p.ToString());
                    }
                }
                
                Console.WriteLine("Press any key to go back to main menu => ");
                Console.ReadKey();
                continue;

            } else if ((MenuOption)userChoice == MenuOption.Exit)
            {
                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            }
        
        int score = 0;
        List<Problem> ProblemSet = new List<Problem>();

        for (int i = 0; i <= 4; i++)
        {
            // cast the userChoice to it's corresponding enum option

            Problem generatedProblem = ProblemGenerator.GenerateProblem((MenuOption)userChoice);
            ProblemSet.Add(generatedProblem);
            Console.WriteLine($"\t == Problem {i}: ==");
            Console.WriteLine($"{generatedProblem.Text}");
            Console.Write("=> ");
            int.TryParse(Console.ReadLine(), out int userAnswer);

            generatedProblem.SetUserAnswer(userAnswer);
            
            if (userAnswer == generatedProblem.Answer)
            {
                Console.WriteLine("Correct!");
                generatedProblem.CorrectlyAnswered = true;
                score++;
            } else
                {
                    Console.WriteLine("Wrong!");
                    generatedProblem.CorrectlyAnswered = false;
                }
        }

        Game currentGame = new Game(score, ProblemSet);
        gameHistory.Add(currentGame);

    }
}
}
