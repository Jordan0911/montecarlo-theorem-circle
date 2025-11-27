namespace montecarlo_theorem_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t_area_circle = 0;
            int outside_counter = 0;
            double p_area_circle = 0;
            double unsquared_theorem=0;
            int inside_counter = 0;
            int x = 0;
            int y = 0;
            Random rnd = new Random();
           
            Console.WriteLine("insert lenght of rectangle");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert height of rectangle");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert the number of throws");
            int throws = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert x and y of the center of the circle");
            int x_circle = Convert.ToInt32(Console.ReadLine());
            int y_circle = Convert.ToInt32(Console.ReadLine());
            if (x_circle > lenght || y_circle > height) {
                Console.WriteLine("invalid data please insert data inside the rectangle");
                 x_circle = Convert.ToInt32(Console.ReadLine());
                 y_circle = Convert.ToInt32(Console.ReadLine());
                    if(x_circle > lenght || y_circle > height)
                    {
                        Console.WriteLine("kill yourself");
                        return;
                    }
            }
            Console.WriteLine("insert the ray of the circle");
            double ray=Convert.ToInt32(Console.ReadLine());
            if (ray>lenght||ray>height)
            {
                Console.WriteLine("invalid text, reinsert data");
                ray = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < throws; i++)
            {
               
                x = rnd.Next(lenght);
                y = rnd.Next(height);
                unsquared_theorem = Math.Pow(x - x_circle, 2) + Math.Pow(y - y_circle, 2);
                if (Math.Sqrt(unsquared_theorem) < ray)
                {
                    inside_counter++;
                }
                else
                {
                    outside_counter++;
                }
            }
           
            t_area_circle = Math.PI * (ray * ray);
            p_area_circle =((double)inside_counter/outside_counter)*(height*lenght); 
            Console.WriteLine("the pratical area of the circle  is "+p_area_circle+ " while the theoretical one is "+t_area_circle);

        }
    }
}
