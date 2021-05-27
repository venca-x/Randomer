using Xunit;

namespace VencaX.Randomer.Tests
{
    public class RandomerTests
    {
        [Fact]
        public void RandomerNumberTest()
        {
            var randomer = new Randomer();
            var result = randomer.Number();

            Assert.InRange(result, 0, 100);
        }

        [Fact]
        public void RandomerNumberFromToTest()
        {
            var randomer = new Randomer();
            var result = randomer.NumberFromTo(0,1);
            Assert.InRange(result, 0, 1);

            result = randomer.NumberFromTo(0, 10);
            Assert.InRange(result, 0, 10);
        }
    }
}
