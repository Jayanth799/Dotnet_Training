using System;
using System.Collections.Generic;

namespace OCPPrinciple
{
    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
    }

    public class AreaCaculator
    {
        public double TotalArea(Rectangle[] arrRectangles)
        {
            double _area = 0;
            foreach (var objrect in arrRectangles)
            {
                _area += objrect.Height * objrect.Width;
            }
            

            return _area;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var area = new AreaCaculator();
            Rectangle[] rectarr = new Rectangle[] 
            { 
                new Rectangle
                {
                    Height = 10,
                    Width = 20
                },
                new Rectangle
                {
                    Height = 5,
                    Width = 10
                }
            };
            Console.WriteLine(area.TotalArea(rectarr));
        }
    }
}
