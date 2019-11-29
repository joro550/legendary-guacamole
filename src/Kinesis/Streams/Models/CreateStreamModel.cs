namespace Kinesis.Streams.Models
{
    public class CreateStreamModel
    {
        public int ShardCount { get; set; }
        public string StreamName { get; set; }
    }
}