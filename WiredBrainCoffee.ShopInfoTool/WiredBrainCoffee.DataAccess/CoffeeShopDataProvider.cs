using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
	public class CoffeeShopDataProvider
	{
		public IEnumerable<coffeeShop> LoadCoffeeShops()
		{
			yield return new coffeeShop { Location = "Frankfurt", BeansInStockInKg = 107 };
			yield return new coffeeShop { Location = "Frieburg", BeansInStockInKg = 23 };
			yield return new coffeeShop { Location = "Munich", BeansInStockInKg = 56 };
		}
	}
}
