using ObseverPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var subject = new Subject();
        var concreteObserverA = new ConcreteObserverA();
        var concreteObserverB = new ConcreteObserverB();
        // 将需要通知的观察类加入列表中
        subject.Attach(concreteObserverA);
        subject.Attach(concreteObserverB);
        // 触发通知
        subject.SomeLogic();
        subject.SomeLogic();

        subject.Detach(concreteObserverB);
        subject.SomeLogic();
    }
}