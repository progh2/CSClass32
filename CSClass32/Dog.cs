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

        public override void Eat()
        {
            Console.WriteLine("강아지 사료를 먹습니다.");
        }
    }
}