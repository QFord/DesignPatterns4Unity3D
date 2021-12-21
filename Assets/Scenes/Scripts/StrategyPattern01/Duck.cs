
/// <summary>
/// Base Class
/// </summary>
public abstract  class Duck
{
    /// <summary>
    /// 动态设定行为-Dynamic setting behavior
    /// </summary>
    /// <value></value>
    public IFlyBehavior FlyBehavior { get; set; }
    public IQuackBehavior QuackBehavior{ get; set; }

    protected Duck()
    {

    }

    public abstract void Dispaly();

    public void PerformFly()
    {
        //UnityEngine.Debug.Log((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name);
        FlyBehavior.Fly();
    }

    public void PerformQuack()
    {
        //UnityEngine.Debug.Log((new System.Diagnostics.StackTrace()).GetFrame(1).GetMethod().Name);
        QuackBehavior.Quack();
    }

    public void Swim()
    {
        UnityEngine.Debug.Log("All ducks float,even decoys!");
    }

}



