using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Черновик
{
    class Node 
    {
        public Node() { }
        public Node(int value, Node left, Node right) 
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
        int value;
        Node left, right;
    }

    class Program
    {
        public void foo()
        {
            Console.WriteLine("foo in main class");
        }

        public static void boo()
        {
            Console.WriteLine("goo in main class | static");
        }

        static void Main(string[] args)
        {
            //Node root = new Node(1, new Node(7, new Node(5, null, new Node(2, null, null)), new Node(0, null, null)), new Node(4, null, null));


            Program program = new Program();

            program.foo();
            Program.boo();


            //root.foo();
            //root.boo();

            //foo();
        }
    }
}
