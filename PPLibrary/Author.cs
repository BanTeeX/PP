using System;
using System.Collections.Generic;
using System.Text;

namespace PPLibrary
{
	public class Author : Person, IAuthors
	{
		public string Type { get; set; }

		public Author(string name, string lastName, float height, string town, string type) : base(name, lastName, height, town)
		{
			Type = type;
		}

		public new void Drink()
		{
			Console.WriteLine("Pije autor");
		}
	}
}
