using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class DataAccess1 : IDataAccess
    {
        public DataAccess1()
        {

        }
        public int Add(int a, int b)
        {
            return a + b + 1;
        }
    }
}
