using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class AbstractKnowledge
    {
        /*This is only used for inheritance
            *1.  This is a special class which is only used for inheritance
            *2. An object of an abstract class cant be created
            *3. An Abstract class can have abstract methods
            * Abstract methods
            *4. An Abstract methods are those methods whose implementation 
            * is defined by the derived class 
            */

        public void DisplayTotalsum()
            {
                Console.WriteLine("The addition of both numbers is ");
            }
        //This is an abstract method
        public abstract void AddNumber(int numA, int numB);


    }
}
