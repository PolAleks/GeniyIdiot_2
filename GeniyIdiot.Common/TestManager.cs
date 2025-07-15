using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class TestManager
    {
        List<Question> _questions;
        Question _currentQuestion;
        int _currentIndexQuestion = 0;
        User _user;

        public int NumberQuestion { get => _currentIndexQuestion; }

        public event Action<User> OnCompliteTest;
        public event Action<Question> OnNextQuestion;

        public TestManager(User user)
        {
            _user = user;
            _questions = QuestionsStorage.GetAll();            
        }

        public void Start()
        {
            OnNextQuestion?.Invoke(GetCurrentQuestion());
        }

        public bool SubmitAnswer(int userAnswer)
        {
            if (_currentQuestion.IsAnswerCorrect(userAnswer))
                _user.AddCorrectAnswer();

            if (_questions.Count > 0)
            {
                OnNextQuestion?.Invoke(GetCurrentQuestion());
                return true;
            }
            else
            {
                _user.AddDiagnosis(_currentIndexQuestion);
                OnCompliteTest?.Invoke(_user);

                UsersResultsStorage.Add(_user);
                return false;
            }
        }

        private Question GetCurrentQuestion()
        {
            if (_questions.Count != 0)
            {
                Random random = new Random();
                var curentIndex = random.Next(_questions.Count);
                _currentQuestion = _questions[curentIndex];
                _questions.RemoveAt(curentIndex);
                _currentQuestion.Number = ++_currentIndexQuestion;
                return _currentQuestion;
            }
            return null;
        }
    }
}
