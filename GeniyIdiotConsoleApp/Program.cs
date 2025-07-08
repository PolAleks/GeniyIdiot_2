using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
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

                string diagnosis = GetDiagnosis(countCorrectUserAnswer);

                Console.WriteLine($"{userName} твой диагноз - {diagnosis}");
            }while (Repeat());
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

        static string GetDiagnosis(int countAnswer)
        {
            switch (countAnswer)
            {
                case 5:
                    return "Гений";
                case 4:
                    return "Талант";
                case 3:
                    return "Нормальный";
                case 2:
                    return "Дурак";
                case 1:
                    return "Идиот";
                default:
                    return "Кретин";
            }
        }
    }
}
