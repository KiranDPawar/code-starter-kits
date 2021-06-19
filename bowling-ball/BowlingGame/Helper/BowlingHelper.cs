using System;

namespace BowlingGame.Helper
{
    public static class BowlingHelper
    {
        /// <summary>
        /// This static variable will be used to set current framewe count which will be used for calculating the score.
        /// </summary>
        public static int currentFrameCount { get; set; }

        /// <summary>
        /// This Method will be used to get current framecount.
        /// </summary>
        public static void GetCurrentFrameCount()
        {
            currentFrameCount = Math.Min(10, currentFrameCount + 1);
        }
    }
}