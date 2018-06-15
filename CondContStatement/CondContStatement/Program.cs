using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondContStatement
{

    class Triangle
    {
        public int width;
        public int height;

        public void GetArea()
        {
            double area = (width * height);
            Console.WriteLine("The area is {0}", area);
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            

            //WHILE LOOP  
            //int i = 0;
            //while (i < 20)
            //{
            //    Console.WriteLine("The number is : {0}", i);
            //    i = i + 1;
            //}

            Triangle obj1 = new Triangle();
            //Triangle obj2 = new Triangle();
            obj1.height = 5;
            obj1.width = 11;

            obj1.GetArea();

            Console.WriteLine();
            Console.Read();

           
            


        }
    } 
}
