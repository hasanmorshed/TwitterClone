namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        
        private string _userId;
        private string _content;
        
        public Tweet(string content):base(Guid.NewGuid())
        {
            _content = content;
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

        public override string DescribeRecord()
        {
            var baseRecord=base.DescribeRecord();
            return $"{baseRecord},UserId:{UserId},Content:{Content}";
        }
        
    }
}
