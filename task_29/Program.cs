/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


int[] Array = CreateRandomarray();
PrintArray(Array);

int [] CreateRandomarray()
{
    int minSizeArray = 0;
    int maxSizeArray = 100;
    Random rnd = new Random();
    int[] rndArr = new int [8];
    for (int i = 0; i < rndArr.Length; i++)
    {
        rndArr[i] = rnd.Next(minSizeArray, maxSizeArray);
    }
    return rndArr;
}

void PrintArray(int[] rndArr)
{
    Console.Write("[");

    for (int i = 0; i < rndArr.Length; i++)
    {
        if (i != rndArr.Length - 1)
            Console.Write(rndArr[i] + ", ");
        else
            Console.Write(rndArr[i]);
    }

    Console.Write("]");
}