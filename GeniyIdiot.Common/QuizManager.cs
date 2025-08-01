﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GeniyIdiot.Common
{
    public class QuizManager
    {
        private List<Question> _questions;
        private Question _currentQuestion;
        private int _indexCurrentQuestion = 0;

        private User _user;

        private Timer _timer;
        private int _timeLeft;

        public event Action<Question> OnNextQuestion;
        public event Action<User> OnQuizComplite;
        public event Action<int> OnTimeUpdate;

        public QuizManager(User user)
        {
            _user = user;
            _questions = QuestionsStorage.GetAll();
        }

        public void Start()
        {
            OnNextQuestion?.Invoke(GetQuestion());
        }

        public bool Submit(int answer)
        {
            _timer.Stop();

            if (_currentQuestion.IsAnswerCorrect(answer))
                _user.AddCorrectAnswer();

            if (_questions.Count > 0)
            {
                OnNextQuestion?.Invoke(GetQuestion());
                return true;
            }
            else
            {
                End();
                return false;
            }
        }

        private void End()
        {
            _user.AddDiagnosis(_indexCurrentQuestion);
            OnQuizComplite?.Invoke(_user);

            UsersResultsStorage.Add(_user);
        }

        private Question GetQuestion()
        {
            _timeLeft = 10;
            _timer = new Timer(1000);
            _timer.AutoReset = true;
            _timer.Elapsed += (s, e) => UpdateTimer();
            _timer.Start();

            if(_questions.Count != 0)
            {
                Random random = new Random();
                var index = random.Next(_questions.Count);

                _currentQuestion = _questions[index];
                _questions.RemoveAt(index);
                _currentQuestion.Number = ++_indexCurrentQuestion;
                return _currentQuestion;
            }
            
            return null;
        }

        private void UpdateTimer()
        {
            OnTimeUpdate?.Invoke(_timeLeft--);
            
            if (_timeLeft <= 0)
            {
                _timer.Stop();
                _timeLeft = 10;

                if (_questions.Count > 0)
                    OnNextQuestion?.Invoke(GetQuestion());
                else
                    End();
            }
        }
    }
}
