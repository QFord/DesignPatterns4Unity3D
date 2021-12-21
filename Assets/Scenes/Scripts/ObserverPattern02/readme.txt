1: https://refactoring.guru/design-patterns/observer/csharp/example
Observer is a behavioral design pattern that allows some objects to notify other objects about changes in their state.
观察者是一种行为设计模式，它允许一些对象通知其他对象其状态的变化。
The Observer pattern provides a way to subscribe and unsubscribe to and from these events for any object that
implements a subscriber interface.
观察者模式为任何实现订阅者接口的对象提供了订阅和取消订阅这些事件的方法。

2: https://docs.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern
The observer design pattern enables a subscriber to register with and receive notifications from a provider.
It is suitable for any scenario that requires push-based notification. The pattern defines a provider (also known as
a subject or an observable) and zero, one, or more observers. Observers register with the provider,
 and whenever a predefined condition, event, or state change occurs, the provider automatically notifies all observers by
calling one of their methods.In this method call, the provider can also provide current state information to observers. 
观察者设计模式允许订阅者向提供者注册并接收来自提供者的通知。它适用于任何需要基于推送的通知的场景。模式定义了提供者(也称为主体或可观察对象)和零个、一个或多个观察者。
观察者向提供者注册，当预定义的条件、事件或状态发生变化时，提供者会通过调用所有观察者的一个方法自动通知他们。在此方法调用中，提供程序还可以向观察者提供当前状态信息。在。

3：https://dofactory.com/net/observer-design-pattern

4：https://dotnettutorials.net/lesson/observer-design-pattern/