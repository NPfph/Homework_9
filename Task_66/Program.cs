// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void Sum(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     Sum(m, n - 1, sum);
}
int m = input("Введите M: ");
int n = input("Введите N: ");
int temp = m;

if (m > n)
{
     m = n;
     n = temp;
}
Console.Write($"Сумма чисел от {m} до {n} равна -> ");
Sum(m, n, temp = 0);


