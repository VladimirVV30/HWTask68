// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AkkRec(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return AkkRec(M - 1, 1);
    }
    else
    {
        return (AkkRec(M - 1, AkkRec(M, N - 1)));
    }
}

void AkkRecFunction(int M, int N)
{
    Console.Write(AkkRec(M, N));
}

AkkRecFunction(3, 2);