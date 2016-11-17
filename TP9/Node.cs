using System;

namespace TP9
{
	public class Node
	{
		private int _key;
		private Node _rchild;
		private Node _lchild;

		public Node(int key,Node lchild,Node rchild)
		{
			_key = key;
			_rchild = rchild;
			_lchild = lchild;
		}

		public int Key
		{
			get{return _key; }
			set{ _key = value; }
		}

		public Node Lchild
		{
			get{ return _lchild; }
			set{ _lchild = value; }
		}

		public Node Rchild
		{
			get{ return _rchild; }
			set{ _rchild = value; }
		}

	
	}
}

