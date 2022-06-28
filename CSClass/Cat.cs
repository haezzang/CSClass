using System;

namespace CSClass
{
    public class Cat : Animal
    {

        public new void Eat()
        {
            Console.WriteLine("고양이 냐냐 먹는다");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥");
        }
    }
}