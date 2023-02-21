namespace OOP_Training_CSharp_Probability_Calculator
{
    public class ProbCalculator
    {
        public static double Experiment(Hat hat, Dictionary<string, int> expectedBalls, int numBallsToDraw, double numExperiments)
        {
            Hat expectedHat = new(expectedBalls);

            double numSuccess = 0;

            for (int i = 0; i < numExperiments; i++)
            {
                List<string> reference = new List<string>(expectedHat.contents);
                List<string> results = hat.Draw(numBallsToDraw);
                List<string> usableResults= new List<string>(results);

                foreach (string ball in results)
                {
                    if (reference.Contains(ball))
                    {
                        reference.Remove(ball);
                        usableResults.Remove(ball);
                    }
                }
                if (reference.Count == 0) { numSuccess++; }  
            }    
            double probability = numSuccess != 0 ? numSuccess / numExperiments : 0;
            return probability;
        }
    }
}
