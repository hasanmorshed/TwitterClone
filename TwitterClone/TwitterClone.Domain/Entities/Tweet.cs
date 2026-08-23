namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private string _userId;
        private string _content;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public Tweet()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }
        public Guid ID
        {
            get { return _id; }
        }
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public DateTime ModifiedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }

        }
    }
}
