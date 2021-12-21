using UnityEngine;

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        QuackBehavior = new Squeak();
        FlyBehavior = new FlyWithWings();
    }

   public override void Dispaly()
    {
        Debug.Log("I'm a redhead duck.");
    }
}


