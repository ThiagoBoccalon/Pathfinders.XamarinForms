using System;
using System.Collections.Generic;
using System.Text;

namespace TestAlgoritm
{
    public class Test
    {
        private Dictionary<int, string> camp = new Dictionary<int, string>();

        public Test()
        {
            SetCamporis();
        }

        private void SetCamporis()
        {
            camp.Add(1990, "X");
            camp.Add(2000, "Y");
            camp.Add(3000, "Z");
        }

        public void TestMethod()
        {            
            foreach ( KeyValuePair<int, string> example in camp )
            {
                Console.WriteLine("{0}\n", example.Value);
            }
        }
    }
}
