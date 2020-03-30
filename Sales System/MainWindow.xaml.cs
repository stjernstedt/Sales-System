using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sales_System
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//public List<Item> Basket = new List<Item>();
		public Basket basket = new Basket();
		public MainWindow()
		{
			InitializeComponent();
			Item item = new Item("Shirt");
			Item item2 = new Item("Pants");
			basket.AddItem(item);
			basket.AddItem(item2);


			DataContext = basket;
			basketView.ItemsSource = basket.basketContents;
		}
	}
}
