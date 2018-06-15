using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace WorkProject
{
 
    class Props
    {
        private string _hiddenVariable;

        //public void _SetHiddenVariable(string variableValue)
        //{
        //    _hiddenVariable = variableValue;
        //}
        ////This value is used to return the value of the variable

        //public string _GetHiddenVariable()
        //{
        //    return _hiddenVariable;
        //}
        public string GetVar
        {

            set { _hiddenVariable = value; }
            get { return _hiddenVariable; }


           
        }
    }
}
