using System;
using System.Collections.Generic;
using System.Text;

namespace PPLibrary
{
	public class Novel : Book
	{
		public string Type { get; set; }

		public Novel(string title, IAuthors author, int numOfPages, string type) : base(title, author, numOfPages)
		{
			Type = type;
		}
	}
}
