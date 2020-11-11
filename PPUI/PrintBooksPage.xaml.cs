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
	public partial class PrintBooksPage : Page
	{
		public PrintBooksPage()
		{
			InitializeComponent();

			booksListBox.ItemsSource = Library.Books;
		}

		private void AddBookButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new AddBookPage());
		}

		private void CancelButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new MenuPage());
		}

		private void PrintBookButtonClick(object sender, RoutedEventArgs e)
		{
            if (booksListBox.SelectedItem != null)
            {
				Parent.SetValue(ContentProperty, new BookPage((Book)booksListBox.SelectedItem));
            }
		}

		private void DeleteBookButtonClick(object sender, RoutedEventArgs e)
		{
            if (booksListBox.SelectedItem != null)
            {
                Library.Books.Remove((Book)booksListBox.SelectedItem);
                Parent.SetValue(ContentProperty, new PrintBooksPage()); 
            }
		}
	}
}
