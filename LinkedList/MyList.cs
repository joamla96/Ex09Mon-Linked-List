﻿using System.IO;
using System;

namespace LinkedList {
	public class MyList {
		private Node Head { get; set; }
		// Should be public with private set? Otherwise outsiders cant get to the list, but may be the point or?

		public void Insert(IComparable obj) {
			Node NewNode = new Node(obj);

			NewNode.Next = this.Head;
			this.Head = NewNode;
		}

		public void Insert(IComparable obj, int index) { // TODO: Protect against end of list; null reference
			Node NewNode = new Node(obj);

			Node Before = this.SearchNode(index - 1);
			Node After = this.SearchNode(index); // TODO: Improve Effiency, don't search from beginning

			Before.Next = NewNode;
			NewNode.Next = After;
		}

		public void Delete() {
			this.Head = this.Head.Next;
		}

		public void Delete(int index) {  // TODO: Protect against end of list; null reference
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
					throw new IndexOutOfRangeException();
				}
				CurNode = CurNode.Next;
				Counter++;
			}

			return CurNode;
		}

		public object Search(int index) {
			Node SearchNode = this.SearchNode(index);
			return SearchNode.Data;
			// Shorthand: return this.SearchNode(index).Data;
		}

		public void Sort() {
			Node CurNode = this.Head;
			while(CurNode != null) {
				if(CurNode.Data.CompareTo(CurNode.Next.Data) < 0) {
					this.Switch(CurNode, CurNode.Next);
				}

				CurNode = CurNode.Next;
			}
		}

		public void Switch(Node A, Node B) { // KISS
			IComparable X = A.Data; // If its stupid but works,
			IComparable Y = B.Data; // is it really that stupid?

			A.Data = Y;
			B.Data = X;
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
