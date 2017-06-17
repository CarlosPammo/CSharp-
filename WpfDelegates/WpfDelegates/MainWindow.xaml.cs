using System;
using System.Collections.Generic;
using System.Linq;
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
using WpfDelegates.Model;

namespace WpfDelegates
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<Contact> Contacts { get; set; }

		public MainWindow()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{
			Contacts = new List<Contact>
				           {
							   new Contact
								   {
										Name = "Carlos",
										Lastname = "Pammo",
										Address = "Por aqui",
										Telephone = "70309082"
								   },
								   new Contact
								   {
										Name = "Roberto",
										Lastname = "Illanes",
										Address = "Por all",
										Telephone = "70312344"
								   },
				           };

			DGContacts.DataContext = Contacts;
			DGContacts.Items.Refresh();
		}

		private void BtnCerrar_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void BtnNew_Click(object sender, RoutedEventArgs e)
		{
			EditarContacto editor = new EditarContacto();
			editor.OnAccept += AddNewCoctact;
			editor.Show();
		}

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact)DGContacts.SelectedItem;
            EditarContacto editor = new EditarContacto(selected);
            editor.OnAccept += AddNewCoctact;
            editor.Show();
        }

		private void BtnSearch_Click(object sender, RoutedEventArgs e)
		{

		}

		private void AddNewCoctact(Contact contact)
		{
			Contacts.Add(contact);
			DGContacts.DataContext = Contacts;
			DGContacts.Items.Refresh();
		}
	}
}
