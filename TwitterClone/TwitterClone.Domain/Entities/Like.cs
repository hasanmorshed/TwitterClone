

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _id;
        private Guid _useId;
        private Guid _tweetId;
        private DateTime _createdAt;
        private DateTime _modifiedAt;
        public Like()
        {
            _id= Guid.NewGuid();
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
        public Guid UseId
        {
            get { return _useId; }
            set { _useId = value; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt= value; }
        }
    }
}
