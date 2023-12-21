// Комментарий однострочный
// Ctrl + Правый слэш - многострочный комментарий
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Тип_данных имя_переменной = значение;
// camelCase: firstNumber, secondNumber
// int number = 9;
// int result = number * number;

// Console.ReadLine () - получить информацию из строки
//string input = Console.ReadLine();
// "123" + "123" (конкатенация)
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber * secondNumber)
// {
//     Console.WriteLine("Да, " + firstNumber + " является квадратом числа " + secondNumber);
// }
// else
// {
//     Console.WriteLine("Нет, " + firstNumber + " не является квадратом числа " + secondNumber);
// }
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2
using System.Threading.Tasks.Dataflow;

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    Console.WriteLine("Введено отрицательное число");
    N = N * -1;
}
int negativeN = N * -1;
while (negativeN <= N)
{
    Console.Write(negativeN + " ");
    negativeN++;
}
