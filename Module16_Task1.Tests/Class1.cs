using NUnit.Framework;

namespace Module16_Task1.Tests
{
    /// <summary>
    /// Central class 
    /// </summary>
    [TestFixture]
    public class Class1
    {
        /// <summary>
        /// Class contains all tests
        /// </summary>
        [TestFixture]
        public class Tests
        {
            /// <summary>
            /// Test for addition
            /// </summary>
            [Test]
            public void AdditionMustReturnValue()
            {
                var add = new Calculator();
                var num = add.Additional(4, 5);
                Assert.True(num == 9);
            }

            /// <summary>
            /// Test for substraction
            /// </summary>
            [Test]
            public void SubstractionMustReturnValue()
            {
                var sub = new Calculator();
                var num = sub.Subtraction(10, 4);
                Assert.True(num == 6);
            }

            /// <summary>
            /// Test for multiplication
            /// </summary>
            [Test]
            public void MultiplicationMustReturnValue()
            {
                var mult = new Calculator();
                var num = mult.Miltiplication(2, 3);
                Assert.True(num == 6);
            }

            /// <summary>
            /// Test for division
            /// </summary>
            [Test]
            public void DivisionMustReturnValue()
            {
                var div = new Calculator();
                var num = div.Division(10, 5);
                Assert.True(num == 2);
            }
        }
    }
}
