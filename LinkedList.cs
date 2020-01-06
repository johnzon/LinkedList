/*
An implementation of Single Link list class  with cosntructor.
*/ 

public class LinkedList
    {
        SinglyLinkedListNode  head;

        public LinkedList(SinglyLinkedListNode _head)
        {
            head = _head;
        }

 /*
Append = add the data to the end of the current tail i.e the last elemtn of the list. if the
list currently has no element.The data is set as the head
*/ 
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
 /*
Prepend  add the data to the beginning of the current head i.e the first elemtn of the list. if the
list currently has no element.The data is set as the head.
The current head is set as the next pointer to the head.
*/ 
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
 /*
Delete value remove the reference to the node having the current specified data.

*/ 
        public void DeleteValue(int data)
        {
            if(head ==null)
            {
                return;
            }
         //If the head has the data, set head to the current next element to head
         //else, starting from current's next which will not be the head.
         //update the pointer to point to the current next's next element
         if(head.data == data)
            {
                head = head.next;
            }
            else
            {
                var current = head;
                while(current.next!=null)
                {
                  //current.next ensure that we don't delete head data in this logic because it has been handled above
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
