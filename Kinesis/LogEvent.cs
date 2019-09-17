namespace LightestNight.System.Serverless.Kinesis
{
    public class LogEvent
    {
        /// <summary>
        /// The Message contained within the Kinesis Log Event
        /// </summary>
        public string Message { get; set; }
    }
}