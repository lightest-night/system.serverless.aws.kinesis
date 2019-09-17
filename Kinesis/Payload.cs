using System.Collections.Generic;

namespace LightestNight.System.Serverless.Kinesis
{
    public class Payload
    {
        /// <summary>
        /// The AWS Type of this Kinesis Payload
        /// </summary>
        public string MessageType { get; set; }
        
        /// <summary>
        /// The Log Group this Payload is for
        /// </summary>
        public string LogGroup { get; set; }
        
        /// <summary>
        /// The Log Stream this Payload is for
        /// </summary>
        public string LogStream { get; set; }
        
        /// <summary>
        /// The events held within this Payload
        /// </summary>
        public IEnumerable<LogEvent> LogEvents { get; set; }
    }
}