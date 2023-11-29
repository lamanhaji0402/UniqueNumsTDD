using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueTry
{
    public class UniqueNums
    {
        public UniqueNums() { }
        public HashSet<int> filter(List<int> nums)
        {
            HashSet<int> res = new HashSet<int>(nums);
            return res;
        }
    }
}
