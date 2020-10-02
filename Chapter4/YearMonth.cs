using Chapter4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
	class YearMonth {
		#region 4.1.1
		//
		public int Year { get; private set; }
		public int Month { get; private set; }
		//コンストラクタ
		public YearMonth(int year, int month) {
			this.Year = year;
			this.Month = month;
		}

		#endregion
		#region 4.1.2
		public bool Is21Century {
			get {
				return 2001 <= Year && Year <= 2100;
				}
			}
		#endregion
		# region 4.1.3
		public YearMonth AddOneMoth() {
			if (this.Month == 12) {
				this.Year = Year + 1; this.Month = 1;
			} else {
				this.Month = this.Month + 1;
			}
			return new YearMonth(this.Year, this.Month);
		}
		#endregion
		#region 4.1.4
		public override string ToString() {
			return $"{Year}年{Month}月";
		}
		#endregion
	}

}

	


