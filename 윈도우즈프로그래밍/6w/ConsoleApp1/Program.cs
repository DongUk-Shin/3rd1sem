class Fraction
{
    public int numberator; 
    public int denominator; 

    public Fraction(int a)
    {
        numberator = a;
        denominator = 0;
    } 

    public Fraction(int a, int b)
    {
        numberator = a;
        denominator = b;
    } 

    public override string ToString()   
    {
        return "(" + numberator + " / " + denominator + ")";
    }

    public int GratestCommonDivisor(int a, int b) //최대공약수
    {

        for (int i = 2; i <= Math.Min(a, b); i++)
        {
            if (a % i == 0 && b % i == 0)
            {
                return i;
            }
        }
        return 1;
    }
    public void irreducibleFraction(Fraction f) //기약분수
    {
        
        int t = f.GratestCommonDivisor(f.numberator, f.denominator);
        int n = f.numberator / t;
        int d = f.denominator / t;

        Console.WriteLine("기약분수로 표현한 분수식: " + n + " / " + d);
    }


    public void addFraction(Fraction a, Fraction b)
    {
        Fraction t = new Fraction(0);
        t.denominator = a.denominator * b.denominator;
        t.numberator = a.numberator * b.denominator + b.numberator * a.denominator;

        Console.WriteLine("f1 + f2 = " + t.ToString());

    }

    public void subFraction(Fraction a, Fraction b)
    {
        Fraction t = new Fraction(0);
        t.denominator = a.denominator * b.denominator;
        t.numberator = a.numberator * b.denominator - b.numberator * a.denominator;

        Console.WriteLine("f1 - f2 = " + t.ToString());
    }

    public void mulFraction(Fraction a, Fraction b)
    {
        Fraction t = new Fraction(0);
        t.numberator = a.numberator * b.numberator;
        t.denominator = a.denominator * b.denominator;

        Console.WriteLine("f1 * f2 = " + t.ToString());
    }

    public void divFraction(Fraction a, Fraction b)
    {
        Fraction t = new Fraction(0);

        t.numberator = a.numberator * b.denominator;
        t.denominator = a.denominator *  b.numberator;

        Console.WriteLine("f1 ÷ f2 = " + t.ToString());
    }



    class Test // 선언된 클래스 Fraction의 메소드를 테스트 하기 위해 테스트 클래스를 선언.
    {
        static void Main(string[] args)
        {
            Fraction f1, f2; 

            f1 = new Fraction(5, 6);
            f2 = new Fraction(2, 4);
            Console.WriteLine("분수식 f1: " + f1.ToString());
            Console.WriteLine("분수식 f2: " + f2.ToString());

            Console.WriteLine("분수식 f1의 최대공약수: "
            + f1.GratestCommonDivisor(f1.numberator, f1.denominator));

            Console.WriteLine("분수식 f2의 최대공약수: "
            + f2.GratestCommonDivisor(f2.numberator, f2.denominator));

            f1.irreducibleFraction(f1);
            f2.irreducibleFraction(f2); 

            f1.addFraction(f1, f2);
            f1.subFraction(f1, f2);
            f1.mulFraction(f1, f2);
            f1.divFraction(f1, f2);

        }
    }
}