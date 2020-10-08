using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
	class Program {
		static void Main(string[] args) {
			//整数の例
			var number = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24, };
			var strings = number.Select(n => n.ToString("0000")).ToArray();
			foreach (var str in strings) {
				Console.Write(str + " ");
			}
			Console.WriteLine();

			number.Select(n => n.ToString("0000")).
				Distinct().ToList().ForEach(s => Console.Write(s + " "));
			Console.WriteLine();

			number.OrderBy(n => n).Distinct().ToList().ForEach(s => Console.Write(s + " "));

			//文字列の例
			Console.WriteLine("");
			var words = new List<string> {
			"Microsoft","Apple","Google","Oracle","Facebook",
			};
			var lower = words.Select(name => name.ToLower().ToArray());
			var books = Books.GetBooks();
			//タイトルリスト
			Console.WriteLine();
			var titles = books.Select(t => t.Title);
			foreach (var title in titles) {
				Console.Write(title + " ");
			}
			Console.WriteLine();
			
			//ページ数の多い順に並び変え

			var soortbooks = books.OrderByDescending(n => n.Pages).Take(3);
			foreach (var book in soortbooks) {
				Console.WriteLine(book.Title +" "+book.Pages);
			}

		}
	}
}

