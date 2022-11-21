// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Enter the number: ");
int number;

while (true)
{
    if(int.TryParse(Console.ReadLine(), out number))
        break;  
    Console.WriteLine("Input error!");
}

if (number < 0)
{
    Console.WriteLine("Input error!");
}

int CubeCalculation(int number)
{
    int count = 1;
    int cubeCulc = 0;
    while (count <= number)
    {
        cubeCulc = number * number * number;
        Console.WriteLine($"{number} CUBE: {cubeCulc}\n");
        number --;
    }
    return number;
}

int cubeTable = CubeCalculation(number);
Console.Write(cubeTable);