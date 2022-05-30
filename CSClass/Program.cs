using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            
            car.SetInTime();
            car.SetOutTime();

             Random random = new Random();
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);


            List<int> list = new List<int>() { 42,356,64,643,7};
            /*            list. Add(1);
                        list.Add(2);
                        list.Add(3);   
                        list.Add(4);
                        list.Add(5);*/
            list.Remove(42); //요소 를 삭제
            list.RemoveAt(2); //인덱스를 삭제
            foreach (int i in list) { 
                Console.WriteLine("Count : "+list.Count+"\t"+i);
            }


            Console.WriteLine(Math.Abs(-123));
            Console.WriteLine(Math.Ceiling(52.3456));
            Console.WriteLine(Math.Floor(52.3456));
            Console.WriteLine(Math.Round(52.3456));
            Console.WriteLine(Math.Round(52.3456,3));
            Console.WriteLine(Math.Max(52,3456));
            Console.WriteLine(Math.Min(52, 3456));
            Console.WriteLine(Math.PI);
        }
    }

}
