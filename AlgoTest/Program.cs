using System;
using Fisher_Yates_Shuffle;

namespace AlgoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var dat = new int[5]  { 99,  98, 92, 97, 95};
           var result = new FisherYates().Shuffle(dat);
            foreach (var item in result)
            {
                Console.Write(item+"\n");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
