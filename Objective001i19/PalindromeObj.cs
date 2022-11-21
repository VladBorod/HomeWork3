// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число для определения полиндромности: ");
int number;  // = Convert.ToInt32(Console.ReadLine()); 

while (true)
{
    if(int.TryParse(Console.ReadLine(), out number))
        break;  
    Console.WriteLine("Ошибка ввода, проверьте вводимые значения!");
}

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели не верное число!");
}
else
{
    bool PalindromeSearch()
    {
        int numLeft1 = number / 10000;
        int numRight1 = number % 10;
        int numLeft2 = number / 1000 % 10;
        int numRight2 = number / 1000 % 10;
        return(numLeft1 == numRight1 && numLeft2 == numRight2);
    }
    Console.WriteLine(PalindromeSearch()? $"{number} -> да" : "{number} -> нет");
}
