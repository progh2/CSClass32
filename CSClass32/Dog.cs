using System;

namespace CSClass32
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public void Bark()
        {
            //base.Eat();
            Console.WriteLine("왈왈 짖습니다.");
        }
    }
}