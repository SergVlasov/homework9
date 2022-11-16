// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int M = InputText("Enter a number M: ");
int N = InputText("Enter a number N: ");
while (M > N)
{
    Console.WriteLine("The number M must be less than the number N");
    M = InputText("Enter a number M: ");
    N = InputText("Enter a number N: ");
}
Console.WriteLine($"Sum of numbers from {M} before {N} = {SumElements(M, N)}");

int SumElements(int M, int N)
{
    int sum = 0;
    if (M == N) return N;
    else return sum += M + SumElements(M + 1, N);
}

int InputText(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}