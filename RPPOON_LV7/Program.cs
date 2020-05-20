using System;
using System.Collections.Generic;

namespace RPPOON_LV7
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZADATAK 1

            NumberSequence seq = new NumberSequence(new double[] { 2, 15, 3, 8, 47, 2, 15, 3, 8, 47 });
            NumberSequence seqcpy = seq;
            NumberSequence seqcpy2 = seq;

            seq.SetSortStrategy(new SequentialSort());
            seqcpy.SetSortStrategy(new BubbleSort());
            seqcpy2.SetSortStrategy(new CombSort());

            seq.Sort();
            Console.WriteLine(seq.ToString() + "\n");
            seqcpy.Sort();
            Console.WriteLine(seqcpy.ToString() + "\n");
            seqcpy2.Sort();
            Console.WriteLine(seqcpy2.ToString() + "\n");


            //ZADATAK 2
            NumberSequence seqnonsort = new NumberSequence(new double[] { 2, 15, 3, 8, 47, 2, 15, 3, 8, 47});
            seqnonsort.SetSearchStrategy(new LinearSearch());

            Console.WriteLine("Unesite broj:");
            double numberToSearch;
            if (double.TryParse(Console.ReadLine(), out numberToSearch))
            {
                List<int> indx = seqnonsort.Search(numberToSearch);
                if(indx.Count == 0)
                {
                    Console.WriteLine("Broj nije pronađen!");
                }
                else
                {
                    Console.WriteLine("Broj je pronađen na sljedećim indeksima: ");
                    foreach(int i in indx)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
