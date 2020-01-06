 public class LinkedList
    {
        SinglyLinkedListNode  head;

        public LinkedList(SinglyLinkedListNode _head)
        {
            head = _head;
        }

        public void append(int data)
        {
            if(head==null)
            {
                head = new SinglyLinkedListNode(data);
            }
            else
            {
                var current = head;
                while(head.next !=null)
                {
                    current = head.next;
                }
                current.next = new SinglyLinkedListNode(data);
            }
        }

        public void prepend(int data)
        {
             if(head==null)
            {
                head = new SinglyLinkedListNode(data);
            }
            else
            {
                var current = new SinglyLinkedListNode(data);
                current.next = head;
                head = current;
            }
        }

        public void DeleteValue(int data)
        {
            if(head ==null)
            {
                return;
            }
            if(head.data == data)
            {
                head = head.next;
            }
            else
            {
                var current = head;
                while(current.next!=null)
                {
                    if(current.next.data == data)
                    {
                        current.next = current.next.next;
                        return;
                    }
                    current = current.next;
                }
            }
        }
    }
