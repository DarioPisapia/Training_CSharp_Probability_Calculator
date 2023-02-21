using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training_CSharp_Probability_Calculator
{
    public class Hat
    {
        public List<string> contents = new List<string>();
        Dictionary<string, int> ballsData = new Dictionary<string, int>();

        public Hat(Dictionary<string, int> ballsData) 
        {
            this.ballsData = ballsData;
            contents = GetContents();
        }

        private List<string> GetContents()
        {
            List<string> keys = ballsData.Keys.ToList();

            foreach (string color in keys)
            {
                int ballsPerColor = ballsData[color];
                while (ballsPerColor > 0) 
                {
                    contents.Add(color); 
                    ballsPerColor--;
                }
            }
            return contents;
        }

        public List<string> Draw(int ballsToDraw) 
        {
                List<string> ballsDrawed = new List<string>();
                List<string> contentsCopy = new List<string>(contents);

                if(ballsToDraw < contents.Count)
                {
                    while (ballsToDraw > 0)
                    {
                        Random randomIndex = new Random();
                        int index = randomIndex.Next(contentsCopy.Count);
                        ballsDrawed.Add(contentsCopy[index]);
                        contentsCopy.RemoveAt(index);
                        ballsToDraw--;
                    }
                }
                else
                {
                    ballsDrawed = contents;
                }
                return ballsDrawed;
        }
    }
}
