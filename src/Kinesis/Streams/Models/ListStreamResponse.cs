using System.Collections.Generic;
using Kinesis.Core;
using Kinesis.Core.Handlers;

namespace Kinesis.Streams
{
    public class ListStreamResponse : IHandlerResponse
    {
        public bool HasMoreStreams { get; set; }
        public List<string> StreamNames { get; } = new List<string>();
    }
}