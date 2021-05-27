using Xunit;

namespace VencaX.Randomer.Tests
{
    public class RandomerTests
    {
        [Fact]
        public void RandomerTest()
        {
            var randomer = new Randomer();
            var result = randomer.Number();

            Assert.InRange(result, 0, 100);
        }
    }
}
