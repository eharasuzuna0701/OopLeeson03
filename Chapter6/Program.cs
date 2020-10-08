using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
	class Program {
		static void Main(string[] args) {
			var numbar = new List<int> { 9, 7, -5, 4, 2, 5, -4, 0, 4, -1, 0, 4, };
			Console.WriteLine($"平均値：{numbar.Average()}");
			Console.WriteLine($"合計：{numbar.Sum()}");
			Console.WriteLine($"最小値：{numbar.Where(n => n>0).Min()}");
			Console.WriteLine($"最大値：{numbar.Min()}");
			bool exists = numbar.Any(n => n % 7 == 0);

			var results = numbar.Where(n => n > 0).Take(5);
			foreach (var result in results) {
				Console.Write(result +" ");
			}

			var books = Books.GetBooks();
		
			Console.WriteLine($"平均価格：{books.Average(x => x.Price)}円");
			Console.WriteLine($"合計価格：{books.Sum(x => x.Price)}円");
			Console.WriteLine($"ページ最大値：{books.Max(x => x.Pages)}ページ" );
			Console.WriteLine($"高価な本：{books.Max(x => x.Price)}円");
			Console.WriteLine($"タイトルに物語がある本：{books.Count(x => x.Title.Contains("物語"))}冊");
			//600ページを超える書籍があるか
			Console.WriteLine(books.Any(n => n.Pages >= 600) ?
				"ページが600以上の本が存在します" : "ページが600以上ある本は存在しません");

			//すべてが200ページを超える書籍か？
			Console.WriteLine(books.All(n => n.Pages >= 200) ?
				"すべての書籍が200ページ以上です" : "200ページを超えていない書籍があります");

			//400ページを超える本は何冊目か
			var page = books.FirstOrDefault(n => n.Pages > 400);
			int i;
			for ( i = 0; i < books.Count; i++) {
				if (books[i].Title.Contains(page.Title)) {
					break;
				}
			}
			Console.WriteLine($"400ページを超える本は{i +1}冊目です");
			var count = books.FindIndex(n => n.Pages >= 1000);
			Console.WriteLine($"1000ページを超える本は{count +1}冊目です");
			//本の値段が400円以上
			var prices = books.Where(n => n.Price >= 400).Take(3);
			foreach (var price in prices) {
				Console.WriteLine($"400円以上の本：{price.Title}");
			}
			
		}
	}
}
