﻿using System;

namespace GeniyIdiot.Common
{
    public class Question : IEquatable<Question>
    {
        public string Text { get ; set; }
        public int Answer { get ; set; }
        public int Number { get; set; } = 0;
        public Guid Id { get; set; }

        public Question() { }
        public Question(string text, int answer, Guid id)
        {
            Text = text;
            Answer = answer;
            Id = id;
        }
        public bool IsAnswerCorrect(int answer) => Answer == answer;

        public bool Equals(Question other)
        {
            return Text.Equals(other.Text) && Answer.Equals(other.Answer);
        }
    }
}
