using UnityEngine;

/// <summary>
///  Quack
/// </summary>
public class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        Debug.Log("Quack~Quack~");
    }
}
