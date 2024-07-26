using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int size = 6;
        char[] nameArray = new char[size];
        Console.WriteLine("Введите свое имя: ");
        string nameString = Console.ReadLine();
        string nameToWriteInConsole = "";
        string nameToWriteInConsoleReverse = "";

        // изменение размерности массива в зависимости от длины строки
        if (nameString.Length > size)
        {
            Array.Resize(ref nameArray, nameString.Length);
        }

        nameArray = nameString.ToCharArray();
        
        // вывод строки в прямом порядке через пробел
        foreach (char c in nameArray)
        {
            nameToWriteInConsole += c + " ";
        }
        Console.WriteLine(nameToWriteInConsole);

        // вывод строки в обратном порядке
        foreach (char c in nameArray.Reverse())
        {
            nameToWriteInConsoleReverse += c;
        }
        Console.WriteLine(nameToWriteInConsoleReverse);
    }
}