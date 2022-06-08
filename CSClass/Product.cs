using System;

namespace CSClass
{
     class Product
    {
         public  static int  counter=0;
        public string name="노네임";
        public int price=1000;
           private int  id;
        private string v1;
        private int v2;



        public Product()
        {
            this.id = counter;
            counter = counter + 1;
            this.name = name;
            this.price = price;
        }
        public Product(string name, int price)
        {
            this.id = counter;
            counter=counter+1;
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return "["+this.id+"]"+this.name + " : " + this.price;
        }

        ~Product() {
            Console.WriteLine(this.name+"소멸자 호출");
        }
    }


}