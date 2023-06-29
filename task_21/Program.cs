/* Задача 22 не 21
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Enter number ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;
Console.Write($"Squares from 1 to {number}: ");
while (count <= number)
{
    Console.Write(count*count + " ");
    count++; //count = count + 1
}
