using UnityEngine;

/// <summary>
/// Different behaviors of fly
/// </summary>
public class FlyWithRocket : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("Flying with rockets.");
    }
}
