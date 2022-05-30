namespace CSClass
{
     class Product
    {

        public string name;
        public int price;

        public override string ToString()
        {
            return this.name + " : " + this.price;
        }
    }
}