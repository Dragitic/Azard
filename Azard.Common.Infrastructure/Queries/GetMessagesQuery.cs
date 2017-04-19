namespace Azard.Common.Infrastructure.Queries
{
    public class GetMessagesQuery
    {
        public int Id { get; }
        public string Author { get; set; }
        public bool IdIsKnown { get; set; }
        public GetMessagesQuery(int id)
        {
            Id = id;
            IdIsKnown = true;
        }

        public GetMessagesQuery(string author)
        {
            Author = author;
            IdIsKnown = false;
        }
    }
}