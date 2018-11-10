using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static linq.Task4;
using static linq.Task5;

namespace linq
{
    internal class Program
    {
        private static IEnumerable<CTestEntity> testData = CreateTestCollection();

        public static void Main(string[] args)
        {
            
            PrintCollection(testData);

            // Test for 4th task
            Console.WriteLine("Testing 4th task: ");
            Console.WriteLine(ConcatExceptFirstThree(testData, '/') + '\n');
            
            // Test for 5tn task
            Console.WriteLine("Testing 5th task:");
            PrintCollection(SelectNameGreaterThanPosition(testData));
        }

        private static void PrintCollection(IEnumerable<CTestEntity> data)
        {
            foreach (var entry in data)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine();
        }

        private static IEnumerable<CTestEntity> CreateTestCollection()
        {
            var entry1 = new CTestEntity("Robert");
            var entry2 = new CTestEntity("Chris");
            var entry3 = new CTestEntity("Jessica");
            var entry4 = new CTestEntity("Ana");
            var entry5 = new CTestEntity("John");
            return new List<CTestEntity>() { entry1, entry2, entry3, entry4, entry5 };
        }
    }
}
