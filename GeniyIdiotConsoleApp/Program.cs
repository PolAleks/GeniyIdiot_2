using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

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
                Console.WriteLine("4. Выход");
                Console.Write("Выберите номер пункта меню: ");
                userChoice = GetNumber();

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
                        break;
                    default:
                        Console.Write("Некорректный выбор, доступный диапазон от 1 до 4!" +
                                       Environment.NewLine +
                                       "Выберите номер пункта меню: ");
                        userChoice = GetNumber();
                        break;
                }
            }
            while (userChoice != 3);
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

            } while (Repeat("Все верно?"));

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
            do
            {
                var questions = QuestionsStorage.GetAll();
                ShuffleQuestions(questions);

                Console.Write("Напиши своё имя: ");
                var userName = Console.ReadLine();
                User user = new User(userName);

                for (int i = 0; i < questions.Count; i++)
                {
                    Console.WriteLine($"Вопрос №{i + 1}:");
                    Console.Write($"{questions[i].Text}: ");
                    var userAnswer = GetNumber();

                    if (questions[i].IsAnswerCorrect(userAnswer))
                        user.AddCorrectAnswer();
                }

                Console.WriteLine("Количество правильных ответов - {0}", user.CountCorrectAnswer);

                user.AddDiagnosis(questions.Count);

                Console.WriteLine($"{userName} твой диагноз - {user.Diagnosis}");

                UsersResultsStorage.Add(user);

            } while (Repeat());
        }

        static int GetNumber()
        {
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("Для ответа, используйте числа от 0 до 9: ");
                }
                catch (OverflowException)
                {
                    Console.Write($"Ответ  должен быть в диапазоне от {int.MinValue} до {int.MaxValue}: ");
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
            while (userConfirmation == "да" || userConfirmation == "нет");
            
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
