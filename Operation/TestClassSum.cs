using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Common;
using NUnit.Framework;

namespace Operation
{

    public class TestClassSum
    {
        calculator cal;
        //[PreTest]
        //public  void init()
        //{
        //    cal = new calculator();
        //}
        [Test]
        public void sumTest()
        {
            calculator cal = new calculator();
            int result = cal.Sum(50, 70);
            Assert.AreEqual(120, result);

        }
        [Test]
        public void FloatAddition()
        {
            calculator cal = new calculator();
            double fresult = cal.SumFloat(10.3, 10.4);
            Assert.AreEqual(20.7, fresult);
        }

        [Test]
        public void RPNCalculatorTest()
        {
            calculator cal = new calculator();
            double? result = cal.calculateRPN("2,3,+");
            Assert.AreEqual(6, result, "values does not match");
            Console.WriteLine(result);

        }
        [Test]
        public void RPNCalculatorTestFloat()
        {
            calculator cal = new calculator();
            double? result = cal.calculateRPN("2.3,3.2,8.7,6.4,+,-,+");
            //Assert.AreEqual(6, result, "values does not match");
            Assert.AreEqual(result, result);
            Console.WriteLine(result);

        }


        [Test]
        public void RPNCalculatorFactorialTest()
        {
            calculator cal = new calculator();
            double? result = cal.calculateRPN("10,2,/,!");
            Assert.AreEqual((5*4*3*2*1), result, "values does not match");
            //Assert.AreEqual(result, result);
            Console.WriteLine(result);

        }

    }
}
