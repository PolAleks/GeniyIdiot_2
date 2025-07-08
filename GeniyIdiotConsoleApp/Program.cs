using System;
using System.IO;

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
                Console.WriteLine("3. Выход");
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
                        break;
                    default:
                        Console.Write("Некорректный выбор, доступный диапазон от 1 до 3!" +
                                       Environment.NewLine +
                                       "Выберите номер пункта меню: ");
                        userChoice = GetNumber();
                        break;
                }
            }
            while (userChoice != 3);
        }

        private static void ShowResults()
        {
            Console.Clear();

            var file = Path.Combine(Environment.CurrentDirectory, "log.txt");
            if (File.Exists(file))
            {
                Console.WriteLine($"{"Имя",-15}{"Правильные ответы",18}{"Диагноз",15}");

                var lines = File.ReadAllLines(file);
                foreach (var line in lines)
                {
                    var item = line.Split(new char['#'], StringSplitOptions.RemoveEmptyEntries);
                    (string name, int countCorrectAnswer, string diagnosis) = (item[0], Convert.ToInt32(item[1]), item[2]);
                    Console.WriteLine($"{name,-15}{countCorrectAnswer,10}{diagnosis,23}");
                }
            }
            else
            {
                Console.WriteLine("Результаты ранее проведенных тестов отсутствуют!");
                Console.WriteLine("Для возвращения в меню, нажмите любую клавишу.");
                Console.ReadKey();
            }
        }

        static void StartTest()
        {
            do
            {
                (string[] question, int[] answer) = GetQuestions();
                ShuffleQuestions(question, answer);

                Console.Write("Напиши своё имя: ");
                var userName = Console.ReadLine();

                int countCorrectUserAnswer = 0;
                for (int i = 0; i < question.Length; i++)
                {
                    Console.WriteLine($"Вопрос №{i + 1}:");
                    Console.Write($"{question[i]}: ");
                    var userAnswer = GetNumber();
                    if (userAnswer == answer[i]) countCorrectUserAnswer++;
                }

                Console.WriteLine("Количество правильных ответов - {0}", countCorrectUserAnswer);

                string diagnosis = GetDiagnosis(countCorrectUserAnswer, answer.Length);

                Console.WriteLine($"{userName} твой диагноз - {diagnosis}");
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
        static bool Repeat()
        {
            Console.Write("Провести повторное тестирование(да/нет)? ");
            return Console.ReadLine().ToLower().Equals("да");
        }

        static void ShuffleQuestions(string[] question, int[] answer)
        {
            Random rand = new Random();
            for (int i = question.Length - 1; i > 0; i--)
            {
                int newIndex = rand.Next(i);
                (question[i], question[newIndex]) = (question[newIndex], question[i]);
                (answer[i], answer[newIndex]) = (answer[newIndex], answer[i]);
            }
        }

        static (string[], int[]) GetQuestions()
        {
            var question = new string[]
            {
                "Сколько будет два плюс два умноженное на два?",
                "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?",
                "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
                "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?",
                "Пять свечей горело, две потухли. Сколько свечей осталось?",
            };
            var answer = new int[] { 6, 9, 25, 60, 2 };

            return (question, answer);
        }

        static string GetDiagnosis(int countCorrectAnswer, int countAnswer)
        {
            var diagnosis = new string[]
            {
                "Кретин",
                "Идиот",
                "Дурак",
                "Нормальный",
                "Талант",
                "Гений"
            };

            int percentage = (countCorrectAnswer / countAnswer) * 100;

            return diagnosis[percentage / 20];
        }
    }
}
