//---------------------------------------------------------------------
// <copyright file="Linkedlist.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//---------------------------------------------------------------------
namespace DataStrutrure
{
    using System;
    public class LinkedList
    {
        
        static Node head;

        /*********************************************To remove************************************/
        public void Remove(int index)
        {
            try
            {
                if (index == 0)
                {
                    head = head.next;
                }
                else
                {
                    Node n = head;
                    Node n1 = null;
                    for (int i = 0; i < index - 1; i++)
                    {
                        n = n.next;
                    }
                    n1 = n.next;
                    n.next = n1.next;
                    Console.WriteLine("String was deleted is " + n1.data);
                }
                Console.ReadKey();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        /*************************************Add at index******************************************/
        public void Insert(string data, int index)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            Node n = head;
            if (index == 0)
            {
                Append(data);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    n = n.next;
                }
                node.next = n.next;
                n.next = node;
            }

        }
        /**********************************************Add at start*****************************/
        public void Append(string data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            node.next = head;
            head = node;
        }

        /****************************************Add at last******************************************/
        public void Add(string data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
                Console.WriteLine("Nothing list is empty intially ");
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        /***********************************************Show******************************************/
        public void Show()
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.Write(temp.data + "\t");
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
            Console.ReadKey();
        }

        /*******************************************Isempty*******************************************/
        public bool IsEmpty()
        {
            Node node = new Node();
            //node.data = data;
            //node.next = null;
            node = head;
            bool flag = false;
            if (head == null)
            {
                flag = true;
                //Console.WriteLine("Nothing list is empty ");
            }
            else
            {
                Console.WriteLine("Your file have some content in it");
                Listlength();
            }
            return flag;
        }

        /*******************************************Length of list*******************************************************/
        public void Listlength()
        {
            Node node = new Node();
            node = head;
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            Console.WriteLine("Number of element in your list is " + (count + 1));
            Console.ReadKey();
        }

        /***************************************String search*********************************************************/

        public bool Search(string data)
        {
            Node node = head;
           // int count = 0;
            bool flag = false;
            while (node.next != null)
            {
                if (data.Equals(node.data))
                {
                    flag = true;
                    
                }
               
            }
            return flag;
           
        }
      

    }
}
