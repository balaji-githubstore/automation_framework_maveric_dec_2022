using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class DemoAttributesTest
    {
        [Test,Repeat(2)]
        public void Demo1Test()
        {
            Console.WriteLine("demo1");
        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]
        public void Demo2Test(int percentage)
        {
            Console.WriteLine("demo1"+percentage);
        }

        [Test]
        public void Demo3Test([Values(10,20)] int percentage, [Values("n1","n2")] string name)
        {
            Console.WriteLine("demo1" + percentage);
        }

        [Test]
        public void Demo4Test([Random(0.0, 100.0, 5)] int percentage)
        {
            Console.WriteLine("demo4" + percentage);
        }

        [Test]
        public void Demo5Test([Range(1,10,2)] int percentage)
        {
            Console.WriteLine("demo4" + percentage);
        }

        [Test,Timeout(2000)]
        public void Demo6Test()
        {
            Thread.Sleep(5000);
            Console.WriteLine("demo4" );
        }
    }
}
