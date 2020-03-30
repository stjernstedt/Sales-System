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
using System.Windows.Shapes;

namespace Sales_System
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Scanner : Window
	{
		public Basket basket = new Basket();

		public Scanner()
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
