using UnityEngine;


/// <summary>
/// Different behaviors of fly
/// </summary>
public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("I Can't fly.");
    }
}
