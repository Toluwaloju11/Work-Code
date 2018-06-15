using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProject
{
    class IfStatement1

    {
        public void ConditionalStatement()
        {
            Console.Write("Please enter a letter: ");
            char input = (char)Console.Read();

            if ((input == 'a') || (input == 'b') || (input == 'c') || (input == 'd'))
            {
                Console.WriteLine("The character entered is {0}", input);



                Console.WriteLine("Press any key to exit");
            }
            else if ((input == 'f') || (input == 'g'))
            {
                Console.WriteLine("The character(Esle if)  entered is {0}", input);
            }
            else
            {
                Console.WriteLine("The character entered is {0}", input);
            }

        }
        public void Ifstatement2()
        {
            Console.Write("Please enter a Letter: ");
            char input = (char)Console.Read();
            switch (input)
            {
                case 'a':
                    Console.WriteLine("The character entered is:  '{0}'", input);
                    break;

                case 'b':
                    Console.WriteLine("The character entered is: '{0}'", input);
                    break;

                case 'c':
                    Console.WriteLine("The character entered is: '{0}'", input);
                    break;

                default:
                    Console.WriteLine("'{0}' is not the correct character", input);
                    break;
            }
        }
        public void Ifstatement3()
                {
                    Console.Write("Please enter your name: ");
                    String enterusername = Console.ReadLine();
                if (enterusername.Equals ("tolu") || enterusername.Equals("femi"))
                        {
                     Console.WriteLine("My name is {0}", enterusername);
                        }
                else
                        {
                    Console.WriteLine("The name '{0}' is incorrect", enterusername);
                        }
                }
    }
}