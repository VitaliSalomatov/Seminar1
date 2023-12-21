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
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Да, " + firstNumber + " является квадратом числа " + secondNumber);
}
else
{
    Console.WriteLine("Нет, " + firstNumber + " не является квадратом числа " + secondNumber);
}
