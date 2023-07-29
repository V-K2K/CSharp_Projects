/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using System;

class Program
{
    static void Main()
    {
        int[,] arr = new int[4, 4];
        int num = 1, startRow = 0, endRow = 3;
        int startCol = 0, endCol = 3;
        
        while (num <= 16)
        {
            for (int i = startCol; i <= endCol; i++)
                arr[startRow, i] = num++;
                
            startRow++;
            
            for (int i = startRow; i <= endRow; i++)
                arr[i, endCol] = num++;
                
            endCol--;
            
            for (int i = endCol; i >= startCol; i--)
                arr[endRow, i] = num++;
                
            endRow--;
            
            for (int i = endRow; i >= startRow; i--)
                arr[i, startCol] = num++;
                
            startCol++;
        }

        // Вывод массива
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(arr[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
}