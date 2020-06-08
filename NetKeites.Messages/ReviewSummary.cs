using System;
using System.Collections.Generic;
using System.Text;

namespace NetKeites.Messages
{
    public class ReviewSummary
    {
        public int ReviewId { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
