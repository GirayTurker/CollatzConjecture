using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzSequence
{
    internal class Program
    {
     static void Main(string[] args)
        {
            List<int> sequence = new List<int>();
            CollatzSeq(sequence, 169);
            ReturnDivNum(sequence, 169);
            
        }

        public static void CollatzSeq(List<int> sequence,int number)
        { 
            int count=0;
            
            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = number * 3 + 1;
                }
                sequence.Add(number);
                //Console.Write(number + ", ");
                count++;
            }

            int sum = 0;

            foreach (int i in sequence) 
            {
               Console.Write(i+" ");
                sum +=i;
          }


            Console.WriteLine("\nReached 1. End of sequence.");
            
            Console.WriteLine($"\nIterations: {count}");

            Console.WriteLine($"\nSum of all Numbers: {sum}");

            Console.WriteLine($"\nAvarage of the Numbers: {sum/count}");

            //WriteSequenceToFile(sequence);
        }
        public static int ReturnDivNum(List<int> sequence, int baseNum)
        {
            foreach (int i in sequence)
            {
                if (i >= baseNum)
                {
                    if(i % baseNum == 0)
                    {
                        Console.WriteLine($"\n{i} is divisible by {baseNum}");
                    }
                    //else
                    //{
                    //    Console.WriteLine($"\n{i} is not devisible by {baseNum}");
                    //}
                }
            }
            return baseNum;
        }

      
    public static void WriteSequenceToFile(List<int> sequence)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("collatz_sequence.txt"))
                {
                    foreach (int number in sequence)
                    {
                        writer.WriteLine(number);
                    }
                }
                Console.WriteLine("Sequence has been written to collatz_sequence.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }
}
