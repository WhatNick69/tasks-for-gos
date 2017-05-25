using DLLExamination;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestForLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point convert1 = DPoint.PolarPointToCartPoint(1, 180);
            Point convert1 = new Point(5, 5);
            Point convert2 = new Point(1, 1);
            double result = DPoint.Distance(convert1, convert2);
            Console.WriteLine(
                "Distance x1:{0}, y1:{1}, x2:{2}, y2:{3} = {4}",
                convert1.XPoint, convert1.YPoint, convert2.XPoint, convert2.YPoint, result);
            Console.Read();
        }
    }
}
