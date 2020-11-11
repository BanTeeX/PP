using System;

namespace PPLibrary
{
	public class Book
	{
		public string Title { get; set; }
		public IAuthors Author { get; set; }
		public int NumOfPages { get; set; }

		public Book(string title, IAuthors author, int numOfPages)
		{
			Title = title;
			Author = author;
			NumOfPages = numOfPages;
		}
	}
}
