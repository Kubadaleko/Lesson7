// 72.Показать натуральные числа от M до N, N и M заданы

void Loop(int M, int N)
{
    if (M <= N && M >= 0)
    {
        System.Console.WriteLine(M);
        Loop(M + 1, N);
    }
}
Loop(0, 40);