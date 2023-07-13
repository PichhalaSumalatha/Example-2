using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] studMarks = new int[4, 5];


            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter details for Student {0}:", i + 1);
                Console.Write("Roll no: ");
                studMarks[i, 0] = int.Parse(Console.ReadLine());
                Console.Write("Semester 1 marks: ");
                studMarks[i, 1] = int.Parse(Console.ReadLine());
                Console.Write("Semester 2 marks: ");
                studMarks[i, 2] = int.Parse(Console.ReadLine());
                Console.Write("Semester 3 marks: ");
                studMarks[i, 3] = int.Parse(Console.ReadLine());
                Console.Write("Semester 4 marks: ");
                studMarks[i, 4] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }


            Console.WriteLine("Roll no\tSem1\tSem2\tSem3\tSem4\tTotal");

            for (int i = 0; i < 4; i++)
            {
                int totalMarks = studMarks[i, 1] + studMarks[i, 2] + studMarks[i, 3] + studMarks[i, 4];

                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", studMarks[i, 0], studMarks[i, 1], studMarks[i, 2], studMarks[i, 3], studMarks[i, 4], totalMarks);
            }

            Console.ReadLine();

        }
    }
}
