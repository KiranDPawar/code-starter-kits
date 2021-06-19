namespace BowlingGame.Interface
{
    /// <summary>
    /// This Interface will be used to implement bowling frame methods.
    /// </summary>
    public interface IBowling
    {
        /// <summary>
        /// This Method will be used to Call whenever bwoling roll has been executed for each frame
        /// </summary>
        /// <param name="totalPins"></param>
        void ExecuteBowlingFrame(int totalPins);
    }
}