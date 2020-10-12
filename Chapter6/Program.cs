using Chapter6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
	class Program {
		static void Main(string[] args) {
			#region 6.1
			var number = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };
			var num = number.Max();
			Console.WriteLine(num);

			var numlast = number.Reverse().Take(2);
			foreach (var nums in numlast) {
				Console.Write(nums+" ");
			}
			Console.WriteLine();
			var moji = number.Select(x => x.ToString("000"));
			foreach (var strs in moji) {
				Console.Write(strs +" ");
			}
			Console.WriteLine();
			var nummin = number.OrderBy(x => x).Take(3);
			foreach (var nums in nummin) {
				Console.Write(nums+" ");
			}
			Console.WriteLine();
			var num10 = number.Where(x => x >= 10).Distinct().Count();
			Console.WriteLine(num10);
			#endregion
			#region 6.2
			var books = new List<Book> {
			new Book { Title = "C#プログラミングの新常識「C#」", Price = 3800, Pages = 378 },
			new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
			new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
			new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
			new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
			new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
			new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
			};

			int count = 0;

			foreach (var booc in books.Where(b => b.Title.Contains("C#"))) {
				for (int i = 0; i < booc.Title.Length-1; i++) {
					if ((booc.Title[i] == 'C')&& (booc.Title[i +1]=='#')) {
						count++;
					}
				}
			}
			books.Where(x => x.Title == "ワンダフル・C#ライフ").ToList().
				ForEach(x => Console.WriteLine($"本のタイトル：{x.Title}　価格：{x.Price}　ページ数：{x.Pages}"));
			Console.WriteLine();

			var C = books.Count(c =>c.Title.Contains("C#"));
			Console.WriteLine(C);

			var aveC = books.Where(c => c.Title.Contains("C#")).Average(c => c.Pages);
			Console.WriteLine(aveC);
			var book = books.FirstOrDefault(b => b.Price >= 4000);
			if (book != null) {
				Console.WriteLine(book.Title);
			}
			var pages = books.Where(b => b.Price < 4000).Max(b => b.Pages);
			Console.WriteLine(pages);

			var selected = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price);
			foreach (var item in selected) {
				Console.WriteLine(($"本のタイトル：{item.Title}　価格：{item.Price}　ページ数：{item.Pages}"));
			}
			var select = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
			foreach (var item in select) {
				Console.WriteLine(item.Title);
			}
			var Cc = books.Count(c => c.Title.Contains("C#"));
			Console.WriteLine(Cc);
			#endregion
		}
	}
}

