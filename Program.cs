using System;

namespace testmid
{
    class Program
    {
        static void Main(string[] args)
        {
            float y;
            float dx;
            float dy;
            float step;
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
            if ((Math.Abs(dx)) >= (Math.Abs(dy)))
            {
                step = Math.Abs(dx);
            }
            else 
            {
                step = Math.Abs(dy);
            }
            dx /= step;
            dy /= step;
            x = x1;
            y = y2;
            int i = 1;
            while (i <= step) 
            {
                Console.WriteLine(x1 + "," + y);
                x += dx;
                y += dy;
                i++;
            }
            Console.ReadLine();
        }
    }
}
