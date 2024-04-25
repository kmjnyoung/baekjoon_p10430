using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baekjoon_p10430
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] abc =Console.ReadLine().Split(' '); // 첫 째 줄에 a, b, c가 주어져야 하므로 배열을 이용하고 입력을 받음, 문자열이므로 string
            int a = int.Parse(abc[0]); // string을 정수형인 int로 형변환
            int b = int.Parse(abc[1]);
            int c = int.Parse(abc[2]);
            // 문제에 나온 식들을 하나씩 계산하여 같은지 확인, 출력시 줄이 바뀌어야 하므로 Consloe.WriterLine사용
            Console.WriteLine((a + b) % c); 
            Console.WriteLine(((a % c) + (b % c)) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine(((a % c) * (b % c)) % c);
        }
    }
}
