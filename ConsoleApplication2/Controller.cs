using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Controller
    {
        private IBusiness _business;
        public Controller(IBusiness business)
        {
            _business = business;
        }
        public int Add(int a, int b)
        {
            //1 2
            //-1 4
            //-8 -9
            if (a > 4)
                return _business.Add(a, b);
            else
                return a + b;
        }
    }
}
