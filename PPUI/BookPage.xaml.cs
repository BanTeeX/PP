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
	public partial class BookPage : Page
	{
		public BookPage(Book book)
		{
			InitializeComponent();

			bookTypeLabel.Content = "Książka";
			titleTextBlock.Text = book.Title;
			authorTextBlock.Text = ((Person)(book.Author)).Name + " " + ((Person)(book.Author)).LastName;
			numOfPagesTextBlock.Text = book.NumOfPages.ToString();
			subjectLabel.IsEnabled = false;
			typeLabel.IsEnabled = false;

			if (book is Coursebook coursebook)
			{
				subjectTextBlock.Text = coursebook.Subject;
				subjectLabel.IsEnabled = true;
				bookTypeLabel.Content = "Podręcznik";
			}
			if (book is Novel novel)
			{
				typeTextBlock.Text = novel.Type;
				typeLabel.IsEnabled = true;
				bookTypeLabel.Content = "Powieść";
			}
		}

		private void CancelButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new PrintBooksPage());
		}
	}
}
