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
	public partial class MenuPage : Page
	{
		public MenuPage()
		{
			InitializeComponent();
		}

		private void PrintBooksButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new PrintBooksPage());
		}

		private void PrintPersonsButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new PrintPersonsPage());
		}

		private void ModifyPersonsBooksListButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new RentalPage());
		}
	}
}
