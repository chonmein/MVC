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
            string x,y,xy;
            while (true)
            {
                Console.WriteLine("請輸入三角形的底邊長");
                int input = Convert.ToInt32(Console.ReadLine());
                var highValue = input*3 / 4 + 1 ;
                var MedianValue = input / 2 ;
                //正三角
                //var numberList = Enumerable.Range(1, input/2+1);
                //六芒星
                var numberList = Enumerable.Range(1, highValue);
                foreach (int number in numberList)
                {
                    //XXXXXX 正三角
                    //for (int i = 0; i < input; i++)
                    //{
                    //    if (i <= (MedianValue + (number - 1)) & i >= (MedianValue - (number - 1)))
                    //        x = "*";
                    //    else
                    //        x = " ";
                    //    Console.Write(x);
                    //};

                    //YYYYYYY  倒三角
                    //for (int i = 0; i < input; i++)
                    //{
                    //    if (i < (number - 1) | i > (input- number))
                    //        y = " ";
                    //    else
                    //        y = "*";
                    //    Console.Write(y);
                    //};

                    //ZZZZZZZ  六芒星
                    //Console.Write(number);
                     for (int i = 0; i < input; i++)
                    {
                        if ((number <= MedianValue+1) & (i <= (MedianValue + (number - 1)) & i >= (MedianValue - (number - 1))))
                            x = "*";
                        else
                            x = " ";
                        //Console.Write(x);
                            
                        if ((number <(highValue-MedianValue)-1) | (i < (number - 1-(highValue-MedianValue)+2) | i > (input- number+(highValue-MedianValue)-2)))
                            y = " ";
                        else
                            y = "*";
                        //Console.Write(y);


                        if ((x == y)  )
                               xy =" ";
                        else
                            xy ="*";
                        Console.Write(xy);
                            
                    };

                    Console.WriteLine();
                }
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
