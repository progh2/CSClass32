using System;

namespace CSClass32
{
    public class Child : Parent
    {
        public new string variable = "hiding";

        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }

        public override void Method2()
        {
            Console.WriteLine("자식의 메서드");
        }

        public Child() : base(10)
        {
            Console.WriteLine("Child():base(10)");
        }
        public Child(string input) : base(input)
        {
            Console.WriteLine("Child(string input):base(input)");
        }

        public void CountChiild()
        {
            Child.counter++;
        }

    }
}