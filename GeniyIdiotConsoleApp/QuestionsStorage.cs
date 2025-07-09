﻿using System.Collections.Generic;

namespace GeniyIdiotConsoleApp
{
    public class QuestionsStorage
    {
        private static List<Question> _questions = new List<Question>();
        public static List<Question> GetAll()
        {
            InitialQuestions();
            return _questions;
        }

        private static void InitialQuestions()
        {
            _questions = new List<Question>
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2),
            };
        }
    }
}
