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

            int output = 0;
            for(int j=0; j<=100; j++)
            {
                output += i;
            }
            Console.WriteLine(output);

            int output2 = 1;

            for(int k=1; k<=20; k++)
            {
                output2 += i;
            }
            Console.WriteLine(output2);

            for(int p='가'; p<='힣'; p++)
            {
                Console.Write((char)p);
            }

            int[] intArray3 = { 1, 2, 3, 4, 5, 6 };
            
            for(int n=intArray3.Length-1; n>=0; n--)
            {
                Console.WriteLine(intArray3[i]);
            }
        }
    }
}