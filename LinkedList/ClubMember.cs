using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
	class ClubMember {
		public int Nr { get; set; }
		public string Fname { get; set; }
		public string Lname { get; set; }
		public int Age { get; set; }

		public override string ToString() {
			return this.Nr + " " + this.Fname + " " + this.Lname + " " + this.Age;
		}
	}
}
