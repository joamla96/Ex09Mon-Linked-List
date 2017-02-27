using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
	class Node {
		public Node Next { get; set; }
		public object Data { get; set; }

		public Node(object obj) {
			this.Data = obj;
		}
	}
}
