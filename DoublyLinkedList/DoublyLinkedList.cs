using System;

namespace DoublyLinkedList
{
	public class DoublyLinkedList<T> where T : IComparable<T>
	{
		public Link<T> First { get; set; }
		public Link<T> Last { get; set; }
		public DoublyLinkedList(){ First = null;Last = null; }
		public bool IsEmpty()
		{ return First == null; }
		public Link<T> Find(T key)
		{
			if (IsEmpty()) return null;
			Link<T> current = First;
			while(current.CompareTo(key) != 0)
			{
				if (current.Next == null)
					return null;
				else
					current = current.Next;
			}
			return current;
		}
		public void InsertFirst(T dd)
		{
			Link<T> newLink = new Link<T>(dd);
			if (IsEmpty())
				Last = newLink;
			else
				First.Previous = newLink;
			newLink.Next = First;
			First = newLink;
		}
		public void InsertLast(T dd)
		{
			Link<T> newLink = new Link<T>(dd);
			if (IsEmpty())
				First = newLink;
			else
			{
				Last.Next = newLink;
				newLink.Previous = Last;
			}
			Last = newLink;
		}
		public Link<T> DeleteFirst()
		{
			if (IsEmpty()) return null;
			Link<T> temp = First;
			if (First.Next == null)
				Last = null;
			else
				First.Next.Previous = null;
			First = First.Next;
			return temp;
		}
		public Link<T> DeleteLast()
		{
			if (IsEmpty()) return null;
			Link<T> temp = Last;
			if (First.Next == null)
				First = null;
			else
				Last.Previous.Next = null;
			Last = Last.Previous;
			return temp;
		}
		public bool InsertAfter(T key, T dd)
		{
			Link<T> current = Find(key);
			if (current == null) return false;
			Link<T> newLink = new Link<T>(dd);
			if(current == Last)
			{
				newLink.Next = null;
				Last = newLink;
			}
			else
			{
				newLink.Next = current.Next;
				current.Next.Previous = newLink;
			}
			newLink.Previous = current;
			current.Next = newLink;
			return true;
		}
		public void Insert(T key)
		{
			Link<T> newLink = new Link<T>(key);
			Link<T> previous = null;
			Link<T> current = First;
			while(current != null && current.CompareTo(key) < 0)
			{
				previous = current;
				current = current.Next;
			}
			if (previous == null)
				First = newLink;
			else
				previous.Next = newLink;
			newLink.Next = current;
			//Poprawka dla listy dwukierunkowej
			if (current == null)
				Last = newLink;
			else
				current.Previous = newLink;
			newLink.Previous = previous;
		}
		public Link<T> DeleteKey(T key)
		{
			Link<T> current = Find(key);
			if (current == null) return null;
			if (current == First)
				First = current.Next;
			else
				current.Previous.Next = current.Next;
			if (current == Last)
				Last = current.Previous;
			else
				current.Next.Previous = current.Previous;
			return current;
		}
		public void DisplayForward()
		{
			Console.Write("List (first-->last): ");
			Link<T> current = First;
			while(current != null)
			{
				current.DisplayLink();
				current = current.Next;
			}
			Console.WriteLine();
		}
		public void DisplayBackward()
		{
			Console.Write("List (last-->first): ");
			Link<T> current = Last;
			while (current != null)
			{
				current.DisplayLink();
				current = current.Previous;
			}
			Console.WriteLine();
		}
	}
}
