// // 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void PalindromNumber(int num)
{
    int num1 = num / 10000 % 10;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num  % 10;
      
    if (num > 99999 || num < 10000)
    {
        Console.WriteLine("Check the quantity of digits.");
    }

    else
    {
        if (num1 == num5 && num2 == num4)
        {
         Console.WriteLine("Your number is palindrom.");
         }

         else
         {
         Console.WriteLine("Your number is not palindrom.");  
         }
     }
    
    
}

Console.WriteLine("Input integer five-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

PalindromNumber(n);

// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void distanceCoord3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x2-x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    Console.WriteLine ("The distanse bitween dots is " + dist);
}

Console.WriteLine ("Input the coordinates of the first dot:");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Input the coordinates of the second dot:");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int zb = Convert.ToInt32(Console.ReadLine());

distanceCoord3D(xa, ya, za, xb, yb, zb);

// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int FindCubesBeforeN(int n)
{
    int result = 0;

       for (int i = 0; i <= n; i++)
    {
        result = i * i * i + result;
    }
    return result;
}
Console.WriteLine("Input the number: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = FindCubesBeforeN(N);
Console.WriteLine("The sum of numbers' cubes before the number is " + sum + ".");
