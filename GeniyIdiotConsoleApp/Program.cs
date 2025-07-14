using GeniyIdiot.Common;
using System;
using System.Collections.Generic;

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

            QuestionsStorage.Add(new Question(textQuestion, answerQuestion));
        }

        static void ShowResults()
        {
            Console.Clear();

            var users = UsersResultsStorage.GetAll();
            if (users != null)
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

            var test = new TestManager(user);
            test.OnNextQuestion += q =>
            {
                Console.Write($"Вопрос №{test.NumberQuestion}");
                Console.Write($"{q.Text}: ");
            };

            test.OnCompliteTest += u =>
            {
                Console.WriteLine("Количество правильных ответов - {0}", u.CountCorrectAnswer);
                Console.WriteLine($"{u.Name} твой диагноз - {u.Diagnosis}");
            };

            test.Start();

            do
            {
                bool isNextQuestion = true;
                while (isNextQuestion)
                {
                    isNextQuestion = test.SubmitAnswer(GetNumber());
                }

            } while (Repeat());
        }

        static int GetNumber(int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            while (true)
            {
                try
                {
                    int value = Convert.ToInt32(Console.ReadLine());
                    if (value < minValue || value > maxValue) throw new OverflowException();
                    return value;
                }
                catch (FormatException)
                {
                    Console.Write("Только цифры от 0 до 9! Повторите ввод: ");
                }
                catch (OverflowException)
                {
                    Console.Write($"Выбор должен быть в диапазоне от {minValue} до {maxValue}: ");
                }
            }
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

        static void ShuffleQuestions(List<Question> questions)
        {
            Random rand = new Random();
            for (int i = questions.Count - 1; i > 0; i--)
            {
                int newIndex = rand.Next(i);
                (questions[i].Text, questions[newIndex].Text) = (questions[newIndex].Text, questions[i].Text);
                (questions[i].Answer, questions[newIndex].Answer) = (questions[newIndex].Answer, questions[i].Answer);
            }
        }
    }
}
