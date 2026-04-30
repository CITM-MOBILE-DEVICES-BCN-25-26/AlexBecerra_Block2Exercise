
public interface ISkill
{
    public int ApplySkill(int baseDamage);
}

public class Fire: ISkill
{
    public int ApplySkill(int baseDamage)
    {
        return baseDamage + 10;
    }
}
public class Ice : ISkill
{
    public int ApplySkill(int baseDamage)
    {
        return baseDamage + 5;
    }
}
public class Poison : ISkill
{
    public int ApplySkill(int baseDamage)
    {
        return baseDamage + 2;
    }
}
public class SkillSystem
{
    public int PerformSkill(ISkill iSkill, int baseDamage)
    {
       return iSkill.ApplySkill(baseDamage);
    }
}
