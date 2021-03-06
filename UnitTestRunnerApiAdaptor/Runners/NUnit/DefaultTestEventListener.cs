namespace UnitTestRunnerApiAdaptor.Runners.NUnit
{
    using global::NUnit.Engine;

    /// <summary>
    /// Default Test Event Listener class.
    /// </summary>
    public class DefaultTestEventListener : ITestEventListener
    {
        /// <summary>
        /// Implementation of ITestEventListener.OnTestEvent method.
        /// </summary>
        /// <param name="report">The test event report.</param>
        public void OnTestEvent(string report)
        {
            System.Console.WriteLine(report);
        }
    }
}