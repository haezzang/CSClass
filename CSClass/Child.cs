using System;

namespace CSClass
{
    public class Child : Parent
    {
        public new string variable = "shadowing";

        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
        public Child() : base(10) 
        {
            Console.WriteLine("Child() : base(10)");
        }
        public Child(string v)
        {
            Console.WriteLine("Child(String input) : base(input)");
        }
    }
}