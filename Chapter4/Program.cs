using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine(GetProduct());

		}
		private static string GetProduct() {
			Sale sale = new Sale {
				ShopName = "pet store",
				Amount = 10000,
				Product = "food"
			};
			return sale?.Product;

		}
		
	}
	class Sale {
		//店舗名
		public string ShopName { get; set; }
		//売上高
		public int Amount { get; set; }
		public string Product { get; set; }
	}
}


