using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniyIdiotConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userChoice;

            do
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Просмотр результатов тестирования");
                Console.WriteLine("2. Начать тестирование");
                Console.WriteLine("3. Добавить новый вопрос");
                Console.WriteLine("4. Удалить существующий вопрос");
                Console.WriteLine("5. Выход");
                Console.Write("Выберите номер пункта меню: ");
                userChoice = GetNumber(1, 5);

                switch (userChoice)
                {
                    case 1:
                        ShowResults();
                        break;
                    case 2:
                        StartTest();
                        break;
                    case 3:
                        AddNewQuestion();
                        break;
                    case 4:
                        DeleteQuestion();
                        break;
                    default:
                        break;
                }
            }
            while (userChoice != 5);
        }

        static void DeleteQuestion()
        {
            var questions = QuestionsStorage.GetAll();

            Console.WriteLine("Список вопросов:");
            for (int i = 0; i < questions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {questions[i].Text}");
            }

            Console.WriteLine("Введите номер удаляемого вопроса: ");
            int userChoise;

            do
            {
                userChoise = GetNumber(1, questions.Count);
            }
            while (userChoise < 1 || userChoise > questions.Count);

            QuestionsStorage.Delete(questions[--userChoise]);
        }

        static void AddNewQuestion()
        {
            string textQuestion;
            int answerQuestion;

            do
            {
                Console.WriteLine("Введите текст вопроса:");
                textQuestion = Console.ReadLine();

                Console.WriteLine("Введите ответ на вопрос, значение должно быть числовым:");
                answerQuestion = GetNumber();

            } while (!Repeat("Все верно?"));

            QuestionsStorage.Add(new Question(textQuestion, answerQuestion, Guid.NewGuid()));
        }

        static void ShowResults()
        {
            Console.Clear();

            var users = UsersResultsStorage.GetAll();
            if (users.Any())
            {
                Console.WriteLine($"{"Имя",-15}{"Правильные ответы",18}{"Диагноз",15}");

                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Name,-15}{user.CountCorrectAnswer,10}{user.Diagnosis,23}");
                }
            }
            else
            {
                Console.WriteLine("Результаты ранее проведенных тестов отсутствуют!");
            }
            Console.WriteLine("Для возвращения в меню, нажмите любую клавишу.");
            Console.ReadKey();
        }

        static void StartTest()
        {
            Console.Write("Напиши своё имя: ");
            var userName = Console.ReadLine();
            User user = new User(userName);

            QuizManager quiz = new QuizManager(user);

            quiz.OnNextQuestion += q => Console.WriteLine(
                $"Вопрос №{q.Number}\n" +
                $"{q.Text}");

            quiz.OnQuizComplite += u => Console.WriteLine(
                $"Количество правильных ответов - {u.CountCorrectAnswer}\n" +
                $"{u.Name} твой диагноз - {u.Diagnosis}");

            quiz.OnTimeUpdate += leftTime => Console.WriteLine($"Осталось {leftTime} сек.");

            quiz.Start();

            do
            {
                bool anyQuestions = true;
                while (anyQuestions)
                {
                    anyQuestions = quiz.Submit(GetNumber());
                }
            }
            while (Repeat());
        }

        static int GetNumber(int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int number;
            while (!InputValidator.TryParseNumber(Console.ReadLine(),
                                                  out number,
                                                  out string errorMessage,
                                                  minValue,
                                                  maxValue))
            {
                Console.WriteLine(errorMessage);
            }
            return number;
        }

        static bool Repeat(string question = "Провести повторное тестирование?")
        {
            string userConfirmation = string.Empty;

            do
            {
                Console.Write($"{question} Введите да или нет: ");
                userConfirmation = Console.ReadLine().ToLower();
            }
            while (!(userConfirmation == "да" || userConfirmation == "нет"));

            return userConfirmation.Equals("да");
        }

    }
}
