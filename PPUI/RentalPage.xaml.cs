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
	public partial class RentalPage : Page
	{
		public RentalPage()
		{
			InitializeComponent();

			personsListBox.ItemsSource = Library.Persons;
		}

		public RentalPage(Person person) : this()
		{
			InitializeComponent();

			personsListBox.SelectedItem = person;
			giveBackBookButton.IsEnabled = true;
			borrowBookButton.IsEnabled = true;
			borrowedBooksLabel.IsEnabled = true;
			booksLabel.IsEnabled = true;
			borrowedBooksListBox.IsEnabled = true;
			booksListBox.IsEnabled = true;
			borrowedBooksListBox.ItemsSource = person.BooksCollection;

			booksListBox.ItemsSource = Library.GetBorrowableBooksList(person);
		}

		private void CancelButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new MenuPage());
		}

		private void BorrowBookButtonClick(object sender, RoutedEventArgs e)
		{
			if (booksListBox.SelectedItem != null)
			{
				((Person)personsListBox.SelectedItem).BooksCollection.Add((Book)booksListBox.SelectedItem);
				Parent.SetValue(ContentProperty, new RentalPage((Person)personsListBox.SelectedItem));
			}
		}

		private void GiveBackBookButtonClick(object sender, RoutedEventArgs e)
		{
			if (borrowedBooksListBox.SelectedItem != null)
			{
				((Person)personsListBox.SelectedItem).BooksCollection.Remove((Book)borrowedBooksListBox.SelectedItem);
				Parent.SetValue(ContentProperty, new RentalPage((Person)personsListBox.SelectedItem)); 
			}
		}

		private void PersonsListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			giveBackBookButton.IsEnabled = true;
			borrowBookButton.IsEnabled = true;
			borrowedBooksLabel.IsEnabled = true;
			booksLabel.IsEnabled = true;
			borrowedBooksListBox.IsEnabled = true;
			booksListBox.IsEnabled = true;

			borrowedBooksListBox.ItemsSource = ((Person)((ListBox)sender).SelectedItem).BooksCollection;
			booksListBox.ItemsSource = Library.GetBorrowableBooksList((Person)((ListBox)sender).SelectedItem);
		}
	}
}
