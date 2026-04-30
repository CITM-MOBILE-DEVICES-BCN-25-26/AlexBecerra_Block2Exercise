using System;

public class RewardSystem
{
    public void GiveReward(IReward reward)
    {
       reward.GiveReward();
    }
}
public interface IReward
{
    public void GiveReward();
}

public class Coin: IReward
{
    public void GiveReward()
    {
        Console.WriteLine("Giving coins");
    }
}
public class Item : IReward
{
    public void GiveReward()
    {
        Console.WriteLine("Giving item");
    }
}
public class Unlockable : IReward
{
    public void GiveReward()
    {
        Console.WriteLine("Unlocking content");
    }
}