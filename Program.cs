// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.

void recurtion64(int startNumber, int finishNumber)
{
    if (startNumber > finishNumber) return;
    if(startNumber % 3 == 0) Console.Write($"{startNumber}  ");
    startNumber++;
    recurtion64(startNumber, finishNumber);
}

void Zadacha64()
{
    Random random = new Random();
    int startNumber = random.Next(0, 11);
    Console.WriteLine(startNumber);
    int finishNumber = random.Next(20, 31);
    Console.WriteLine(finishNumber);
    recurtion64(startNumber, finishNumber);
}


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void recurtion66(int startNumber, int finishNumber, int sum)
{
    if (startNumber > finishNumber)
    {
        Console.Write($"\b= {sum}");
        return;
    }
    Console.Write($"{startNumber}+");
    sum += startNumber;
    startNumber++;
    recurtion66(startNumber, finishNumber, sum);
}

void Zadacha66()
{
    Random random = new Random();
    int startNumber = random.Next(5, 11);
    Console.WriteLine($"Стартовое число = {startNumber}");
    int finishNumber = random.Next(15, 21);
    Console.WriteLine($"Финишное число = {finishNumber}");
    int sum = 0;
    recurtion66(startNumber, finishNumber, sum);
}

//

int Akk(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akk(n - 1, 1);
    if (n > 0 && m > 0) return Akk(n - 1, Akk(n, m - 1));
    return Akk(n,m);
}

void Zadacha68()
{
    Console.WriteLine("Введите число");
    Console.Write("n = ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число");
    Console.Write("m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Akk(n, m));
}

Zadacha64();