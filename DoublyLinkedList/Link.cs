using System;

namespace DoublyLinkedList
{
	public class Link<T> : IComparable<Link<T>> where T : IComparable<T>
	{
		public T Data { get; set; }
		public Link<T> Next { get; set; }
		public Link<T> Previous { get; set; }
		public Link() { Next = null; Previous = null; }
		public Link(T d) { Data = d; Next = null; Previous = null; }
		public void DisplayLink()
		{ Console.Write(Data.ToString() + " "); }
		public int CompareTo(Link<T> other) { return Data.CompareTo(other.Data); }
		public int CompareTo(T other) { return Data.CompareTo(other); }
	}
}