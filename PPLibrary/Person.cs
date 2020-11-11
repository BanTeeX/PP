using System;
using System.Collections.Generic;
using System.Text;

namespace PPLibrary
{
	public class Person : IDrinkable
	{
		public string Name { get; set; }
		public string LastName { get; set; }
		public float Height { get; set; }
		public string Town { get; set; }
		public List<Book> BooksCollection { get; set; } = new List<Book>();

		public Person(string name, string lastName, float height, string town)
		{
			Name = name;
			LastName = lastName;
			Height = height;
			Town = town;
		}

		public void Drink()
		{
			Console.WriteLine("Pije osoba");
		}
	}
}
