
int[,] fillarray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}


int vvod(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(System.Console.ReadLine());
}

void printarray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    return;
}

int n = vvod("Введите количество строк: ");
int m = vvod("Введите количество столбцов: ");
int[,] array = fillarray(n, m);

printarray(array);

System.Console.WriteLine();

int count = 0;

for (int k = 0; k < 10; k++)
{
    count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (k == array[i, j])
            {
                count++;
            }
        }
    }
    if (count > 0)
    {
        System.Console.WriteLine($"{k} встречается {count} раз");
    }
}



Console.WriteLine("Hello, World!");
