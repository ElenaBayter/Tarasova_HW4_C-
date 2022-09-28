// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Write a number A: ");
double A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write a number B: ");
double B = int.Parse(Console.ReadLine()!);

double total = 0; 
Console.WriteLine($"Exponentiation of number A to the power B is {Exp(total)}");

double Exp(double n)
{
    total = Math.Pow(A,B);
    return total;

}
