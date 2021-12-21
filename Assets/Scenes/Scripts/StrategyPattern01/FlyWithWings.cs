using UnityEngine;

/// <summary>
/// Different behaviors of fly
/// </summary>
public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("Fly with wings.");
    }
}
