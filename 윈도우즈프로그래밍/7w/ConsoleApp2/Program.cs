
abstract class Game
{
    protected int userWin, computerWin, drawMatch;

    public Game()
    {
        userWin = computerWin = drawMatch = 0;
    }
    ~Game()
    {
        recordPrint();
    }

    public abstract void result();

    public void recordPrint()
    {
        Console.WriteLine(userWin + "승 " + computerWin + "패 " + drawMatch + "무승부 입니다 ");
    }

}

class Srp : Game
{

    int com;

    public Srp()
    {
        Random r = new Random();
        com = r.Next(1, 4);
    }

    public override void result()
    {

    }

    public void play()
    {

        while (true)
        {
            Console.Write("입력하세요 [가위(1), 바위(2), 보(3), 종료(0)] : ");
            int i = int.Parse(Console.ReadLine());

            if (i == 0 )
            {
                break;
            }

            string result = "";
            if (com == 1)
            {
                result = "가위";
            }
            else if (com == 2)
            {
                result = "바위";
            }
            else if (com == 3) 
            {
                result = "보";
            }

            Console.WriteLine("컴퓨터는 " + result + "를 냈습니다.");

            if (com == i)
            {
                Console.WriteLine("비겼습니다.");
                drawMatch++;
            }
            else if ((com == 1 && i == 3) || (com == 2 && i == 1) || (com == 3 && i == 2))
            {
                Console.WriteLine("졌습니다.");
                computerWin++;
            }
            else
            {
                Console.WriteLine("이겼습니다.");
                userWin++;
            }
            Console.WriteLine("");
        }


    }
}

class Mjp : Srp
{

}






class Program
{
    static void Main(string[] args)
    {
        Console.Write("선택하세요 [가위바위보 게임(1), 묵찌빠 게임(2)] : ");
        int i = Convert.ToInt32(Console.ReadLine());

        if (i == 1)
        {
            new Srp().play();
        }
        /*else if(i == 2) { 
            new Mjb().play(); 
        }*/
        else
        {
            Console.WriteLine("잘못 입력하셨습니다. ");
        }

    }
}