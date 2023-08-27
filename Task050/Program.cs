/*Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого элемента в массиве нет*/

using System;

class Program {
    static void Main(string[] args) {
        
        int[,] arr = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

        Console.Write("Введите позицию элемента в формате 'строка,столбец': ");
        string pos = Console.ReadLine();
        string[] posArr = pos.Split(",");
        int row = int.Parse(posArr[0]) - 1;
        int col = int.Parse(posArr[1]) - 1;

        if (row < 0 || row >= arr.GetLength(0) || col < 0 || col >= arr.GetLength(1)) {
            Console.WriteLine("Такого элемента нет");
        } else {
            Console.WriteLine("Значение элемента: " + arr[row, col]);
        }
    }
}