// 71.Показать натуральные числа от N до 1, N задано


void Numbers(int i, int N)
{
    if (i <= N)
    {
        System.Console.WriteLine(N);
        Numbers(i, N - 1);
    }
}
Numbers(1, 5);