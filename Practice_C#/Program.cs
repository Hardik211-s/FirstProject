using System;

//// Base class (Parent Class)
//interface Animal
//{
//    void getArea();
//    public string getClass();
//}

//// Derived class (Child Class) inheriting from Animal
//public abstract class Dog :Animal 
//{
//    public static int counter = 0;
//    void getArea() {
//    }
//    public static void SerialCounter() {  counter++; }  
   
//}

// Derived class (Child Class) inheriting from Animal
//public class Cat : Dog, Animal
//{
//    public string getClass()
//    {
//        Dog.SerialCounter();    
//        Console.WriteLine(Dog.counter);
//        return GetType().Name;
//    }
//    public void getArea()
//    {
//        Console.WriteLine("this is base class");
//    }
//}

//this is hardik savaliya code for practice pull request
public class A
{
    public A()
    {
        Console.WriteLine(" a constructor");
    }
    int y;
    public A(int g,int y)
    {
        y = g;
        Console.WriteLine(" aaaaaaa constructor");
    }
    public virtual  void print()
    {
        Console.WriteLine("class A");
    }
}

public class B :A
{
    //public B()
    //{
    //    Console.WriteLine(" B constructor");
    //}
    public B(int value)
    {
        Console.WriteLine(" BBBB constructor");
    }
    public override void print()
    {
        Console.WriteLine("class B");
    }
}

public class Program
{
    public static void Main()
    {
        //Animal aml = new Cat();
        //aml.getArea();

        //Console.WriteLine(aml.getClass());
        A a = new B(79897);
        a.print();
    }
}
