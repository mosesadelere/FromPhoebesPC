using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Sorting
    {

        public Sorting()
        {
            Console.WriteLine("-----We are sorting.......");
        }

        public int[] Sort(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }

                }
            }
            return numbers;
        }

        public void printLine(params int[] numbers)
        {
            int i = 0;
            do
            {
                Console.Write(numbers[i++]);
                if(i < (numbers.Length))
                {
                    Console.Write(", ");
                }
            } while (i < numbers.Length);

            Console.WriteLine();
        }
    
    }
}
