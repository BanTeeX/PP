using PPLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PPUI
{
	public partial class PersonPage : Page
	{
		public PersonPage(Person person)
		{
			InitializeComponent();

			personTypeLabel.Content = "Osoba";
			nameTextBlock.Text = person.Name;
			lastNameTextBlock.Text = person.LastName;
			heightTextBlock.Text = person.Height.ToString();
			townTextBlock.Text = person.Town;
			bookCollectionListBox.ItemsSource = person.BooksCollection;
			universityLabel.IsEnabled = false;
			typeLabel.IsEnabled = false;

			if (person is IStudents student)
			{
				universityTextBlock.Text = student.University;
				universityLabel.IsEnabled = true;
				personTypeLabel.Content = "Student";
			}
			if (person is IAuthors author)
			{
				typeTextBlock.Text = author.Type;
				typeLabel.IsEnabled = true;
				personTypeLabel.Content = "Autor";
			}
		}

		private void CancelButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new PrintPersonsPage());
		}
	}
}
