/* 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int fillNumberArray (int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array [i] <= end)
        {
            count = count + 1;
        }  
    }
    return count;

}

int[] getRandArr(int length, int deviation)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
        arr[i] = rnd.Next(0, deviation + 1);
    return arr;
}

void printArr(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1)
            Console.Write(arr[i] + ", ");
        else
            Console.WriteLine(arr[i] + "]");
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int [] myArray = getRandArr(123, 1000) ;
printArr (myArray);

int result = fillNumberArray (myArray, 10, 99);
Console.WriteLine($"Nubber of 2 digit number at thee array: {result}");