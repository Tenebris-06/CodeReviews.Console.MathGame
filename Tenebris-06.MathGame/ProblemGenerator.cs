using Microsoft.VisualBasic;

public static class ProblemGenerator
{
    static Random randomizer = new Random();
    static int rand1;
    static int rand2;
    public static Problem generateProblem(MenuOption operatorValue)
    {
        do
        {
            rand1 = randomizer.Next(10);
            rand2 = randomizer.Next(10);
            
            if (!(operatorValue == MenuOption.Divide)) break;
            
        } while (rand1 % rand2 != 0);

        string problemText = $"{rand1} {GetOperator(operatorValue)} {rand2} = ?";
        int problemAnswer = -1;

        switch (operatorValue)
        {
            case MenuOption.Add:
                problemAnswer = rand1 + rand2;
                break;
            
            case MenuOption.Subtract:
                problemAnswer = rand1 - rand2;
                break;
            
            case MenuOption.Multiply:
                problemAnswer = rand1 * rand2;
                break;
            
            case MenuOption.Divide:
                problemAnswer = rand1 / rand1;
                break;

            default:
            break;
        }

        return new Problem(problemText, problemAnswer);

    }

    public static string GetOperator(MenuOption operatorValue)
    {
        switch (operatorValue)
        {
            case MenuOption.Add:
                return "+";
            
            case MenuOption.Subtract:
                return "-";
            
            case MenuOption.Multiply:
                return "*";
            
            case MenuOption.Divide:
                return "/";
            
            default:
            return "";
        }
    }
}