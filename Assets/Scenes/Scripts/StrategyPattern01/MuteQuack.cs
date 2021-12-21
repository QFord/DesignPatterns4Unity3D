using UnityEngine;

/// <summary>
/// Mute quack
/// </summary>
public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("Mute Quack~Silence");
    }
}
