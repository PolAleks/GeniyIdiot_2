namespace GeniyIdiot.Common
{
    public class User
    {
        public User(string name)
        {
            Name = name;
            CountCorrectAnswer = 0;
            Diagnosis = "неизвестно";
        }

        public User(string name, int countCorrectAnswer, string diagnosis) : this(name)
        {
            CountCorrectAnswer = countCorrectAnswer;
            Diagnosis = diagnosis;
        }

        public void AddCorrectAnswer() => CountCorrectAnswer++;
        public void AddDiagnosis(int countQuestions)
        {
            if (countQuestions == 0) return;

            var diagnosis = new string[]
            {
                "Кретин",
                "Идиот",
                "Дурак",
                "Нормальный",
                "Талант",
                "Гений"
            };

            double percentage = (double)CountCorrectAnswer / countQuestions * 100;

            Diagnosis = diagnosis[(int)percentage / 20];
        }
        public override string ToString() => $"{Name}#{CountCorrectAnswer}#{Diagnosis}";

        public string Name { get; set; }
        public int CountCorrectAnswer { get; set; }
        public string Diagnosis { get; set; }
    }
}
