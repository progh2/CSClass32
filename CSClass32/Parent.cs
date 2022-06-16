using System;

namespace CSClass32
{
    public class Parent
    //public sealed class Parent
    //public abstract class Parent
    {
        public static int counter = 0;
        public int variable = 273;

        //abstract public void Method3();

        public void Method()
        {
            Console.WriteLine("부모의 메서드");
        }

        public virtual void Method2()
        {
            Console.WriteLine("부모의 메서드");
        }

        public void CountParent()
        {
            Parent.counter++;
        }

        public Parent()
        {
            Console.WriteLine("Parent()");
        }
        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }

        public Parent(string param)
        {
            Console.WriteLine("Parent(string param)");
        }

    }
}