// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Write a number A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Sum of digits in number {A} is {GetSum(A)}");

int GetSum(int n)
{
    int sum = 0;
    while (n>0)
    {
        sum = sum + n%10;
        n/=10;
    }
    return sum;
}