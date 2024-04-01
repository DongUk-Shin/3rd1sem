/*

Console.Write("a 입력: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b 입력: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("c 입력: ");
double c = Convert.ToDouble(Console.ReadLine());


double 근 = (Math.Pow(b, 2)) - (4 * a * c);
if (근 < 0)
{
    Console.WriteLine("허근입니다");

} else 
{
    double x1 = (- b + 근) / (2 * a);
    double x2 = (- b - 근) / (2 * a);

    Console.WriteLine("첫번째 근: "+ x1 + " 두번째 근: "+ x2);
}

using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;

Console.WriteLine();
Console.WriteLine();

int sum = 0;
for (int i = 9; i > 0; i -= 2)
{

    int t = 1;
    for (int j = 1; j <= i; j += 2)
    {
        if (j != i)
        {
            Console.Write(j + " * ");
        } else
        {
            Console.Write(j);
        }
        t *= j;

    }
    Console.Write(" " + t);
    sum += t;
    Console.WriteLine();
}
Console.WriteLine("2-1 총합: " + sum);
Console.WriteLine();

double sum2 = 0;
int 부호 = 1;
for (int i = 2; i <= 10; i += 2)
{
    double t = i;

    Console.WriteLine("1 / " + i + " = " + 1 / t);
    sum2 += (1 / t) * 부호;
    부호 *= -1;
}
Console.WriteLine("2-2 총합: " + sum2);
Console.WriteLine();


for (int i = 9; i > 0; i--)
{
    int j = i;
    for (int k = 9; k > j; k--)
    {
        Console.Write("  ");
    }
    for (; j > 1; j--)
    {
        Console.Write(j + " ");
    }
    for (; j <= i ; j++)
    {
        Console.Write(j + " ");
    }

    Console.WriteLine();
}

Console.WriteLine();



int a = 4;
int space = 1;
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < a; j++)
    {
        Console.Write("*");
    }

    for (int j = 0; j < 9 - 2 * a; j++)
    {
        Console.Write(" ");
    }
    
    for (int j = 0; j < a; j++)
    {
        Console.Write("*");
    }

    if (a == 1)
    {
        space = -1;
    }
    a -= space;
    Console.WriteLine();
}

*/


int x = 0;

for (int i = 1; i < 10; i = i+x) {


    for (int j = i; j <= i+x; j++)
    {

        for (int k = j; k < 10; k++)
        {
            //Console.Write(i + " * " + j + " = " + k * j + " ");

            Console.Write(j + "* " + k + "= " + (j*k) + " | ");
        }
        Console.WriteLine();
    }
    x += i;

}

