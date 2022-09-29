// Задача 21

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки:  ");
double [] t1 = new double[3] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
Console.WriteLine("Введите координаты второй точки");
double [] t2 = new double[3] {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
double schet = Math.Pow((t2[0]-t1[0]),2) + Math.Pow((t2[1]-t1[1]), 2) + Math.Pow((t2[2]-t1[2]), 2);
Console.WriteLine(Math.Sqrt(schet));