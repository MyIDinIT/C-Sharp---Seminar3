// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число выше нуля: ");
int A=Convert.ToInt32(Console.ReadLine());

if (A<1)    Console.WriteLine("Ошибка ввода");

for (int i = 1; i <= A; i++)
{
   int  X=i*i;
    Console.Write(X+" ");
    X++;
}


