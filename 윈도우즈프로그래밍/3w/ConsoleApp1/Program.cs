

int temp1 = 0;
for (int i = 1; i <= 100; i++)
{
    temp1 += (2 * i);
}
int temp2 = 1;
for (int i = 1; i <= 10; i++)
{
    temp2 *= i;
}
Console.WriteLine("1번 답: " + (temp1 + temp2) + "\n");


int temp3 = 0;
int f = 1;
for (int i = 1; i <= 10; i++)
{
    f *= i;
    temp3 += f;
}
Console.WriteLine("2-1번 답: " + temp3 + "\n");



double sum = 0.0;
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        sum -= 1.0 / i;
    }
    else
    {
        sum += 1.0 / i; 
    }
}
Console.WriteLine("2-2번 답: " + sum + "\n");


Console.WriteLine("3번 구구단: ");
for (int i = 1; i <= 9; i++)
{
    for (int j = 2; j <= 5; j++)
    {
        Console.Write($"{j} * {i} = {i * j}, ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 1; i <= 9; i++)
{
    for (int j = 6; j <= 9; j++)
    {
        Console.Write($"{j} * {i} = {i * j}, ");
    }
    Console.WriteLine();
}




Console.WriteLine("\n4번 답: ");
for (int i = 1; i < 100; i++)
{
    int c = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
            c++;
    }
    if (c == 2)
        Console.Write(i + " ");

}


Console.WriteLine("\n\n5번 답: ");
for (int i = 1; i <= 500; i++)
{
    int t = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0) {
            t += j;
        }
    }
    if (i == t) 
        Console.Write(i + " ");

}

Console.Write("\n\n6번 회문 판별\n수 입력: ");
string s = Console.ReadLine();

int length = s.Length;
bool flag = true;

for (int i = 0; i < length / 2; i++)
{
    if (s[i] != s[length - i - 1])
    {
        flag = false;
        break;
    }
}

if (flag)
    Console.WriteLine("회문입니다");
else
    Console.WriteLine("회문이 아닙니다");



Console.WriteLine("\n7번 암스트롱 수");

for (int i = 100; i <= 500; i++)
{
    int digit = i, original = i;

    int one = digit % 10;
    digit /= 10;
    int ten = digit % 10;
    digit /= 10;
    int hun = digit % 10;

    if (original == (Math.Pow(one, 3) + Math.Pow(ten, 3) + Math.Pow(hun, 3)))
    {
        Console.WriteLine(original + " ");
    }
}


Console.Write("\n8번 최소공배수, 최대공약수 구하기 \n첫번째 수 입력\t");
int input1 = int.Parse(Console.ReadLine());
Console.Write("두번째 수 입력 \t");
int input2 = int.Parse(Console.ReadLine());


int a = input1, b = input2;
while(b != 0)
{
    int temp = a % b;
    a = b;
    b = temp;
}
Console.WriteLine("최대공약수: " + a);
Console.WriteLine("최소공배수: " + ((input1 * input2) / a));


Console.WriteLine("\n9번 별찍기");
for (int i = 1; i < 10; i = i + 2)
{
    int space = (9 - i) / 2;
    for (int j = 0; j < space; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < space; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}

for (int i = 7; i >= 0; i = i - 2)
{
    int space = (9 - i) / 2;
    for (int j = 0; j < space; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    for (int j = 0; j < space; j++)
    {
        Console.Write(" ");
    }
    Console.WriteLine("");
}



Console.Write("\n10번 거스름돈\n상품가격을 입력하시오 (1000원 미만) ");
int price = int.Parse(Console.ReadLine());

int 오백원 = 0;
int 백원 = 0;
int 오십원 = 0;
int 십원 = 0;
int 오원 = 0;
int 일원 = 0;

while (price != 0)
{
    if (price >= 500)
    {
        price -= 500;
        오백원++;
        continue;
    }

    if (price >= 100)
    {
        price -= 100;
        백원++;
        continue;
    }

    if (price >= 50)
    {
        price -= 50;
        오십원++;
        continue;
    }
    if (price >= 10)
    {
        price -= 10;
        십원++;
        continue;
    }
    if (price >= 5)
    {
        price -= 5;
        오원++;
        continue;
    }
    if (price >= 1)
    {
        price -= 1;
        일원++;
        continue;
    }

}

Console.WriteLine("500원\t" + 오백원 + "개");
Console.WriteLine("100원\t" + 백원 + "개");
Console.WriteLine("50원\t" + 오십원 + "개");
Console.WriteLine("10원\t" + 십원 + "개");
Console.WriteLine("5원\t" + 오원 + "개");
Console.WriteLine("1원\t" + 일원 + "개");
