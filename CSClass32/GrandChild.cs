using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass32
{
    public class GrandChild : Child
    {
        public override void Method2()
        {
            Console.WriteLine("손자 메서드!!");
        }
    }
}
