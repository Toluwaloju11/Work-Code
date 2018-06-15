using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



   namespace WorkProject
{
  
    public class ForLoop
    {

        int num1 = 5;
        int num2 = 60;
        public void Forstatement()
        {

            int result = num1 + num2;
            Console.WriteLine("The addition is {0} ", result);
            for (int i = num1; i < 50; i+=2)
            {
                Console.WriteLine(i);
            }
        }


    }
}
