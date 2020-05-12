using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            //개미수열
            String sequence = "1";
            int n = 1;
            while(n<=20)
            {
                Console.WriteLine(n + "번째 수열 : " + sequence);
                char num = sequence[0];
                int count = 0;
                string temp = " ";
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (num == sequence[i])
                        count++;
                    else
                    {
                        temp += "" + num + count;
                        count = 0;
                        num = sequence[i];
                        count++;
                    }
                    if (i + 1 == sequence.Length)
                        temp += "" + num + count;
                }
                sequence = temp;
                n++;
            }
        }
    }
}
