using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2DSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            int[] scores = new int[5];

            for(int i=0; i<names.Length; i++)
            {
                Console.Write("{0}號同學姓名：", i+1);
                names[i] = Console.ReadLine();
                Console.Write("{0}號同學成績：", i + 1);
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(scores, names); 
            Array.Reverse(scores); 
            Array.Reverse(names);
            for(int i=0; i<names.Length;i++)
            {
                Console.WriteLine("{0}的成績是{1}", names[i], scores[i]);
            }
            Console.ReadLine();
        }
    }
}
