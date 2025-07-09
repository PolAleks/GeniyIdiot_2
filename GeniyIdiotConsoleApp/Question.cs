namespace GeniyIdiotConsoleApp
{
    public class Question
    {
        public int Answer { get ; set; }
        public string Text { get ; set; }

        public Question(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }

        public override string ToString() => $"{Text}#{Answer}";
    }
}
