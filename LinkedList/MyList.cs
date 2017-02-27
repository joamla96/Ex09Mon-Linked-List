using System.IO;
using System.Text;

namespace LinkedList {
	public class MyList {
		private Node Head { get; set; }

		public void Insert(object obj) {
			Node NewNode = new Node(obj);

			NewNode.Next = this.Head;
			this.Head = NewNode;
		}

		public void Insert(object obj, int index) {
			Node NewNode = new Node(obj);

			Node Before = this.SearchNode(index - 1); 
			Node After = this.SearchNode(index); // TODO: Improve Effiency, don't search from beginning

			Before.Next = NewNode;
			NewNode.Next = After;
		}

		public void Delete() {
			this.Head = this.Head.Next;
		}

		public void Delete(int index) {
			Node Before = this.SearchNode(index - 1);
			Node After = this.SearchNode(index + 1); // TODO: Improve Effiency, don't search from beginning

			Before.Next = After;
		}

		private Node SearchNode(int index) {
			int Counter = 0;
			if (this.Head == null) {
				throw new ListEmptyException();
			}
			Node CurNode = this.Head;
			while (CurNode != null && Counter < index) {
				if (CurNode.Next == null) {
					throw new ElementNotFoundException();
				}
				CurNode = CurNode.Next;
				Counter++;
			}

			return CurNode;
		}

		public object Search(int index) {
			Node SearchNode = this.SearchNode(index);
			return SearchNode.Data;
		}

		public override string ToString() {
			StringWriter Out = new StringWriter();

			Node CurNode = this.Head;
			while(CurNode != null) {
				Out.WriteLine(CurNode.Data.ToString());
				CurNode = CurNode.Next;
			}
			
			return Out.ToString();
		}
	}

}
