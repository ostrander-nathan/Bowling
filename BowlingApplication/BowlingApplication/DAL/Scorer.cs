using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BowlingApplication.DAL
{
    public class Scorer
    {
        private int ball;
        private int[] throws = new int[21]; // array that holds 21 throws
        private int currentThrow;

        public void AddThrow(int pins)
        {
            throws[currentThrow++] = pins;
        }
        public int ScoreForFrame(int theFrame)
        {
            ball = 0;
            int score = 0;
            for (int currentFrame = 0;
            currentFrame < theFrame;
            currentFrame++)
            {
                if (Strike())
                {
                    score += 10 + NextTwoBallsForStrike;
                    ball++;
                }
                else if (Spare())
                {
                    score += 10 + NextBallForSpare;
                    ball += 2;
                }
                else
                {
                    score += TwoBallsInFrame;
                    ball += 2;
                }
            }
            return score;
        }
        private int NextTwoBallsForStrike // Counts next 2 balls 
        {
            get { return (throws[ball + 1] + throws[ball + 2]); }
        }
        private int NextBallForSpare // counts next ball
        {
            get { return throws[ball + 2]; }
        }
        private bool Strike()
        {
            return throws[ball] == 10;
        }
        private int TwoBallsInFrame
        {
            get { return throws[ball] + throws[ball + 1]; }
        }
        private bool Spare()
        {
            return throws[ball] + throws[ball + 1] == 10;
        }
    }
}