using System;

namespace CSClass
{
    public class Parent


    {
        private int v;


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