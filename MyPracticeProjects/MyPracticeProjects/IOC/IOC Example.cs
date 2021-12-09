using System;

/// <summary>
/// This class example is for Inversion of Control Principle
/// Factory Patteren is used to control object creation for Object B
/// Dependency between A AND B is no more , Factory class is taking care for that.
/// </summary>
namespace MyPracticeProjects
{  
       
            public class A
            {
                B b;

                public A()
                {
                     b = Factory.GetObjectOfB();
                }

                public void Task1()
                {
                        
                        Console.WriteLine("This is a Class A Instance, Object " + this.GetType().Name);
                        b.SomeMethod();
                }

            }

            public class Factory
            {
                public static B GetObjectOfB()
                {
                    return new B();
                }

                public static A GetObjectOfA()
                {
                    return new A();
                }
            }
    

            public class B
            {

                public void SomeMethod()
                {
                    Console.WriteLine("Enter some text to proceed");
                    Console.ReadLine();
                    Console.WriteLine("This is a Class B Instance Object " + this.GetType().Name);
                    Console.WriteLine("Enter some text to proceed");
                    Console.ReadLine();
                }
            }


}
