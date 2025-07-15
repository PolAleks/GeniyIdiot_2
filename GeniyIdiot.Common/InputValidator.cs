using System;

namespace GeniyIdiot.Common
{
    public class InputValidator
    {
        public static bool TryParseNumber(string inputData,
                                   out int value,
                                   out string errorMessage,
                                   int minValue = int.MinValue,
                                   int maxValue = int.MaxValue)
        {
            value = default;
            errorMessage = string.Empty;

            try
            {
                value = int.Parse(inputData);
                if (value < minValue || value > maxValue)
                    throw new OverflowException();
                return true;
            }
            catch (ArgumentNullException)
            {
                errorMessage = "Вы не ввели данные";
            }
            catch(FormatException) 
            {
                errorMessage = "Ответ должен содержать число!";
            }
            catch(OverflowException) 
            {
                errorMessage = $"Выбор должен быть в диапазоне от {minValue} до {maxValue}: ";
            }
            
            return false;
        }
    }
}
