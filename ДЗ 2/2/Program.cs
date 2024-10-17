using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите первое число (от 0 до 255): ");
            byte num1 = Convert.ToByte(Console.ReadLine());

            Console.Write("Введите второе число (от 0 до 255): ");
            byte num2 = Convert.ToByte(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль невозможно.");
            }
            else
            {
                double result = (double)num1 / num2;
                Console.WriteLine($"Результат деления: {result}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите корректное число в диапазоне от 0 до 255.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число должно быть в диапазоне от 0 до 255.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
