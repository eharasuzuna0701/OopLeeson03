using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
	class Program {
		static void Main(string[] args) {
			//4.1.1
			var ym = new YearMonth[] {
			new YearMonth(1980,1),
			new YearMonth(1982,3),
			new YearMonth(1984,5),
			new YearMonth(1986,7),
			new YearMonth(2008,9),
			};
			Console.WriteLine("___4.2.2___");
			Exercise2_2(ym);
			Console.WriteLine("___4.2.3___");
			Console.WriteLine(FindFirst21C(ym));
			Console.WriteLine("___4.2.4___");
			Exercise2_4(ym);
			Console.WriteLine("___4.2.5___");
			Exercise2_5(ym);
		}

		//4.2.2
		public static void Exercise2_2(YearMonth[] ym) {
			foreach (var num in ym) {
				Console.WriteLine(num);
			}
		}

		//4.2.3
		static YearMonth FindFirst21C(YearMonth[] yms) {

			foreach (var ym in yms) {

				if (ym.Is21Century) {
					return ym;

				}
			}
			return null;
		}
		//4.2.4
		private static void Exercise2_4(YearMonth[] ym) {
			var ymonth = FindFirst21C(ym);
			if (ymonth == null) {
				Console.WriteLine("21世紀のデータはありません");
			} else {
				Console.WriteLine(ym);
			}

		}
		//4.2.5
		private static void Exercise2_5(YearMonth[] ym) {
			var array = ym.Select(ymo => ymo.AddOneMoth()).ToArray();
			foreach (var ymo in array) {
				Console.WriteLine(ymo);
			}
		}

	}
}


