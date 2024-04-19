public interface Unit
{
    int getStrength();
    string getName();
    string getSkill();
    int getDamage();
    string getClan();
}


public abstract class ProtossUnit : Unit
{
    public abstract int getStrength();
    public abstract string getName();
    public abstract string getSkill();
    public abstract int getDamage();

    int Shield;
    public abstract int getShield();

    private string Clan;
    public string getClan()
    {
        return Clan;
    }

    public ProtossUnit(string clan)
    {
        Clan = clan;
    }
}



public class DarkTemplar : ProtossUnit
{

    string Name;
    string Skill;
    int Damage;
    int Shield;
    int Strength;

    public override int getStrength()
    {
        return Strength;
    }

    public override string getName()
    {
        return Name;
    }
    public override string getSkill()
    {
        return Skill;
    }
    public override int getDamage()
    {
        return Damage;
    }
    public override int getShield()
    {
        return Shield;
    }


    public DarkTemplar() : base("프로토스") {
        Name = "다크템플러";
        Skill = "클로킹";
        Damage = 45;
        Shield = 80;
        Strength = 40;
    }

}

public class Nexus
{
    public Nexus(int m)
    {
        if (m < 50)
        {
            Console.WriteLine("광물이 부족합니다");

        } else
        {
            Console.WriteLine("프로브 생산");
        }
    }

    public Nexus(int m, int g)
    {
        if (m < 300 || g < 300)
        {
            Console.WriteLine("광물 혹은 가스가 부족합니다");
        } else
        {
            Console.WriteLine("모선 생산");

        }
    }

}

class Test
{
    static void Main(string[] args)
    {
        ProtossUnit DT = new DarkTemplar();

        int Damage = DT.getDamage();
        int Strength = DT.getStrength();
        int Shield = DT.getShield();

        Console.WriteLine("종족: " + DT.getClan());
        Console.WriteLine("이름: " + DT.getName());
        Console.WriteLine("쉴드: " + Shield);
        Console.WriteLine("체력: " + Strength);
        Console.WriteLine("데미지: " + Damage.ToString());
        Console.WriteLine("스킬: " + DT.getSkill());

        Console.WriteLine();

        Nexus N1 = new Nexus(40);
        Nexus M1 = new Nexus(30, 30);

        Console.WriteLine();

        Nexus N2 = new Nexus(50);
        Nexus M2 = new Nexus(300, 300);

        Console.WriteLine();
    }


}