using System;
using System.Collections.Generic;

namespace TP9
{
	public class Btree
	{
		private Node root;

		public Btree(Node node)
		{
			root = node;
		}

		public Node Root
		{
			get{ return root; }
			set{ root = value; }
		}

		public int size(Node node)
		{
			if (node == null) 
			{
				return 0;
			}

			return 1 + size(node.Lchild)+size(node.Rchild)
		}

		public int depth(Node node)
		{
			return node == null ? -1 : 1 + Math.Max (depth (node.Lchild), depth (node.Rchild));
		}

		public void depthDisplay(Node node,string order)
		{
			if (node == null) 
			{
				return;
			} 

			if (order == "prefix") 
			{
				Console.Write (node.Key + " ");
			}

			depthDisplay (node.Lchild, order);

			if (order == "infix") 
			{
				Console.Write (node.Key + " ");
			}
			depthDisplay (node.Rchild, order);

			if (order == "suffixe") 
			{
				Console.Write (node.Key + " ");
			}
		}

		public void BreathDisplay(Node node)
		{
			if (this == null)
				return;
			Queue<Node> q = new Queue<Node> ();
			q.Enqueue (root);
			while (q.Count != 0) 
			{
				Node cur = q.Dequeue ();
				Console.Write (cur.Key + " ");
				if (root.Lchild != null)
					q.Enqueue (cur.Lchild);
				if (root.Rchild != null)
					q.Enqueue (cur.Rchild);
			}

		}

		public Node addNode(Node node,int data)
		{
			
		}

		public bool searchNode(Node node,int s)
		{
			
		}

		public int maxValue(Node node)
		{
			
		}

		public void deleteNode(Node node,int s)
		{
			
		}
	}
}

