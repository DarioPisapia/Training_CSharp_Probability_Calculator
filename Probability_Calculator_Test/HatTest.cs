using OOP_Training_CSharp_Probability_Calculator;

namespace Probability_Calculator_Test
{
    public class HatTest
    {
        Hat testHat1 = new(new Dictionary<string, int>() { { "red", 4 }, { "yellow", 3 } });
        Hat testHat2 = new(new Dictionary<string, int>() { { "blue", 3 }, { "red", 2 }, { "green", 6 } });
        Hat testHat3 = new(new Dictionary<string, int>() { { "yellow", 5 }, { "red", 1 }, { "green", 3 }, { "blue", 9 }, { "test", 1 } });

        [Fact]
        public void HatClassContent()
        {
            List<string> actual = testHat1.contents;
            List<string> expected = new(){ "red", "red", "red", "red", "yellow", "yellow", "yellow" };
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DrawTest()
        {
            List<string> actual = testHat1.Draw(7);
            List<string> expected = new() { "red", "red", "red", "red", "yellow", "yellow", "yellow" };
            Assert.Equal(expected, actual);

            int numBallsDrawed = testHat1.Draw(4).Count;
            Assert.Equal(4, numBallsDrawed);
        }

        [Fact]
        public void ProbCalculatorTesting()
        {
            double actual = ProbCalculator.Experiment(testHat2, new Dictionary<string, int>() { { "blue", 2 }, { "green", 1 } }, 4, 1000);
            double expected = 0.272;
            Assert.InRange(actual, expected-0.3, expected+0.3);

            actual = ProbCalculator.Experiment( testHat3, new Dictionary<string, int>() { { "yellow", 2 }, { "blue", 3 }, { "test", 1 } }, 20, 100 );
            expected = 1;
            Assert.InRange(actual, expected - 0.1, expected + 0.1);
        }

    }
}