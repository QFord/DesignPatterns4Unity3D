using UnityEngine;

public class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new MuteQuack();
    }
    public override void Dispaly()
    {
        Debug.Log("I'm a decoy duck.");
    }
}


