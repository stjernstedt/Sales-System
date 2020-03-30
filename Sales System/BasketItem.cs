using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System
{
	public class BasketItem
	{
		public string Name { get; set; }
		public int ItemId { get; set; }
		public double Price { get; set; }

		public BasketItem(Item item)
		{
			Name = item.name;
			ItemId = item.itemId;
			Price = item.price;
		}
	}
}
