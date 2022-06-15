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
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);


            List<int> list = new List<int>() { 42, 356, 64, 643, 7 };
            /*            list. Add(1);
                        list.Add(2);
                        list.Add(3);   
                        list.Add(4);
                        list.Add(5);*/
            list.Remove(42); //요소 를 삭제
            list.RemoveAt(2); //인덱스를 삭제
            foreach (int i in list)
            {
                Console.WriteLine("Count : " + list.Count + "\t" + i);
            }


            Console.WriteLine(Math.Abs(-123));
            Console.WriteLine(Math.Ceiling(52.3456));
            Console.WriteLine(Math.Floor(52.3456));
            Console.WriteLine(Math.Round(52.3456));
            Console.WriteLine(Math.Round(52.3456, 3));
            Console.WriteLine(Math.Max(52, 3456));
            Console.WriteLine(Math.Min(52, 3456));
            Console.WriteLine(Math.PI);


            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { price = 6000, name = "고구마", };
            Product productC = new Product() { name = "옥수수", };


            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

            List<Student> students = new List<Student>() {
            new Student() { name = "조해정", grade = 22 },
            new Student() { name = "박종성", grade = 99 },
            new Student() { name = "박성훈", grade = 88 },
            new Student() { name = "이희승", grade = 77 },
            new Student() { name = "심재윤", grade = 77 },
            new Student() { name = "양정원", grade = 88 },
            new Student() { name = "김선우", grade = 99 },
            new Student() { name = "니키", grade = 100 }
            };

            /*            students.Add(new Student() { name = "박종성", grade = 99 });
                        students.Add(new Student() { name = "박성훈", grade = 88 });
                        students.Add(new Student() { name = "이희승", grade = 77 });
                        students.Add(new Student() { name = "심재윤", grade = 77 });
                        students.Add(new Student() { name = "양정원", grade = 88 });
                        students.Add(new Student() { name = "김선우", grade = 99 });
                        students.Add(new Student() { name = "니키", grade = 100 });*/


            /*            foreach (var student in students)
                        {
                            if (student.grade > 60) {
                                students.Remove(student);
                            }

                        }*/


            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                }
            }
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52.2));
            Console.WriteLine(MyMath.Abs(-52.3));
            Console.WriteLine(MyMath.Abs(52f));
            Console.WriteLine(MyMath.Abs(52L));

            Product productX = new Product("감자쫑",2000);

            Product productY = new Product("고구마", 2000);

            Console.WriteLine(productX);
            Console.WriteLine(productY);
            Console.WriteLine(Product.counter+ "개가 생성되었습니다" );


            SingleTon mySingle = SingleTon.getInstance();


            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();

            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");

            Product product = new Product("과자", 1500);
            productA = null;


            Box box = new Box(10, 20);
            box.Width = 200; 
            box.Height = 100; 
            Console.WriteLine(box.Area);

            box.Width = -10; 
            Console.WriteLine(box.Area);
            Box box2 = new Box(-10, -20);
            Console.WriteLine(box.Area);


            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(2));
            Console.WriteLine(Fibonacci.Get(3));
            Console.WriteLine(Fibonacci.Get(4));
            Console.WriteLine(Fibonacci.Get(5));

            Cat c = new Cat();
            Dog d = new Dog();

        }
    }
}



