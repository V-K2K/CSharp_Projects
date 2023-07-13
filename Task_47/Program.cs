/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
    

    double[,] result = new double[rowNumber, colNumber];
    for(int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            // result[i,j] = new Random().NextDouble()*(maxvalue - minvaluevalue) + minvalue;
            result[i,j] = new Random().NextDouble() * (2 * deviation) - deviation; //Задаем массив разными числами
            result[i,j] = Math.Round(result[i,j],2); // округляем до 2х чисел после запятой

        }
    }
    return result;
}

void print2DArray(double[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] numbers = GetRandom2DArray(3,4,100);
print2DArray(numbers);

