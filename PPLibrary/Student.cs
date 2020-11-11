using System;
using System.Collections.Generic;
using System.Text;

namespace PPLibrary
{
	public class Student : Person, IStudents
	{
		public string University { get; set; }

		public Student(string name, string lastName, float height, string town, string university) : base(name, lastName, height, town)
		{
			University = university;
		}

		public new void Drink()
		{
			Console.WriteLine("Pije studnet");
		}
	}
}
