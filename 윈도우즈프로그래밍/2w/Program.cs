using System;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("|b^2 - 4ac|");
        double a, b, c;
        Console.Write("a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c: ");
        c = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Abs((Math.Pow(b, 2) - (4 * a * c))));


        Console.WriteLine("\nlog10(x+y)^3");
        double x, y;
        Console.Write("x: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y: ");
        y = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Log10(Math.Pow(x + y, 3)));
        
        Console.WriteLine("\nroot((x1 - x2) ^ 2 + (y1 - y2) ^ 2)");
        double x1, y1, x2, y2;
        Console.Write("x1: ");
        x1 = double.Parse(Console.ReadLine());
        Console.Write("y1: ");
        y1 = double.Parse(Console.ReadLine());
        Console.Write("x2: ");
        x2 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        y2 = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

        Console.WriteLine("===========================================");
        int 원금, 기간;
        double 이율;
        Console.WriteLine("S=원금*(1+이율)^기간");
        Console.Write("원금: ");
        원금 = int.Parse(Console.ReadLine());
        Console.Write("기간: ");
        기간 = int.Parse(Console.ReadLine());
        Console.Write("이율: ");
        이율 = int.Parse(Console.ReadLine());

        Console.WriteLine("원리합계: " + (원금 * Math.Pow((1 + 이율), 기간)));

        Console.WriteLine("===========================================");

        Console.WriteLine("S = 4*파이*r^2");
        double r;
        Console.Write("r: ");
        r = double.Parse(Console.ReadLine());
        Console.WriteLine("원의 면적: " + 4 * Math.PI * Math.Pow(r, 2));

        Console.WriteLine("===========================================");


        int year;
        Console.Write("year: ");
        year = int.Parse(Console.ReadLine());

        //윤년 : 4의 배수, 그리고 100의 배수가 아닐때
        //또는 400의 배수일 때
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("윤년입니다 ");
        }
        else
        {
            Console.WriteLine("윤년이 아닙니다 ");
        }

        Console.WriteLine("===========================================");
        int[] arr = new int[10];

        Console.WriteLine("10개 정수 입력: ");

        int max = -1;
        for (int i = 0; i < 10; i++) {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] > max) {
                max = arr[i];
            }
        }

        Console.WriteLine("최댓값: " + max);


    }
}
