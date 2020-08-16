using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Example");
            Console.WriteLine("Bridge is a structural design pattern that divides business logic or huge class into separate class hierarchies that can be developed independently.");
            Console.WriteLine("One of these hierarchies (often called the Abstraction) will get a reference to an object of the second hierarchy (Implementation).");
            Console.WriteLine("The abstraction will be able to delegate some (sometimes, most) of its calls to the implementations object. ");
            Console.WriteLine("Since all implementations will have a common interface, they’d be interchangeable inside the abstraction.");
            Console.WriteLine();

            Client client = new Client();

            // the client code should be able to work with any pre-configured abstraction-implementation combination.
            Abstraction abstraction;            
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}