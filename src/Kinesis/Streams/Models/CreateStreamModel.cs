namespace Kinesis.Streams
{
    public class CreateStreamModel
    {
        public int ShardCount { get; set; }
        public string StreamName { get; set; }
    }
}