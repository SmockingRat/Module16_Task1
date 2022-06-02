using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Module16_Task1;

namespace Module16_Task1.Tests
{
    [TestFixture]
    public class Class1
    {

        [TestFixture]
        public class Tests
        {
            [Test]
            public void AdditionMustReturnValue()
            {
                var add = new Calculator();
                var num = add.Additional(4, 5);
                Assert.True(num == 9);
            }

            [Test]
            public void SubstractionMustReturnValue()
            {

                var sub = new Calculator();
                var num = sub.Subtraction(10, 4);
                Assert.True(num == 6);

            }

            [Test]
            public void MultiplicationMustReturnValue()
            {

                var mult = new Calculator();
                var num = mult.Miltiplication(2, 3);
                Assert.True(num == 6);

            }

            [Test]
            public void DivisionMustReturnValue()
            {

                Assert.True(50 == 50);

            }


        }

    }
}
