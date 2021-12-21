using UnityEngine;
/// <summary>
/// Strategy Pattern Sample
/// 策略模式定义了算法族，分别封装起来，让它们之间可以互相替换，此模式让算法变化独立于使用算法的客户
/// The Strategy Pattern defines a family of algorithms, encapsulates each one,
/// and makes them interchangeable. Strategy lets the algorithm vary independently
/// from clients that use it.
/// </summary>
public class Test01 : MonoBehaviour
{
    void Start()
    {
        Duck mallardDuck = new MallardDuck();
        mallardDuck.PerformQuack();
        mallardDuck.PerformFly();

        Duck modelDuck = new ModelDuck();
        modelDuck.PerformFly();
        modelDuck.PerformQuack();

        DecoyDuck decoyDuck = new DecoyDuck();
        decoyDuck.PerformFly();
        decoyDuck.PerformQuack();
        decoyDuck.FlyBehavior = new FlyWithRocket();
        decoyDuck.PerformFly();

    }
}

