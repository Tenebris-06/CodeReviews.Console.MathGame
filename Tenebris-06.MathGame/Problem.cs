public class Problem
{
    public string Text;
    public int Answer;


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
}