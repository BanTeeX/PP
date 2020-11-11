using System;
using System.Collections.Generic;
using System.Text;

namespace PPLibrary
{
	public class StudentAuthor : Person, IStudents, IAuthors
	{
		public string University { get; set; }
		public string Type { get; set; }

		public StudentAuthor(string name, string lastName, float height, string town, string university, string type) : base(name, lastName, height, town)
		{
			University = university;
			Type = type;
		}

		public new void Drink()
		{
			Console.WriteLine("Pije student-autor");
		}
	}
}