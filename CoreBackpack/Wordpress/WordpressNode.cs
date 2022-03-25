using System;

namespace CoreBackpack.Wordpress
{
    public class WordpressNode
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Uri { get; set; }
        public string Photo { get; set; }
        public DateTime LastModified { get; set; }
    }
}
