using System;
namespace Blog.Models
{
	public class BlogPost
	{
		public Guid ID { get; set; }
		public string Heading { get; set; }
		public string PageTitle { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string FeaturedImage { get; set; }
        public string UrlHandle { get; set; }
		public DateTime PublishedDate { get; set; }
		public string Author { get; set; }
		public bool Visibility { get; set; }


		public BlogPost()
		{
		}
	}
}

