using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PPLibrary
{
	public static class Library
	{
		public static List<Person> Persons { get; set; } = new List<Person>();

		public static List<Book> Books { get; set; } = new List<Book>();

		public static List<Book> GetBorrowableBooksList(Person person)
		{
			List<Book> borrowList = new List<Book>();
			bool isPersonStudent = person is IStudents;
			foreach (Book book in Books)
			{
				if (book is Coursebook == false || isPersonStudent)
				{
					borrowList.Add(book);
				}
			}
			return borrowList;
		}

		public static List<IAuthors> GetAuthorsList()
		{
			List<IAuthors> authors = new List<IAuthors>();
			foreach (Person person in Persons)
			{
				if (person is IAuthors author)
				{
					authors.Add(author);
				}
			}
			return authors;
		}
	}
}
