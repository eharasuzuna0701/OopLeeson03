using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3 {
	class Program {
		static void Main(string[] args) {
			var number = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

			#region 3.1.1
			var exist = number.Exists(n => n % 8 == 0 || n % 9 == 0);
			if(exist)
				Console.WriteLine("存在します");
			else
				Console.WriteLine("存在しません");
			#endregion
			#region 3.1.2
			number.ForEach(n => Console.WriteLine(n / 2.0 ));
			Console.WriteLine("次の問題");
			#endregion
			#region 3.1.3
			foreach (var i in number.Where(n => n >= 50)) {
				Console.WriteLine(i);
			}
			#endregion
			#region 3.1.4
			List<int> lists = number.Select(n => n * 2).ToList();
			foreach (var lis in lists) {
				Console.WriteLine(lis);
			}
			#endregion
			var numes = new List<String> {
			"Tokyo","new Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong"};
			#region 3.2.1
			//do {
			//	var line = Console.ReadLine();
			//	if (string.IsNullOrEmpty(line)) {
			//		break;
			//	}
			//	var index = numes.FindIndex(s => s == line);
			//	Console.WriteLine(index);
			//} while (true);
			#endregion
			#region 3.2.2
			var count = numes.Count(s => s.Contains('o'));
			Console.WriteLine(count);
			#endregion
			#region 3.2.3
			var selected = numes.Where(s => s.Contains('o')).ToArray();
			foreach (var name in selected) {
				Console.WriteLine(name);
			}
			#endregion
			#region 3.2.4
			var ctiy = numes.Where(s => s.StartsWith("B")).Select(s => s.Length);
			foreach (var length in ctiy) {
				Console.WriteLine($"文字数の長さ：{length}");
			}
			#endregion


		}
	}
}
