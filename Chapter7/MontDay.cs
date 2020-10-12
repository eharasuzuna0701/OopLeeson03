using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7 {
	class MontDay {
		public int Day { get; private set; }
		public int Mouth { get; private set; }

		public MontDay(int mouth, int day) {
			this.Day = day;
			this.Mouth = mouth;
		}
	}
}
