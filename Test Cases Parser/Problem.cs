using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Cases_Generator
{
    class Problem
    {
        private string problemID;
        private List<TestCase> testcases;

        public Problem()
        {

        }

        public Problem(string problemID, List<TestCase> testcases)
        {
            this.problemID = problemID;
            this.testcases = testcases;
        }

        public string ProblemID { get => problemID; set => problemID = value; }
        internal List<TestCase> Testcases { get => testcases; set => testcases = value; }
    }
}
