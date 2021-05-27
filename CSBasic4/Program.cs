using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic4
{
    class Studnet
    {
        public string id;
        public string name;
        public int grade;
        public string major;
        public DateTime birthday;
    }
    class Student2
    {
        public string name;
        public int grade;
    }
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
    class FirstClass
    {

    }
    class SecondClass
    {

    }
    class User
    {
        public string name;
        public string password;
        public string address;
        public string phoneNumber;
        public DateTime regDate;
    }

    class Program
    {
        class Product
        {
            public string name = "default";
            public int price = 1000;
        }
        class MyMath
        {
            public static double PI = 3.141592;
        }

        static void Main(string[] args)
        {
            List<Student2> list = new List<Student2>();

            list.Add(new Student2() { name = "윤인성", grade = 1 });
            list.Add(new Student2() { name = "연하진", grade = 2 });
            list.Add(new Student2() { name = "윤아린", grade = 3 });
            list.Add(new Student2() { name = "윤명월", grade = 4 });
            list.Add(new Student2() { name = "구지연", grade = 1 });
            list.Add(new Student2() { name = "김연화", grade = 2 });

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }

            List<Student2> list2 = new List<Student2>()
            {
                new Student2() { name = "윤인성", grade = 1 },
                new Student2() { name = "연하진", grade = 2 },
                new Student2() { name = "윤아린", grade = 3 },
                new Student2() { name = "윤명월", grade = 4 },
                new Student2() { name = "구지연", grade = 1 },
                new Student2() { name = "김연화", grade = 2 }

            };

            // 오류 발생 => foreach 반복문을 사용해서는 요소 제거를 할 수 없다.
            /*
            foreach (var item in list)
            {
                if(item.grade > 1)
                {
                    list.Remove(item);
                }
            }
            */

            for(int i=0; i<list.Count-1; i++)
            {
                if(list[i].grade > 1)
                {
                    list.RemoveAt(i);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }

            Console.WriteLine(MyMath.PI);

            Product product = new Product();

            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + " : " + product.price + "원");

            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { name = "고구마", price = 3000 };

            // Car[] cars = new Car[10];
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());

            int[] intArray = new int[10];
            long[] longArray = new long[10];
            string[] stringArray = new string[10];

            List<int> list = new List<int>();

            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);

            foreach(var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
        }
    }

}
