namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _id;
        private Guid _tweetId;
        private Guid _userId;
        private string _comment;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public Retweet()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }
        public Guid Id
        {
            get { return _id; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }
        public Guid userId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}
