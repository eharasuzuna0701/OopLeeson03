using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5 {
	class Program {
		static void Main(string[] args) {
			#region 5.1
			Console.WriteLine("____5.1____");
			var moj1 = Console.ReadLine();
			var moj2 = Console.ReadLine();
			if (String.Compare(moj1, moj2, true) == 0)
				Console.WriteLine("等しい");
			else
				Console.WriteLine("等しくない");
			#endregion
			#region 5.2
			Console.WriteLine("____5.2____");
			var moj3 = Console.ReadLine();
			int num;
			if (int.TryParse(moj3, out num)) {
				Console.WriteLine(num.ToString("#,#"));
			} else {
				Console.WriteLine("変換出来ませんでした");
			}
			#endregion
			#region 5.3
			#region 5.3.1
			Console.WriteLine("____5.3.1____");
			var jack = "Jackbaws lave my big sphinx of quartz";
			var kara = jack.Count(x => x == (' '));
			Console.WriteLine(kara);
			#endregion

			#region 5.3.2
			Console.WriteLine("____5.3.2____");
			var small = jack.Replace("big", "small");
			Console.WriteLine(small);
			#endregion
			#region 5.3.3+5.3.4
			Console.WriteLine("____5.3.3____");
			string[] words = small.Split(' ');
			Console.WriteLine(words.Count());

			Console.WriteLine("____5.3.4____");
			foreach (var word in words) {
				if (word.Length >= 4) {
					Console.WriteLine(word);
				}
			}
			#endregion
			#region 5.3.5
			Console.WriteLine("____5.3.5____");
			var sb = new StringBuilder();
			foreach (var word in jack) {
				sb.Append(word);
			}
			var text = sb.ToString();
			Console.WriteLine(text);
			#endregion
			#endregion
			#region 5.4
			Console.WriteLine("____5.4____");

			var Best = ("Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886;");
			string[] list = {"作家", "代表作", "誕生年",};
			string[] value = { "Novelist=", "BestWork=", "Born=" };
			string[] tanizaki = Best.Split(';');
			for (int i = 0; i < list.Count(); i++) {
				tanizaki[i] = tanizaki[i].Substring(value[i].Length);
				Console.WriteLine(string.Format($"{list[i]}:{tanizaki[i]}"));
			}
			#endregion
		}
	}
}
