public class DietyHelper<T> where T : DietyGuardian
{
    public T Data;

    public DietyHelper(T data)
    {
        Data = data;
    }

    public void Print()
    {
        Console.WriteLine(Data);
    }

    public void ImplementAttack()
    {
        Data.Attack();
    }
}

public abstract class DietyGuardian
{
    public string Name;
    public int Health;
    public int Dmg;
    public int Level;
    public string Skill;
    public string Ability;
    public string SpecialAttack;
    public string UltimateAttack;
    public string FinalMove;
    public string Origin;
    public string Species;
    public string Description;
    public int HeightInFEET;
    public int WeightInLBS;

    public void Attack()
    {
        Console.WriteLine($"{Name} did {Dmg} dmg");
    } 
}

public class SpiritDietyGuardian : DietyGuardian
{

}

public class Samurai : DietyGuardian
{

} 

public class ShadowCasher : DietyGuardian
{

}

public class DemiDemon : DietyGuardian
{

}

public class GoliethGiant : DietyGuardian
{

}