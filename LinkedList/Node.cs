﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
	class Node {
		public Node Next = null;
		public object Data = null;

		public Node(object obj) {
			this.Data = obj;
		}
	}
}
