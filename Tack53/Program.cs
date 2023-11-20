// // Задайте двумерный массив. Напишите программу, которая меняет
// // местами первую и последнюю строку массива.

// int InputIntNumber(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] FillMatrixWhithRandom(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int n = InputIntNumber("Введите кол-во строк массива: ");
// Console.WriteLine();
// int m = InputIntNumber("Введите кол-во столбцов массива: ");
// Console.WriteLine();
// int[,] matrix = new int[n,m];
// matrix = FillMatrixWhithRandom(matrix);
// PrintMatrix(matrix);
// int tmpnumber = 0;
// for (int i = 0; i < m; i++)
// {
//     matrix[0,i] = tmpnumber;
//     matrix[0,i] = matrix[n,i];
//     matrix[n,i] = tmpnumber;
// }
// PrintMatrix(matrix);


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

int n = vvod("Введите количество строк");
int m = vvod("Введите количество столбцов");
int[,] array = fillarray(n, m);

printarray(array);

System.Console.WriteLine();

int temp = 0;

//int[] arraytemp = new int[m];

for (int i = 0; i < m; i++)
{
    temp = array[0,i];
    array[0,i]=array[n-1,i];
    array[n-1,i]=temp;
}

printarray(array);
System.Console.WriteLine();

for (int i = 0; i < m; i++)
{
    array[0,i]=array[0,i]+array[n-1,i];
    array[n-1,i]= array[0,i]-array[n-1,i];
    array[0,i]=array[0,i]-array[n-1,i];    
}

printarray(array);