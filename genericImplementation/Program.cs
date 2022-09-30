using System.ComponentModel;

var spiritDietyGuardian = new SpiritDietyGuardian()
{
    Name = "Dragsolgalio",
    Level = 340,
    Health = 800,
    Dmg = 700,
    Ability = "Gravity Void",
    Skill = "Immunity",
    SpecialAttack = "Draco Distortion Void",
    UltimateAttack = "Draco Void Meteor",
    MegaAttack = "Quantum Void",
    HeightInFEET = 13,
    WeightInLBS = 15000,
    Species = "Mythical Dragon",
    Origin = "UnKnown",
    Description = "Origins not known, some same it appear through a void, some say the legends god back to where it was conceaved along with the universe."
};

var helper = new DietyHelper<SpiritDietyGuardian>(spiritDietyGuardian);

helper.Print();
helper.ImplementAttack();
helper.SRankAtk();
helper.SpAbility();

T DietyGuardianFactory<T>(string dietyGuardianName) where T : DietyGuardian, new()
{
    T newDietyGaurdian = new T();
    newDietyGaurdian.Name = dietyGuardianName;
    return newDietyGaurdian;
}

var samurai = DietyGuardianFactory<Samurai>("Sarematouji");

void MegaSAttack<T>(T inputObject) where T : FinalMove
{
    inputObject.MegaSAttack();
}