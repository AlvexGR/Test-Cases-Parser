using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cases_Generator
{
    class TestCase
    {
        private string input;
        private string output;

        public TestCase()
        {

        }

        public TestCase(string input, string output)
        {
            this.input = input;
            this.output = output;
        }

        public string Input { get => input; set => input = value; }
        public string Output { get => output; set => output = value; }
    }
}
