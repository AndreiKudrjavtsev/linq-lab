using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Task5
    {
        public static IEnumerable<CTestEntity> SelectNameGreaterThanPosition(IEnumerable<CTestEntity> data)
        {
            return data.Select((entity, index) => new {entity, index}).Where(x => x.entity.Name.Length > x.index).Select(x => x.entity);
        }
    }
}
