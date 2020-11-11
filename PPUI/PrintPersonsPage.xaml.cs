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
	public partial class PrintPersonsPage : Page
	{
		public PrintPersonsPage()
		{
			InitializeComponent();

			personsListBox.ItemsSource = Library.Persons;
		}

		private void AddPersonButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new AddPersonPage());
		}

		private void CancelButtonClick(object sender, RoutedEventArgs e)
		{
			Parent.SetValue(ContentProperty, new MenuPage());
		}

		private void PrintPersonButtonClick(object sender, RoutedEventArgs e)
		{
            if (personsListBox.SelectedItem != null)
            {
                Parent.SetValue(ContentProperty, new PersonPage((Person)personsListBox.SelectedItem)); 
            }
		}

		private void DeletePersonButtonClick(object sender, RoutedEventArgs e)
		{
            if (personsListBox.SelectedItem != null)
            {
				Library.Persons.Remove((Person)personsListBox.SelectedItem);
				Parent.SetValue(ContentProperty, new PrintPersonsPage());
			}
		}
	}
}
