using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList {
	class MyList {
		private Node Head { get; set; }

		public void Insert(object obj) {
			Node NewNode = new Node(obj);

			NewNode.Next = this.Head;
			this.Head = NewNode;
		}

		public void Delete() {
			this.Head = this.Head.Next;
		}

		public object Search(int index) {
			int Counter = 0;
			Node CurNode = this.Head;
			while(CurNode != null && Counter < index) {
				CurNode = CurNode.Next;
				Counter++;
			}

			return CurNode.Data;
		}

		public override string ToString() {
			throw new NotImplementedException();
		}
	}
}
