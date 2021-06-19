namespace BowlingGame.Interface
{
    /// <summary>
    /// This Interfce will be used for calculating bowling score
    /// </summary>
    public interface IBowlingScore
    {
        /// <summary>
        /// This method will be implemented to add current throws into bowling frame.
        /// </summary>
        /// <param name="pins"></param>
        void AddFrameThrows(int pins);

        /// <summary>
        /// This method will be implemented to get each frame score.
        /// </summary>
        /// <param name="theFrame"></param>
        /// <returns></returns>
        int GetFrameScore(int theFrame);
    }
}