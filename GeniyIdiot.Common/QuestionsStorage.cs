using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        private static string _file = "question.json";

        public static List<Question> GetAll()
        {
            var questions = new List<Question>();

            if (FileProvider.Exists(_file))
            {
                var content = FileProvider.Load(_file);
                questions = JsonConvert.DeserializeObject<List<Question>>(content);

                if (questions.Count == 0)
                    questions = InitialQuestions();
            }
            else
            {
                questions = InitialQuestions();
            }
            return questions;
        }

        public static void Add(Question question)
        {
            var questions = GetAll();
            questions.Add(question);
            Save(questions);
        }

        public static void Delete(Question question)
        {
            if (question == null)
                return;

            var questions = GetAll();
            if (questions.Remove(question))
            {
                Save(questions);
            }
        }

        static List<Question> InitialQuestions()
        {
            var questions = new List<Question>
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6, Guid.NewGuid()),
                new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9, Guid.NewGuid()),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25, Guid.NewGuid()),
                new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60, Guid.NewGuid()),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2, Guid.NewGuid())
            };

            Save(questions);
            return questions;
        }

        public static void Save(List<Question> questions)
        {
            var content = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Save(_file, content, false);
        }

        public static void Update(Question question)
        {
            var questions = GetAll();
            var updateQuestion = questions.FirstOrDefault(q => q.Id.Equals(question.Id));

            updateQuestion.Text = question.Text;
            updateQuestion.Answer = question.Answer;

            Save(questions);
        }
    }
}
