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
	public partial class AddPersonPage : Page
	{
		public AddPersonPage()
		{
			InitializeComponent();
			personRadioButton.IsChecked = true;
		}

		private void CancelButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new PrintPersonsPage());
		}

		private void PersonRadioButtonChecked(object sender, RoutedEventArgs e)
		{
			ChangeEnableOfFields(false, false);
		}
		private void StudentRadioButtonChecked(object sender, RoutedEventArgs e)
		{
			ChangeEnableOfFields(true, false);
		}
		private void AuthorRadioButtonChecked(object sender, RoutedEventArgs e)
		{
			ChangeEnableOfFields(false, true);
		}
		private void StudentAuthorRadioButtonChecked(object sender, RoutedEventArgs e)
		{
			ChangeEnableOfFields(true, true);
		}

		private void ChangeEnableOfFields(bool university, bool type)
		{
			universityLabel.IsEnabled = university;
			universityTextBox.IsEnabled = university;
			typeLabel.IsEnabled = type;
			typeTextBox.IsEnabled = type;
		}

		private void AddPersonButtonClick(object sender, RoutedEventArgs e)
		{
			string name = nameTextBox.Text;
			string lastName = lastNameTextBox.Text;
			float height = Convert.ToSingle(heightTextBox.Text);
			string town = townTextBox.Text;

			if (personRadioButton.IsChecked ?? false)
			{
				Library.Persons.Add(new Person(name, lastName, height, town));
			}
			else if (studentRadioButton.IsChecked ?? false)
			{
				Library.Persons.Add(new Student(name, lastName, height, town, universityTextBox.Text));
			}
			else if (authorRadioButton.IsChecked ?? false)
			{
				Library.Persons.Add(new Author(name, lastName, height, town, typeTextBox.Text));
			}
			else if (studentAuthorRadioButton.IsChecked ?? false)
			{
				Library.Persons.Add(new StudentAuthor(name, lastName, height, town, universityTextBox.Text, typeTextBox.Text));
			}

			Parent.SetValue(ContentProperty, new PrintPersonsPage());
		}
	}
}
