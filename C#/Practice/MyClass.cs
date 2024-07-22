public interface IDerivedInterface
{
    void DoSomething();
}

public class BaseClass: IDerivedInterface
{
    public int MyInt { get; set; }
    public virtual void DoSomething()
    {
        Console.WriteLine("Doing something in the base class.");
    }

    protected virtual void SealedMethod()
    {
        Console.WriteLine("This method is sealed and cannot be overridden.");
    }

    public int this[int index]
    {
        get
        {
            return index * 2;
        }
    }

    public int TestMe(int a) => (int)Math.Pow(a, 2);
}

public class DerivedClass : BaseClass
{
    public new int MyInt { get; set; }
    public override sealed void DoSomething()
    {
        Console.WriteLine("Doing something in the derived class.");
    }

    // The following line will not compile, as SealedMethod is sealed and cannot be overridden
    // public override void SealedMethod()
    // {
    //     Console.WriteLine("Attempting to override the sealed method.");
    // }
}

public class ThirdClass : DerivedClass, IDerivedInterface  // inhterits and implements
{
    // The following line will not compile, as DoSomething is sealed and cannot be overridden
    // public override void DoSomething()
    // {
    //     Console.WriteLine("Attempting to override the sealed method.");
    // }
}