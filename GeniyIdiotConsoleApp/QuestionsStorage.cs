using System;
using System.Collections.Generic;
using System.Text;

namespace GeniyIdiotConsoleApp
{
    public class QuestionsStorage
    {
        private static string _file = "question.txt";

        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            if (FileProvider.Exists(_file))
            {
                var lines = FileProvider.Load(_file);
                foreach (var line in lines)
                {
                    var item = line.Split(new char[]{ '#' }, StringSplitOptions.RemoveEmptyEntries);
                    (string text, int answer) = (item[0], Convert.ToInt32(item[1]));
                    questions.Add(new Question(text, answer));
                }
            }
            else
            {
                InitialQuestions();
            }
            return questions;
        }

        internal static void Add(Question question)
        {
            FileProvider.Save(_file, question.ToString());
        }

        internal static void Delete(Question question)
        {
            FileProvider.Delete(_file, question.ToString());
        }

        private static void InitialQuestions()
        {
            var questions = new List<Question>
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
            };

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in questions)
            {
                stringBuilder.AppendLine(item.ToString());
            }
            
            FileProvider.Save(_file, stringBuilder.ToString().Trim());
        }
    }
}
