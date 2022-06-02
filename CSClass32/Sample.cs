using System;

namespace CSClass32
{
    class Sample
    {
        public static int value = 42;

        public Sample()
        {
            Console.WriteLine("Sample() 생성자 호출!!");
        }

        static Sample()
        {
            value = 99;
            Console.WriteLine("Sample() 정적 생성자 호출!!");
        }
    }
}