namespace Module16_Task1
{
    /// <summary>
    /// Class for math actions
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Addition action method
        /// </summary>
        /// <param name="a"> First number </param>
        /// <param name="b"> Second number </param>
        /// <returns> number after addition </returns>
        public int Additional(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtraction action method
        /// </summary>
        /// <param name="a"> First number </param>
        /// <param name="b"> Second number </param>
        /// <returns> number after substraction </returns>
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Miltiplication action method
        /// </summary>
        /// <param name="a"> First number </param>
        /// <param name="b"> Second number </param>
        /// <returns> number after multiplication </returns>
        public int Miltiplication(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Division action method
        /// </summary>
        /// <param name="a"> First number </param>
        /// <param name="b"> Second number </param>
        /// <returns> number after division </returns>
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
