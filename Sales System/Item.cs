using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System
{
	public class Item
	{
		static Random randomGen = new Random();

		public string name;
		public double price;
		public double plu;
		public int itemId;

		public Item(string name)
		{
			this.name = name;
			itemId = randomGen.Next(1, 1000);

			price = 1990;
		}
	}
}
