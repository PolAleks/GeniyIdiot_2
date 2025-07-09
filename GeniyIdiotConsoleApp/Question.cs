namespace GeniyIdiotConsoleApp
{
    public class Question
    {
        string _text;
        int _answer;

        public Question(string text, int answer)
        {
            _text = text;
            _answer = answer;
        }

        public override string ToString() => $"{_text}#{_answer}";
    }
}
