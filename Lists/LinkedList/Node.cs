namespace LinkedList
{
    internal partial class Program
    {
        public class Node <T>
        {
            public T Data;
            public Node<T> Next;
            public Node<T> Previous;

            public Node(T data)
            {
                this.Data = data;
                Next = null;
                Previous = null;
            }
            public Node(T data, Node<T> previous, Node<T> next)
            {
                this.Data = data;
                this.Previous = previous;
                this.Next = next;
            }
        }
    }
}
