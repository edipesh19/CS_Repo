// Use a lambda expression as an event handler.
using System;
// Declare a delegate type for an event.
delegate void MyEventHandler(int n);
// Declare a class that contains an event.
class MyEvent
{
    public event MyEventHandler SomeEvent;
    // This is called to raise the event.
    public void OnSomeEvent(int n)
    {
        if (SomeEvent != null)
            SomeEvent(n);
    }
}
class LambdaEventDemo
{
    static void Main()
    {
        MyEvent evt = new MyEvent();
        // Use a lambda expression as an event handler.
        evt.SomeEvent += (n) =>
        Console.WriteLine("Event received. Value is " + n);
        // Raise the event twice.
        evt.OnSomeEvent(1);
        evt.OnSomeEvent(2);
    }
}