/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */
Console.WriteLine("Введите пятизначное число: ");
int palindrom = Convert.ToInt32(Console.ReadLine());
if (palindrom > 0 && palindrom < 100000)
{
    int chislo1 = (palindrom - palindrom % 10000) / 10000;
    int chislo2 = ((palindrom - chislo1 * 10000) - palindrom % 1000) / 1000;
    int chislo3 = ((palindrom - chislo1 * 10000 - chislo2 * 1000) - palindrom % 100) / 100;
    int chislo4 = (((palindrom - chislo1 * 10000 - chislo2 * 1000 - chislo3 * 100)) - palindrom % 10) / 10;
    int chislo5 = palindrom % 10;
    if (chislo1 == chislo5 && chislo2 == chislo4) Console.WriteLine("Да, число является палиндромом");
    else Console.WriteLine("Нет, число не является палиндромом");
}
else Console.WriteLine("Неверное значение");