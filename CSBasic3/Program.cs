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

            string[] array = { "사과", "배", "포도", "딸기", "바나나" };
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }

            foreach(var item in array)
            {
                Console.WriteLine(item);
            }

            for(int p=0; p<10; p++)
            {
                for(int j=0; j<p+1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for(int q=0; q<10; q++)
            {
                for (int z = 0; z < q + 1; z++)
                    Console.Write(' ');
                for (int w = 0; w < q + 1; w++)
                    Console.Write('*');
                Console.Write("\n");
            }

            while(true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료) >>> ");
                int input3 = int.Parse(Console.ReadLine());
                if(input3 %2 == 0)
                {
                    break;
                }
            }

            for(int r=1; r<10; r++)
            {
                if(r%2 == 0)
                {
                    continue;
                }
                Console.WriteLine(r);
            }

            for(int e=1; e<10; e++)
            {
                if(e%2 == 0)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}