using System.IO;
using System.Text;

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
			if(this.Head == null) {
				throw new ListEmptyException();
			}
			Node CurNode = this.Head;
			while(CurNode != null && Counter < index) {
				if(CurNode.Next == null) {
					throw new ElementNotFoundException();
				}
				CurNode = CurNode.Next;
				Counter++;
			}

			return CurNode.Data;
		}

		public override string ToString() {
			StringWriter Out = new StringWriter();

			Node CurNode = this.Head;
			while(CurNode != null) {
				Out.WriteLine(CurNode.Data.ToString());
			}
			
			return Out.ToString();
		}
	}

}
