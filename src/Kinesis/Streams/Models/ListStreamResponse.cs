using System.Collections.Generic;
using Kinesis.Core.Handlers;

namespace Kinesis.Streams.Models
{
    public class ListStreamResponse : IHandlerResponse
    {
        public bool HasMoreStreams { get; set; }
        public List<string> StreamNames { get; } = new List<string>();
    }
}