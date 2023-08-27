/*Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 
4,6; 5,6; 3,6; 3.*/

int[,] array = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int rows = array.GetLength(0);
int cols = array.GetLength(1);

for (int j = 0; j < cols; j++)
{
    double sum = 0;

    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }

    double average = sum / rows;
    Console.WriteLine($"Среднее арифметическое элементов {j + 1}: {average}");
}
