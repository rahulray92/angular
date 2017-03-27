using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new DataAccess();
            //var d1 = new DataAccess1();
            var b = new Business(d);
            //var b1 = new Business1(d1);
            var obj = new Controller(b);
        }
    }
}
