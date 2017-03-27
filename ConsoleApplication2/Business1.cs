﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Business1 : IBusiness
    {
        private IDataAccess _dataAccess;
        public Business1(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public int Add(int a, int b)
        {
            return _dataAccess.Add(a, b);
        }
    }
}
