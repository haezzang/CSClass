using System;

namespace CSClass
{
    public class Parent


    {


        public int variable = 273;


        public virtual void Method() {
            Console.WriteLine("부모의 메서드");
        }


        public virtual void Method2()
        {
            Console.WriteLine("자식의 메서드");
        }


        public Parent( )
        {

            
            Console.WriteLine("Parent()");
        }
        public Parent(int param) {
            Console.WriteLine("Parent(int parame)");
        }
        public Parent(String input)
        {
            Console.WriteLine("Parent(String param)");


        }
    }
}