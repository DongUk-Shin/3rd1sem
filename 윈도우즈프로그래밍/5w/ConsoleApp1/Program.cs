
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


Console.WriteLine(); Console.WriteLine();

int sum = 0;
int[] arr1 = new int[] { 1, 3, 5, 7, 9 };
for (int i = 5; i > 0; i--)
{
    int temp = 1;
    for (int j = 0; j < i; j++)
    {
        if (j == i-1)
        {
            Console.Write(arr1[j] + " ");
        } else
        {
            Console.Write(arr1[j] + " * ");
        }
        temp *= arr1[j];
    }
    Console.Write(temp);
    sum += temp;
    Console.WriteLine();
}
Console.WriteLine("2-1 총합: " + sum);
Console.WriteLine();

double[] arr2 = new double[] { 2, 4, 6, 8, 10 };
double sum2 = 0;
double 부호 = 1;
for (int i = 0; i < arr2.Length; i++)
{
    double div = (1 / arr2[i]);
    Console.WriteLine("1 / " + arr2[i] + " = " + div);

    sum2 += (부호 * div);
    부호 *= -1;
}
Console.WriteLine("2-2 총합: " + sum2);
Console.WriteLine();
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



int a4 = 4;
int space = 1;
for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < a4; j++)
    {
        Console.Write("*");
    }

    for (int j = 0; j < 9 - 2 * a4; j++)
    {
        Console.Write(" ");
    }
    
    for (int j = 0; j < a4; j++)
    {
        Console.Write("*");
    }

    if (a4 == 1)
    {
        space = -1;
    }
    a4 -= space;
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();


int x = 1;

for (int i = 1; i <= 4; i++) {


    for (int j = 1; j <= 9; j++)
    {

        for (int k = x; k < x+i; k++)
        {

            Console.Write(k + " * " + j + " = " + (k*j) + "\t");

        }
        Console.WriteLine();
    }
    x+=i;

}

