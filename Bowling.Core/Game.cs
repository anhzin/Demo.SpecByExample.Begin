namespace Bowling.Core.Specs
{
    public class Game
    {
        public void Roll(int pins)
        {
            TotalScore += pins;
        }

        public int TotalScore { get; private set; }
    }
}