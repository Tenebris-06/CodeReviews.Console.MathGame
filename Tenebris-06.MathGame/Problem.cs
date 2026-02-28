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

    public void setText(string Text)
    {
        this.Text = Text;
    }

    public void setAnswer(int Answer)
    {
        this.Answer = Answer;
    }

    public string getText()
    {
        return Text;
    }
    
    public int getAnswer()
    {
        return Answer;
    }

    public void setUserAnswer(int userAnswer)
    {
        this.UserAnswer = userAnswer;
    }

    public int getUserAnswer()
    {
        return UserAnswer;
    }

    public string ToString()
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
        return $"{Text.PadRight(12)}{UserAnswer.ToString().PadRight(12)}{Answer.ToString().PadRight(12)}{AnswerState.ToString().PadLeft(10)}";
    }
}