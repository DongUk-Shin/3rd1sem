
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
    int user;
    int com;
    Random r;

    public Srp()
    {
        r = new Random();
    }

    public override void result()
    {

        com = r.Next(1, 4);

        string result = "";
        if (com == 1) result = "가위";
        else if (com == 2) result = "바위";
        else if (com == 3) result = "보";
        
            
        Console.WriteLine("컴퓨터는 " + result + "를 냈습니다.");

        if (com == user)
        {
            Console.WriteLine("비겼습니다.");
            drawMatch++;
        }
        else if ((com == 1 && user == 3) || (com == 2 && user == 1) || (com == 3 && user == 2))
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

    public void play()
    {

        while (true)
        {
            Console.Write("입력하세요 [가위(1), 바위(2), 보(3), 종료(0)] : ");
            int i = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                return;
            }

            this.user = i;
            result();
        }
        
    }
}

class Mjb : Srp
{
    int usr;
    int com;
    int whoAttack = -1;
    Random rand = new Random();

    public Mjb()
    {
        com = rand.Next(1, 4);
    }
    public int check()
    {
        if (usr != 1 && com > usr) return -1; 
        
        else if (com == usr) return 0;   
        
        else if (usr == 1 && com == 3) return 1;   
        
        else return 1;  
        
    }



    public void play()
    {
        Console.Write("입력하세요 [가위(1), 바위(2), 보(3), 종료(0)] : ");
        int i = Convert.ToInt32(Console.ReadLine());
        com = rand.Next(1, 4);

        if (i == 0) return;
      
        usr = i;

        result();
    }

    public override void result()
    {
        int who;

        if (com == usr)
        {
            Console.WriteLine("비겼습니다.");
            who = 0;
        }
        else if ((com == 1 && usr == 3) || (com == 2 && usr == 1) || (com == 3 && usr == 2))
        {
            who = -1;
        }
        else
        {
            who = 1;
        }
        Console.WriteLine("");

        string result = "";
        if (com == 1) result = "가위";
        
        else if (com == 2)  result = "바위";
        
        else if (com == 3) result = "보";
        
        Console.WriteLine("컴퓨터는 " + result + "를 냈습니다.");




        if (whoAttack == -1)
        {
            if (who == 0)
            {
                Console.WriteLine("비겼습니다.\n");
                play();
            }
            else if (who == -1)
            {
                Console.WriteLine("공격자는 컴퓨터입니다.\n");
                whoAttack = 0;
                play();
            }
            else
            {
                Console.WriteLine("공격자는 유저입니다.\n");
                whoAttack = 1;
                play();
            }
        }

        else if (whoAttack == 1)
        {
            if (who == 0)
            {
                Console.WriteLine("이겼습니다.\n");
                userWin++;
            }
            else if (who == -1)
            {
                Console.WriteLine("공격자는 컴퓨터입니다.\n");
                whoAttack = 0;
                play();
            }
            else
            {
                Console.WriteLine("공격자는 유저입니다.\n");
                play();
            }
        }

        else
        {
            if (who == 0)
            {
                Console.WriteLine("졌습니다.");
                computerWin++;
            }
            else if (who == -1)
            {
                Console.WriteLine("공격자는 유저입니다.");
                whoAttack = 1;
                play();
            }
            else
            {
                Console.WriteLine("공격자는 컴퓨터입니다.");
                play();
            }
        }
    }
}






class Program
{
    static void Main(string[] args)
    {
        Console.Write("선택하세요 [가위바위보 게임(1), 묵찌빠 게임(2)] : ");
        int i = Convert.ToInt32(Console.ReadLine());

        if (i == 1)
        {
            Srp s = new Srp();
            s.play();
            s.recordPrint();

        }
        else if(i == 2) {
            Mjb m = new Mjb();
            m.play();
            m.recordPrint();
        }
    }
}

