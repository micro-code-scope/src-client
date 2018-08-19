/// <summary>
/// Andrea Tino - 2018
/// </summary>

namespace CodeAlive.Communication.Eventing
{
    using System;

    /// <summary>
    /// Event descriptor.
    /// </summary>
    public class RenderingEvent
    {
        /// <summary>
        /// When specified, the debug console will display a message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Provides a string representation.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "RenderingEvent";
        }
    }
}
