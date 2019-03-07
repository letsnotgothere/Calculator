using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    class Calculator
    {

        private string equationText;
        private float currentValue;

        public Calculator()
        {
            equationText = "";
            currentValue = 10.5f;
        }


        public string getEquationText()
        {
            return equationText;
        }

        public void addCharacters(char c)
        {
            equationText += c;
        }

    }
}
