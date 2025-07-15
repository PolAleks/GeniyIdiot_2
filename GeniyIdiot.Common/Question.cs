namespace GeniyIdiot.Common
{
    public class Question
    {
        public string Text { get ; set; }
        public int Answer { get ; set; }
        public int Number { get; set; } = 0;

        public Question() { }
        public Question(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }
        public bool IsAnswerCorrect(int answer) => Answer == answer;        
    }
}
