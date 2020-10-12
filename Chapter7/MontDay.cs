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
		public override bool Equals(object obj) {
			var other = obj as MontDay;
			if (other == null)
				throw new ArgumentException();
			return this.Day == other.Day && this.Mouth == other.Mouth;
		}
		public override int GetHashCode() {
			var cord = Mouth.GetHashCode();
			return base.GetHashCode()*31 + Day.GetHashCode();
		}
	}
}
