/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите два числа");
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int result = Exponent(firstNumber, secondNumber);

int Exponent(int first, int second)

{
    int exp = 1;
    for (int i = 0; i < second; i++)
    {
        exp *= first;
    }
    return exp;
}
Console.Write($"Число {firstNumber} в степени {secondNumber} равно {result} ");
