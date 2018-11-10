using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class CTestEntity
    {
        public String Name { get; set; }
        public Int32 Id { get; set; }

        public CTestEntity()
        {
            Name = "Default Name";
            Id = _counter++;
        }

        public CTestEntity(String name)
        {
            Name = name;
            Id = _counter++;
        }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}; \t";
        }

        private static int _counter = 1;
    }
}
