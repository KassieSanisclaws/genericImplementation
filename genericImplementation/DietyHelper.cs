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

    public void SRankAtk()
    {
        Data.SpAtkS();
        Data.Attack();

    }
    public void SpAbility()
    {
        Data.SpAbility();
    }
}

public abstract class DietyGuardian : MegaSAttack
{
    public string Name;
    public int Health;
    public int Dmg;
    public int Level;
    public string Skill;
    public string? Ability;
    public string SpecialAttack;
    public string UltimateAttack;
    public string? MegaAttack;
    public string Origin;
    public string Species;
    public string Description;
    public int HeightInFEET;
    public int WeightInLBS;

    public void Attack()
    {
        Console.WriteLine($"{Name} did {Dmg} dmg");
    }

    public void SpAtkS()
    {
        Console.WriteLine($"{Name} used {SpecialAttack} Atk");
    }

    public void SpAbility()
    {
        Console.WriteLine($"{Name} used {Ability} ability");
    }
    public void MegaSAttack()
    {
        throw new NotImplementedException();
    }
}

public class MegaSAttack
{

}

public class SpiritDietyGuardian : DietyGuardian
{

}

public class Samurai : DietyGuardian
{
    public Samurai(int dmg)
    {

    }

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

public class ElementalDracons : DietyGuardian
{
    public void MegaSAttack()
    {
        throw new NotImplementedException();
    }

}

public interface FinalMove
{
    void MegaSAttack();
}