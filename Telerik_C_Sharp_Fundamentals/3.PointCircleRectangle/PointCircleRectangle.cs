using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{

    class PointCircleRectangle
    {
        static void Main()
        {
            /*Mathematically, Pythagoras Circle: (x-center_x)^2 + (y - center_y)^2 < radius^2
                
            Computationally Circle:Define: dx = abs(x-center_x) ; dy = abs(y-center_y) ; R = radius
           if dx + dy <= R then 
                return true.                            
            if dx > R then                  
                return false.               
            if dy > R                      
                then return false.
            if dx^2 + dy^2 <= R^2 then 
                return true
            else
                return false.                                 
                                            
            Rectangle:
            A "point-in-axis-aligned-rectangle test" is just:
            bool Inisde( x, y, l, r, b, t ) //x,y are the point, l,r,b,t are the extents of the rectangle
            {
                return x > l && x < r && y > b && y < t;
            }                               
             */
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
            {
                bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
                bool inRectangle = (x >= -1) && (x <= (-1 + 6)) && (y <= 1) && (y >= (1 - 6));

                if (inCircle == true && inRectangle == true)
                {
                    Console.WriteLine("inside circle inside rectangle");
                }
                else if (inCircle == false && inRectangle == false)
                {
                    Console.WriteLine("outside circle outside rectangle");
                }
                else if (inCircle == true && inRectangle == false)
                {
                    Console.WriteLine("inside circle outside rectangle");
                }
                else
                {
                    Console.WriteLine("outside circle inside rectangle");
                }
            }
        }
    }
}
