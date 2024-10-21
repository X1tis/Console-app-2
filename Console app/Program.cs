using System;

namespace BinaryOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            // Бинарные операции
            Console.WriteLine("\nБинарные операции:");
            Console.WriteLine($"num1 & num2 (И): {num1 & num2}");
            Console.WriteLine($"num1 | num2 (ИЛИ): {num1 | num2}");
            Console.WriteLine($"num1 ^ num2 (Исключающее ИЛИ): {num1 ^ num2}");
            Console.WriteLine($"~num1 (НЕ): {~num1}");

            // Операции присвоения
            Console.WriteLine("\nОперации присвоения:");
            int result = num1;
            Console.WriteLine($"result = {result}");

            result += num2; // result = result + num2
            Console.WriteLine($"result += num2: {result}");

            result -= num1; // result = result - num1
            Console.WriteLine($"result -= num1: {result}");

            result *= 2; // result = result * 2
            Console.WriteLine($"result *= 2: {result}");

            result /= 2; // result = result / 2
            Console.WriteLine($"result /= 2: {result}");

            result %= 3; // result = result % 3
            Console.WriteLine($"result %= 3: {result}");

            result <<= 2; // result = result << 2 (сдвиг влево)
            Console.WriteLine($"result <<= 2: {result}");

            result >>= 2; // result = result >> 2 (сдвиг вправо)
            Console.WriteLine($"result >>= 2: {result}");

            result &= num1; // result = result & num1
            Console.WriteLine($"result &= num1: {result}");

            result |= num2; // result = result | num2
            Console.WriteLine($"result |= num2: {result}");

            result ^= num1; // result = result ^ num1
            Console.WriteLine($"result ^= num1: {result}");

            Console.ReadKey();
        }
    }
}