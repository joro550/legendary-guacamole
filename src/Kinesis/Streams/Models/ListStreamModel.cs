namespace Kinesis.Streams
{
    public class ListStreamModel
    {
        public int MaxItems { get; set; }
        public int PageSize { get; set; }
        public string StartingToken { get; set; }
    }
}