
// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] SortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortMaxToMinInRow(array, i);
       
    }
    return array;
}

void SortMaxToMinInRow(int[,] array, int i)
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
}


int[,] array = GenerateArray(3, 4, 0, 10);
PrintArray(array);
int[,] sortedArray = SortedArray(array);
PrintArray(sortedArray);*/



// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"Сумма {i + 1} строки = {array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] SumOfRow(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}

void MinSumOfRow(int[] sum)
{
    int indexMin = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[i] < sum[indexMin])
        {
            indexMin = i;
        }
    }
    System.Console.WriteLine($"Строка с наименьшей суммой элементов {sum[indexMin]} - строка № {indexMin + 1}");
    System.Console.WriteLine();
}

int[,] array = GenerateArray(3, 4, 0, 10);
PrintMatrix(array);
int[] sum = SumOfRow(array);
PrintArray(sum);
MinSumOfRow(sum);*/



// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*int[,] GenerateArray(int rowLength, int colLength, int minRange, int maxRange)
{
    var array = new int[rowLength, colLength];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRange, maxRange);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    result[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine("Такого произведения матриц не существует, так как число столбцов первой матрицы не совпадает с числом строк второй матрицы");
    }
    return result;
}

int[,] array1 = GenerateArray(3, 3, 1, 4);
PrintMatrix(array1);
int[,] array2 = GenerateArray(3, 1, 1, 4);
PrintMatrix(array2);
int[,] resultMatrix = MultiplicationMatrix(array1, array2);
PrintMatrix(resultMatrix);*/





// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.


/*Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}*/