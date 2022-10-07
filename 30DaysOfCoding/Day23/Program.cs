using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Node{
    public Node left,right;
    public int data;
    public Node(int data){
        this.data=data;
        left=right=null;
    }
}
class Solution{

    static Queue<Node> queue = new Queue<Node>();
	static void levelOrder(Node root){
        if(root is not null){
          queue.Enqueue(root);
          while(queue.Any())
          {
            var node = queue.Dequeue();
            Console.Write(node.data+ " ");
            if(node.left is not null)
              queue.Enqueue(node.left);
            if(node.right is not null)
              queue.Enqueue(node.right);

          }
        }
    }

	static Node insert(Node root, int data){
        if(root==null){
            return new Node(data);
        }
        else{
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else{
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }
    static void Main(String[] args){
        Node root=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            root=insert(root,data);            
        }
        levelOrder(root);
        
    }
}
