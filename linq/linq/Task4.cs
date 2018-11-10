using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal static class Task4
    {
        public static String ConcatExceptFirstThree(IEnumerable<CTestEntity> data, Char delimeter)
        {
            return data.Select(x => x.Name).Skip(3).Aggregate((a, b) => a + delimeter + b);
        }
    }
}
