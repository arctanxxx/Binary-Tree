using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreInPosTraversal
{
    class Program
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int data)
            {
                this.value = data;
            }
        }

        public static void preOrderRecur(Node head)
        {
            if(head == null)
            {
                return;
            }
            Console.Write(head.value + " ");
            preOrderRecur(head.left);
            preOrderRecur(head.right);
        }

        public static void inOrderRecur(Node head)
        {
            if (head == null)
            {
                return;
            }
            inOrderRecur(head.left);
            Console.Write(head.value);
            inOrderRecur(head.right);
        }

        public static void posOrderRecur(Node head)
        {
            if (head == null)
            {
                return;
            }
            posOrderRecur(head.left);
            posOrderRecur(head.right);
            Console.Write(head.value + " ");
        }

        public static void preOrderUnRecure(Node head)
        {
            Console.Write("pre-order:");
            if(head != null)
            {
                Stack<Node> stack = new Stack<Node>();
                stack.Push(head);
                while(stack.Count != 0)
                {
                    head = stack.Pop();
                    Console.Write(head.value + " ");
                    if (head.right != null)
                        stack.Push(head.right);
                    if (head.left != null)
                        stack.Push(head.left);
                }
            }
            Console.WriteLine();
        }

        public static void inOrderUnRecure(Node head)
        {
            Console.Write("in-order:");
            if(head != null)
            {
                Stack<Node> stack = new Stack<Node>();
                while (stack.Count != 0 || head != null)
                {
                    if (head != null)
                    {
                        stack.Push(head);
                        head = head.left;
                    }
                    else
                    {
                        head = stack.Pop();
                        Console.Write(head.value + " ");
                        head = head.right;
                    }
                }
            }
            Console.WriteLine();
        }

        public static void posOrderUnRecure1(Node head)
        {
            Console.Write("pos-order:");
            if (head != null)
            {
                Stack<Node> s1 = new Stack<Node>();
                Stack<Node> s2 = new Stack<Node>();
                s1.Push(head);
                while (s1.Count != 0)
                {
                    head = s1.Pop();
                    s2.Push(head);
                    if (head.left != null)                   
                        s1.Push(head.left);                   
                    if (head.right != null)                    
                        s1.Push(head.right);                    
                }
                while (s2.Count != null)
                    Console.Write(s2.Pop().value + " ");
            }
        }

        // 待研究 非递归后续打印节点
        public static void posOrderUnRecure2(Node h)
        {
            Console.Write("pos-Order:");
            if (h != null)
            {
                Stack<Node> stack = new Stack<Node>();
                stack.Push(h);
                Node c = null;
                while (stack.Count != 0)
                {
                    // Peek(): return node top of the stack but not remove
                    c = stack.Peek();
                    if (c.left != null && h != c.left && h != c.right)
                    {
                        stack.Push(c.left);
                    }                       
                    else if (c.right != null && h != c.right)
                    {
                        stack.Push(c.right);
                    }                    
                    else
                    {
                        Console.Write(stack.Pop().value + " ");
                        h = c;
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

        }
    }
}
