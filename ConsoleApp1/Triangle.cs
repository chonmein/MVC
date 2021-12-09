using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Triangle
    {
        public int Length { get; private set; }

        //初始化
        public Triangle(int length)
        {
            this.Length = length;
        }

        //畫正三角形
        public void PrintTriangle()
        {
            int row = (int)Math.Floor(this.Length / 2f);
            for (int i = 1; i <= this.Length; i += 2, row--)
            {
                PrintEmpty(row);
                PrintStar(i);
                PrintEnter();
            }
        }
        //畫倒三角形
        public void PrintReverseTriangle()
        {
            int row = 1;
            for (int i = Length; i >= 0; i -= 2, row++)
            {
                PrintEmpty(row);
                PrintStar(i);
                PrintEnter();
            }
        }

        ////畫菱形
        //public void PrintDiamond(int length,int starCount)
        //{
        //    if (length > 0)
        //    {
        //        PrintEmpty(length / 2);
        //        PrintStar(starCount);
        //        PrintEnter();
        //        PrintDiamond(length - 2, starCount + 2);
        //    }
        //    else
        //    {
        //        PrintEmpty(length - 1);
        //        PrintStar(starCount);
        //        PrintEnter();
        //    }
        //}

        private void PrintEmpty(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(" ");
            }
        }

        private void PrintStar(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
        }

        private void PrintEnter()
        {
            Console.WriteLine();
        }
    }
}
