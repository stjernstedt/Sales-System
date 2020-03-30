using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System
{
	public class Basket
	{
		public List<BasketItem> basketContents = new List<BasketItem>();
		public double BasketContentsSubtotal { get; set; }
		public double BasketContentsTotal { get; set; }

		public void AddItem(Item item)
		{
			BasketItem basketItem = new BasketItem(item);
			basketContents.Add(basketItem);
			CalculateTotals();
		}

		void CalculateTotals()
		{
			double subTotal = 0;
			foreach (var item in basketContents)
			{
				subTotal += item.Price;
			}

			BasketContentsSubtotal = subTotal;
			BasketContentsTotal = subTotal * 1.1;
		}
	}
}
