// Задайте двумерный массив. Напишите программу, которая заменяет строки
// на столбцы.

int InputIntNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrixWhithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] printmatrix)
{
    for (int i = 0; i < printmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < printmatrix.GetLength(1); j++)
        {
            System.Console.Write($"{printmatrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int n = InputIntNumber("Введите кол-во строк массива: ");
Console.WriteLine();
int m = InputIntNumber("Введите кол-во столбцов массива: ");
Console.WriteLine();
int[,] matrix = new int[n,m];
matrix = FillMatrixWhithRandom(matrix);
PrintMatrix(matrix);
int[,] newmatrix = new int[m,n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        newmatrix[i,j] = matrix[j,i];
    }
}
//PrintMatrix(newmatrix);


// int[,] fillarray(int n, int m)
// {
//     int[,] array = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return array;
// }


// int vvod(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(System.Console.ReadLine());
// }

// void printarray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]} ");
//         }
//         System.Console.WriteLine();
//     }
//     return;
// }

// int n = vvod("Введите количество строк: ");
// int m = vvod("Введите количество столбцов: ");
// int[,] array = fillarray(n, m);

// printarray(array);

// System.Console.WriteLine();

// int[,] arraytrans = fillarray(m, n);

// for(int i=0;i<m;i++)
// {
//     for(int j=0; j<n; j++)
//     {
//        arraytrans[i,j] =array[j,i];
//     }
// }

// printarray(arraytrans);

Console.WriteLine("Hello, World!");
