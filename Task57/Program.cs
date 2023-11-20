// Составить частотный словарь элементов двумерного массива. Частотный
// словарь содержит информацию о том, сколько раз встречается
// элемент входных данных.

// 21:10
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6

// 21:10
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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

void count(int[,] array, int elmatrix)
{
    if (elmatrix == -1)
    {
        return;
    }

    int counter = 0;
    int temp = elmatrix;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (temp == array[i, j])
            {
                counter++;
                array[i, j] = -1;
            }
        }
    }

    System.Console.WriteLine($"{elmatrix} встречается {counter} раз");
    return;
}



int n = vvod("Введите количество строк: ");
int m = vvod("Введите количество столбцов: ");
int[,] array = fillarray(n, m);

printarray(array);

System.Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        count(array, array[i, j]);
    }
}




Console.WriteLine("Hello, World!");
