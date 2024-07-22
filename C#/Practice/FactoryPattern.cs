using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Key points:
/// Promotes loose coupling between client that runs the code and actual implementation of classes through Creator classes that expose a FactoryMethod 
/// instantiating the final product, instead of instantiating the product directly in client code.
/// Loose coupling further promoted by returning product of a paricular interface type, therefore each creator can change the concrete product type without breaking client code.

namespace Practice.FactoryPattern
{
    public interface IProduct
    {
        string Operation();
    }

    /// <summary>
    /// 
    /// </summary>
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }

    public class CreatorSub1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            Console.WriteLine("CreatorSub1.FactoryMethod");
            return new Product1();
        }
    }

    public class CreatorSub2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            Console.WriteLine("CreatorSub2.FactoryMethod");
            return new Product2();
        }
    }

    class Product1 : IProduct
    {
        public string Operation()
        {
            return "Product1.Operation";
        }
    }

    class Product2 : IProduct
    {
        public string Operation()
        {
            return "Product1.Operation";
        }
    }

    /// <summary>
    /// The client code works with an instance of a concrete creator. As long as the client keeps working with
    /// the creator via the base interface, you can pass it any creator's subclass.
    /// </summary>
    public class Client()
    {
        public static void Run()
        {
            IProduct p1 = new CreatorSub1().FactoryMethod();
            IProduct p2 = new CreatorSub2().FactoryMethod();
        }        
    }
}
