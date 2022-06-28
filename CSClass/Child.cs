using System;

namespace CSClass
{
    public class Child : Parent
    {
        private string v;


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