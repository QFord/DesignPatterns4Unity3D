using UnityEngine;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        this.FlyBehavior = new FlyNoWay();
        this.QuackBehavior = new Quack();
    }

    public override void Dispaly()
    {
        Debug.Log("I'm a model duck.");
    }
}


