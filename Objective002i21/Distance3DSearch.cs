// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Enter coordinate x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinate z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double ThreeDimensionalDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double xDistance = (x1 - x2) * (x1 - x2);
    double yDistance = (y1 - y2) * (y1 - y2);
    double zDistance = (z1 - z2) * (z1 - z2);
    double distanceResult = Math.Sqrt (xDistance + yDistance + zDistance);
    return distanceResult;
}

double fullResult = ThreeDimensionalDistance(x1, x2, y1, y2, z1, z2);
double cutResult = Math.Round(fullResult, 2);
Console.WriteLine($"A({x1},{y1},{z1}), B({x2},{y2},{z2}) -> {cutResult}");