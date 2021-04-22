﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // keyword
            // int as;
            // context keyword
            int 한글;
            // int has space;
            // int 263alpha;
            // int break;
            var name = "강소리";
            Console.WriteLine("Hello");

            // 출력
            Console.Write("이건 안개행");
            Console.Write("입니당\n");

            Console.WriteLine("");
            Console.WriteLine("이건 개행");

            // 자료형 (Data Type)
            // Integer
            Console.WriteLine(53 + 272 - 123);
            Console.WriteLine(53 * 3 - 3);
            Console.WriteLine(14 / 2); // 7
            Console.WriteLine(14 / 3); // 4
            Console.WriteLine(14 % 3); // 2

            // Real Number
            Console.WriteLine(13.123);
            Console.WriteLine(0);
            Console.WriteLine(0.0);

            Console.WriteLine(14.0 / 2.0); // 7
            Console.WriteLine(14.0 / 3.0); // 4.6666666666667

            Console.WriteLine(14.0 / 7.0);
            Console.WriteLine(14 / 7);
            Console.WriteLine(14.0 / 7);
            Console.WriteLine(14 / 7.0);

            Console.WriteLine(14.0 / 3.0);
            Console.WriteLine(14.0 / 3);
            Console.WriteLine(14 / 3.0);
            Console.WriteLine(14 / 3);

            // Character
            Console.WriteLine('A'); // 문자
            Console.WriteLine("A"); // 문자열

            // Escape Character
            Console.WriteLine("\t 탭 \\ 역슬래시 \n 개행 \" ");
            Console.WriteLine("미\t림여자정보과학고등학교");
            Console.WriteLine("미림\t여자정보과학고등학교");
            Console.WriteLine("미림여\t자정보과학고등학교");
            Console.WriteLine("미림여자정\t보과학고등학교");
            Console.WriteLine("미림여자정보과\t학고등학교");
            Console.WriteLine("미림여자정보과학고\t등학교");
            Console.WriteLine("미림여자정보과학고등학\t교");

            // 문자열 연결 연산자
            // concat concatentae operator
            // concatenation operator
            Console.WriteLine("ABC" + "DEF");
            Console.WriteLine('A' + 'E');
            Console.WriteLine("ABC" + 'E');

            Console.WriteLine("ABC"[2]);

            Console.WriteLine("ABC"[3]);

            // bool
            bool isPlay = true;
            bool isDeath = false;

            // comparison operator
            Console.WriteLine(52 == 163);
            Console.WriteLine(52 != 163);
            Console.WriteLine(52 > 163);
            Console.WriteLine(52 < 163);
            Console.WriteLine(52 >= 163);
            Console.WriteLine(52 <= 163);

            // Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true || false);
            Console.WriteLine(true && false);

            // 단항 연산자 - unary operator
            int i = 0;
            i++;
            // 이항 연산자 - binary operator
            i = i + 2;
            // 삼항 연산자 - ternary operator
            int j;
            j = (i > 3) ? 0 : 1;

        }
    }
}
