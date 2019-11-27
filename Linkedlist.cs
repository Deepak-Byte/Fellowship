//---------------------------------------------------------------------
// <copyright file="Linkedlist.cs" company="BasicPrograms">
// Company copyright tag.
// </copyright>
//---------------------------------------------------------------------
namespace DataStrutrure
{
    using System;

    /// <summary>
    /// This linked list .
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// This is Remove .
        /// </summary>
        static Node head;
        /******************************************To remove************************************/
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
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        /*************************************Add at index******************************************/
        /// <summary>
        /// This is Insert.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        public void Insert(object data, int index)
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
        /// <summary>
        /// This is Append.
        /// </summary>
        /// <param name="data"></param>
        public void Append(object data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            node.next = head;
            head = node;
        }

        /****************************************Add at last******************************************/
        /// <summary>
        ///  This is Add.
        /// </summary>
        /// <param name="data"></param>
        public void Add(object data)
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
            Console.WriteLine("The number added is "  + data);
        }

        /***********************************************Show******************************************/
        /// <summary>
        ///  This is Show.
        /// </summary>
        public void Show()
        {
            Node temp = head;
            while (temp.next != null)
            {
                Console.Write(temp.data + "->\t");
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
            Console.ReadKey();
        }

        /*******************************************Isempty*******************************************/
        /// <summary>
        /// This is Isempty.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// This is Listlength.
        /// </summary>
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
        /// <summary>
        /// This is Saerch.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Search(object data)
        {

            Node node = head;
            int count = 0;
            while (node != null)
            {
                if ((node.data).Equals(data))
                {
                    count++;
                    Remove(count + 1);
                    return true;
                }
                node = node.next;
            }
            Add(data);
            return false;
        }

        /************************************************POP at last************************************************/
        /// <summary>
        ///  This is Pop method.
        /// </summary>
        public void Pop()
        {
            Node node = new Node();
            Node n = head;
            int count = 0;
            while (n.next != null)
            {
                n = n.next;
                count++;
            }
            Console.WriteLine(n.data);
            Remove(count);
        }





    }
}
