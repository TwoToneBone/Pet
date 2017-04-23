using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leader = new int[2];

            for (int i = 0; i < 5; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');

                int sum = int.Parse(inputs[0]) + int.Parse(inputs[1]) + int.Parse(inputs[2]) + int.Parse(inputs[3]);

                if (sum > leader[1])
                {
                    leader[0] = i + 1;
                    leader[1] = sum;
                }
            }
            
            Console.WriteLine(leader[0] + " " + leader[1]);

        }
    }
}
