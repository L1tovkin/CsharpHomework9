// ВСЕ ЗАДАЧИ РЕШАЕМ ЧЕРЕЗ РЕКУРСИЮ
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Все натуральные числа в промежутке от {n} до 1 --> {Recurs(n)}");

// string Recurs(int n)
// {
//     if (n == 1){
//         return n.ToString();
//     }
//     return (n + " " + Recurs(n - 1));
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} -> {sumRec(m, n)}");

// int sumRec(int m, int n){
//     if (m == n)
//     {
//     return n;
//     }
//     return (m + sumRec(m + 1, n));
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Натуральное число {m} и {n}) --> {funAckermann(m, n)}");

// int funAckermann(int m, int n)
// {
//     if (m == 0){
//         return n + 1;
//     }
//     if ((m > 0) && (n == 0)){
//         return funAckermann(m - 1, 1);
//     }
//     if ((m > 0) && (n > 0)){
//         return funAckermann(m - 1, funAckermann(m, n - 1));
//     }
//     return n + 1;
// }