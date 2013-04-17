using System;
using System.Linq;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Bowling.Core.Specs
{
    [Binding]
    public class ScoreCalculationSteps
    {
        private Game _game;

        [Given]
        public void Given_a_new_bowling_game()
        {
            _game = new Game();
        }
        
        [When]
        public void When_all_of_my_balls_are_landing_in_the_gutter()
        {
            RollMany(0);
        }

        [When]
        public void When_all_of_my_rolls_are_P0(int p0)
        {
            RollMany(p0);
        }

        private void RollMany(int pins)
        {
            Enumerable.Range(1, 20).ToList().ForEach(x => _game.Roll(pins));
        }

        [Then]
        public void Then_my_total_score_should_be_P0(int p0)
        {
            _game.TotalScore.Should().Be(p0);
        }
    }
}
