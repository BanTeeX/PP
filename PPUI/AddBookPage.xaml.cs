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
	public partial class AddBookPage : Page
	{

		public AddBookPage()
		{
			InitializeComponent();
			authorComboBox.ItemsSource = Library.GetAuthorsList();
			bookRadioButton.IsChecked = true;
		}

		private void CancelButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new PrintBooksPage());
		}

		private void BookRadioButtonChecked(object sender, RoutedEventArgs e)
		{
			ChangeEnableOfFields(false, false);
		}

		private void CoursebookRadioButtonChecked(object sender, RoutedEventArgs e)
		{
			ChangeEnableOfFields(true, false);
		}

		private void NovelRadioButtonChecked(object sender, RoutedEventArgs e)
		{
			ChangeEnableOfFields(false, true);
		}

		private void ChangeEnableOfFields(bool subject, bool type)
		{
			subjectLabel.IsEnabled = subject;
			subjectTextBox.IsEnabled = subject;
			typeLabel.IsEnabled = type;
			typeTextBox.IsEnabled = type;
		}

		private void AddBookButtonClick(object sender, RoutedEventArgs e)
		{
			string title = titleTextBox.Text;
			IAuthors author = (IAuthors)authorComboBox.SelectedItem;
			int numOfPages = Convert.ToInt32(numOfPagesTextBox.Text);

			if (bookRadioButton.IsChecked ?? false)
			{
				Library.Books.Add(new Book(title, author, numOfPages));
			}
			else if (coursebookRadioButton.IsChecked ?? false)
			{
				Library.Books.Add(new Coursebook(title, author, numOfPages, subjectTextBox.Text));
			}
			else if (novelRadioButton.IsChecked ?? false)
			{
				Library.Books.Add(new Novel(title, author, numOfPages, typeTextBox.Text));
			}

			Parent.SetValue(ContentProperty, new PrintBooksPage());
		}
	}
}
