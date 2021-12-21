using UnityEngine;

/// <summary>
/// squeaks
/// </summary>
public class Squeak : IQuackBehavior
{
     void IQuackBehavior.Quack()
    {
        Debug.Log("Squeak~Squeak~");
    }
}
