using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class StateComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            // Since we want to sort strings, we can use the
            // comparer for the built-in string class
            return string.Compare(x.State, y.State);
        }
    }
}
