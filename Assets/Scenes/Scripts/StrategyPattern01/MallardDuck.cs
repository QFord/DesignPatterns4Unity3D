using UnityEngine;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        QuackBehavior = new Quack();
        FlyBehavior = new FlyWithWings();
    }

    public override void Dispaly()
    {
        Debug.Log("I'm a real Mallard duck.");
    }
}
