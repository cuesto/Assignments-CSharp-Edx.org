using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwoAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int mRow = 0;
            char lastChar = 'O';
            char x = 'X';
            char o = 'O';
            bool whileLoop = true;

            while (whileLoop)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (lastChar == x)
                    {
                        Console.Write(o);
                        lastChar = o;
                    }
                    else
                    {
                        Console.Write(x);
                        lastChar = x;
                    }
                }
                if (mRow < 7)
                {
                    if (lastChar == x)
                    {
                        lastChar = o;
                    }
                    else
                    {
                        lastChar = x;
                    }
                    mRow++;
                    Console.WriteLine();
                }
                else
                {
                    whileLoop = false;
                }
            }
            Console.WriteLine();
        }
    }
}
