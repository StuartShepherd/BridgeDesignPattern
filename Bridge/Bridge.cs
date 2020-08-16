using System;

namespace Bridge
{
    // the abstraction defines the interface for the "control" part of the two class hierarchies. 
    // it maintains a reference to an object of the implementation hierarchy and delegates all of the real work to this object.
    public class Abstraction
    {
        protected IImplementation _implementation;

        public Abstraction(IImplementation implementation)
        {
            this._implementation = implementation;
        }

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" +
                _implementation.OperationImplementation();
        }
    }

    // you can extend the abstraction without changing the implementation classes.
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }

    // the implementation defines the interface for all implementation classes.
    // it doesn't have to match the abstraction's interface. 
    // in fact, the two interfaces can be entirely different. 
    // typically the implementation interface provides only primitive operations, while the abstraction defines higher-level operations based on those primitives.
    public interface IImplementation
    {
        string OperationImplementation();
    }

    // each concrete implementation corresponds to a specific platform and implements the implementation interface using that platform's api.
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }

    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform B.\n";
        }
    }

    public class Client
    {
        // except for the initialization phase, where an abstraction object gets linked with a specific implementation object, the client code should only depend on the abstraction class. 
        // this way the client code can support any abstraction-implementation combination.
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}