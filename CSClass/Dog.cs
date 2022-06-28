using System;

namespace CSClass
{
    public class Dog : Animal
    {


        
        string Color;


        public new void Eat() {
            Console.WriteLine("강아직 와귱 먹는다");
        }
        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}