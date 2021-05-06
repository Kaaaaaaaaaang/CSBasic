using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[100]); // 범위 초과
            Console.WriteLine(intArray[-1]); // 음수 사용 불가

            int i = 0;
            int[] intArray2 = { 52, 273, 32, 65, 103 };

            // 반복을 수행한다.
            while (i < intArray2.Length)
            {
                // 출력한다.
                Console.WriteLine(i + "번째 출력 : " + intArray2[i]);

                // 탈출을 위해 변수를 더한다.
                i++;
            }

            string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종료) :");
                input = Console.ReadLine();
            } while (input != "exit");
        }
    }
}