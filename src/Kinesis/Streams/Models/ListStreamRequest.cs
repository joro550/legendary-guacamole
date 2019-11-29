namespace Kinesis.Streams.Models
{
    public class ListStreamRequest
    {
        public int MaxItems { get; set; }
        public int PageSize { get; set; }
        public string StartingToken { get; set; }
    }
}