using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    class CompoundComparer : IComparer<City>
    {

        public IList<IComparer<City>> Comparers { get; set; }

        public CompoundComparer()
        {
            Comparers = new List<IComparer<City>>();
        }
        
        public int Compare(City x, City y)
        {

            int i = 0;

            while (i <= Comparers.Count)
            {
                if(Comparers[i].Compare(x, y) == 0)
                {
                    i++;
                    continue;
                }
                else
                {
                    return Comparers[i].Compare(x, y);
                }
            }

            return 0;
        }

    }
}
