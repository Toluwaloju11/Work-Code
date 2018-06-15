using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProject
{
    public  class ChildAbs : AbstractKnowledge
    {

        public int num = 4;
        public string word = "C";
        public char letter = 'a';

        public override void AddNumber(int numA, int numB)
        {
            Console.WriteLine("");
        }
    }
}
