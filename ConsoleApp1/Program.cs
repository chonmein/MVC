using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string Message01 = "請輸入整數A";
            //string Message02 = "請輸入整數B";
            //int numberA = 0;
            //int numberB = 0;
            //int answer = 0;
            //Console.WriteLine(Message01);
            //numberA = ReadInt();
            //Console.WriteLine(Message02);
            //numberB = ReadInt();
            //answer = numberA + numberB;
            //Console.WriteLine(answer);
            //Console.ReadLine();

            ////for(var i = 0; i < answer; i++)
            ////{
            ////    if (i == 5)
            ////        continue; 
            ////        // break;
            ////    Console.WriteLine(i);
            ////}

            ////var numbers =  Enumerable.Range(5, 10).ToArray();
            ////foreach (var number in numbers)
            ////{
            ////    Console.WriteLine(number);
            ////}


            ////while (true)
            ////{
            ////    var message = Console.ReadLine();
            ////    Console.WriteLine($"您輸入{message}");
            ////}

            //do
            //{
            //    //to do
            //} while (false);

            //switch (answer)
            //{
            //    case 0:
            //        break;
            //    default:
            //        break;
            //}

            //var msg = answer > 10 ? "大於10喔" : "小於等於10喔";
            //Console.WriteLine(msg);

            //var bike = new Car("腳踏車", 2, 0);
            //var bike02 = new Car("腳踏車");
            ////var bike01 = new Car(2, 0);
            ////var bike02 = new Car(2, "腳踏車", 0);

            //bike.Run("");
            //bike.BaBu();

            //var airplane = new Airplane("腳踏車");
            //airplane.Run();
            //airplane.Fly();
            //airplane.BaBu();
            //Console.ReadLine();

            //如果使用者輸入多少，那麼就出現底為多少的三角形
            while (true)
            {
                Console.WriteLine("請輸入三角形的底邊長");
                int input = Convert.ToInt32(Console.ReadLine());
                var numberList = Enumerable.Range(1, input);
                Console.WriteLine("\n正直角三角\n");
                foreach (int number in numberList)
                {
                    for (int i = 0; i < input - number; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 0; i < number; i++)
                    {                        
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\n倒直角三角\n");

                numberList = numberList.Reverse();
                foreach (int number in numberList)
                {
                    for (int i = 0; i < input - number; i++)
                    {
                        Console.Write(" ");
                    }
                    for (int i = 0; i < number; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                var triangleUp = new Triangle(input);
                var triangleDown = new Triangle(input-2);

                triangleUp.PrintTriangle();
                triangleDown.PrintReverseTriangle();

                Console.WriteLine();
                triangleUp.PrintTriangle(input, 1);
            }
        }

        public static int ReadInt()
        {
            int number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("format");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("overflow");
            }
            return number;
        }
    }
}
