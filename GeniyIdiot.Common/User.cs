namespace GeniyIdiot.Common
{
    public class User
    {
        public User() { }
        public User(string name) => Name = name;

        public string Name { get; set; }
        public int CountCorrectAnswer { get; set; }
        public string Diagnosis { get; set; }


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
    }
}
