using System;
using System.Collections.Generic;
using System.Text;

namespace PPLibrary
{
	public class Coursebook : Book
	{
		public string Subject { get; set; }

		public Coursebook(string title, IAuthors author, int numOfPages, string subject) : base(title, author, numOfPages)
		{
			Subject = subject;
		}
	}
}
