public class Problem
{
    public string Text;
    public int Answer;
    public int UserAnswer;
    public bool CorrectlyAnswered;


    public Problem(string Text, int Answer)
    {
        this.Text = Text;
        this.Answer = Answer;
    }

    public void SetText(string Text)
    {
        this.Text = Text;
    }

    public void SetAnswer(int Answer)
    {
        this.Answer = Answer;
    }

    public string GetText()
    {
        return Text;
    }
    
    public int GetAnswer()
    {
        return Answer;
    }

    public void SetUserAnswer(int userAnswer)
    {
        this.UserAnswer = userAnswer;
    }

    public int GetUserAnswer()
    {
        return UserAnswer;
    }

    public override string ToString()
    {
        string AnswerState;

        switch (CorrectlyAnswered)
        {
            case true:
            AnswerState = "✔";
            break;

            case false:
            AnswerState = "✘";
            break;
        }
        return $"{Text.PadRight(12)}{UserAnswer.ToString().PadRight(12)}{Answer.ToString().PadRight(12)}{AnswerState.PadLeft(10)}";
    }
}