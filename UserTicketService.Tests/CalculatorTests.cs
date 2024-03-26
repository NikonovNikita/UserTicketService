namespace UserTicketService.Tests
{
    internal class CalculatorTests
    {
        private static readonly Calculator _calculator = new Calculator();

        [Test]
        public static void MultiplyShouldReturnCorrectValue()
        {
            Assert.AreEqual(8, _calculator.Multiply(4, 2));
        }

        [Test]
        public static void SubtractionShouldReturnCorrectValue()
        {
            Assert.That(_calculator.Subtraction(300, 10) == 290);
        }

        [Test]
        public static void DivideMustThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
        }

        [Test]
        public static void AddAlwaysReturnsExpectedValue()
        {
            Assert.That(_calculator.Add(10, 220), Is.EqualTo(230));
        }
    }
}
