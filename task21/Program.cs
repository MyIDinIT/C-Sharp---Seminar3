// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координаты точки А по оси Х:");
int Ax=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки А по оси Y:");
int Ay=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси Х:");
int Bx=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси Y:");
int By=Convert.ToInt32(Console.ReadLine());

double Distance= Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2));
double DistanceRound=Math.Round(Distance,2);

Console.WriteLine(DistanceRound);