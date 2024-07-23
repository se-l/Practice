### Access Modifiers:
[MSDocs](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers  )
- public - any assembly, any class
- private - only within the class
- protected - inherited by derived class 
- internal  - within the same assembly
- protected internal - protected OR internal  
- private protected - private OR protected  

### Modifiers:
- static
- abstract
- virtual
- sealed

**Interview Questions**
- [TestGorilla](https://www.testgorilla.com/blog/c-sharp-interview-questions/)

### Question Samples:  
Easy  
- How is C# different from C?
- What is a destructor in C#?
- What is an indexer in C#?

Intermediate   
- What is meant by object pooling in C#?
- What are boxing and unboxing in C#?
- How is serialization implemented in C#? Example of text and bytes...
- How is reflection used in C#? Examples of getting type, method, property, field, attribute, and invoking method.

### Adanced:
- When should multithreading be used and when should it be avoided in C#?
- What is the difference between late binding and early binding in C#?
- What is the difference between a throw exception and a throw clause in C#?

### Tricky:
- Difference between IEnumerable and IQueryable interfaces?
- async/await vs. Task.Run?
- Methods of sharing data between tasks in C#?
    - Thread-safe data structures like ConcurrentDictionary, ConcurrentQueue or synchronization constructs like lock, Monitor, and Semaphore.
- How do you implement a custom attribute in C#? Provide an example of how to use it to decorate a class.
-  Explain the differences between covariance and contravariance in C# for delegates and interfaces?
- Ways to avoid deadlocks? acquire locks in consistent order, timeouts.
- How do you implement a custom IComparer<T> for sorting in C#?
- Explain the concept of object pooling in C# and its benefits in multi-threaded applications?
- How to implement a custom serializer?
- Explain the differences between Memory<T> and Span<T> in C#. When would you use one over the other?
- Explain the differences between async void and async Task in C#. When would you use one over the other?

### Refactor code checlist:
- Any dependency injection possible? Instantiating external objects in constructor/method or passing as argument?
- Is it thread-safe?


### Notes:
- Control Statements? Switch, return, if-else, while, break, continue, for, goto, foreach, do-while
- Method overloading is an example of polymorphism
- Overloading? !Signature. Types, number and also order of parameters
- Using directive vs. using statement? Directive := import; Statement := with!
- What are the different types of garbage collection in C#? How can you configure them?
    - Workstation, server, concurrent
    - Mark and sweep, reference counting, generational
- ShallowCopy -> MemberWiseClone; DeepCopy -> Implement recursive copy