using System;

int[,] maxrix = { { 1, 2, 3 }, { 4, 5, 6 } };

int [,] transpose(int[,] maxrix)
{
    int col = maxrix.GetLength(0);
    int row = maxrix.GetLength(1);

    int[,] result = new int[row, col];

    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            result[j, i] = maxrix[i, j];
        }
    }

    return result;
}

int[,] value = transpose(maxrix);
for (int i = 0; i < value.GetLength(0); i++)
{
    for (int j = 0; j < value.GetLength(1); j++)
    {
        Console.Write(value[i, j] + " ");
    }
    Console.WriteLine();
}



Console.WriteLine();
Console.WriteLine();



char[] com = { 'C', 'o', 'm', 'p', 'u', 't', 'e', 'r' };
foreach (char c in com)
{
    Console.Write(c + " ");
}


Console.WriteLine();
Console.WriteLine();



int[][] q3 = new int[][] {
    new int[] { 0, 1, 2 },
    new int[] { 4, 5, 6, 7 },
    new int[] { 10, 11, 12, 13, 14 }
};

for (int i = 0; i < q3.Length; i++)
{
    for (int j = 0; j < q3.Length; j++)
    {
        Console.Write(q3[i][j] + " ");
    }
    Console.WriteLine();
}



Console.WriteLine();
Console.WriteLine();



Random r = new Random();
int[] q4= new int[5]; 
for (int i = 0; i < 5; i++)
{
    q4[i] = r.Next(100);
}
Array.Sort(q4);
Array.Reverse(q4);
foreach (int i in q4)
{
    Console.Write(i + "\t");
}



Console.WriteLine();
Console.WriteLine();


double[] q5 = new double[5];
for (int i = 0; i < 5; i++)
{
    q5[i] = r.NextDouble() * 100;
}
Array.Sort(q5);
Array.Reverse(q5);
foreach (double i in q5)
{
    Console.Write(i + "\t");
}


Console.WriteLine();
Console.WriteLine();

int[,] q6_1 = new int [2, 2] { { 1, 2 }, { 3, 4 } };
int[,] q6_2 = new int [2, 2] { { 5, 6 }, { 7, 8 } };

int[,] multi_arr(int[,] q6_1, int[,] q6_2)
{
    int rows1 = q6_1.GetLength(0);
    int cols1 = q6_1.GetLength(1);
    int rows2 = q6_2.GetLength(0);
    int cols2 = q6_2.GetLength(1);

    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += q6_1[i, k] * q6_2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}

int[,] result = multi_arr(q6_1, q6_2);

for  (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}




Console.WriteLine();
Console.WriteLine();





int[] 학번 = new int[5];
int[] 국어 = new int[5];
int[] 영어 = new int[5];
int[] 수학 = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write((i + 1) + " 번째 학생 학번 입력: ");
    학번[i] = int.Parse(Console.ReadLine());
    Console.Write("국어 입력: ");
    국어[i] = int.Parse(Console.ReadLine());
    Console.Write("영어 입력: ");
    영어[i] = int.Parse(Console.ReadLine());
    Console.Write("수학 입력: ");
    수학[i] = int.Parse(Console.ReadLine());
}

double 국어총점 = 0;
double 영어총점 = 0;
double 수학총점 = 0;

for (int i = 0; i < 5; i++)
{
    Console.Write("학번 " + 학번[i] + " 의 평균: " + ((국어[i] + 영어[i] + 수학[i]) / 3) );
    Console.WriteLine(" | 총점: " + (국어[i] + 영어[i] + 수학[i]));
    국어총점 += 국어[i];
    영어총점 += 영어[i];
    수학총점 += 수학[i];
}
Console.WriteLine("국어 평균: " + 국어총점 / 5);
Console.WriteLine("영어 평균: " + 영어총점 / 5);
Console.WriteLine("수학 평균: " + 수학총점 / 5);



Console.WriteLine();
Console.WriteLine();




Console.Write("마방진 - 홀수 입력 :");
int N = int.Parse(Console.ReadLine());
int[,] arr = new int[N, N]; 

int row = 0;
int col = N / 2;

for (int i = 1; i <= N * N; i++)
{
    arr[row, col] = i; 

    int nextRow = row - 1;
    int nextCol = col - 1;


    if (nextRow < 0) { 
        nextRow = N - 1;
    }

    if (nextCol < 0) { 
        nextCol = N - 1;
    }

    if (i % N == 0)
    {
        row = (row + 1) % N;
    }
    else
    { 
        row = nextRow;
        col = nextCol;
    }
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}