using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DinList
{
    public class Node
    {
        public string val;
        public Node adr;
        public Node(string c)
        { val = c; adr = null; }

        public string ToString()
        {
            return val.ToString();
        }
    }

    
 public class Dinstack
{
    Node top = null;

    public Dinstack() { }

    public void Push(string c)
        {
            Node temp = new Node(c);
            temp.adr = top;
            top = temp;
        }
        public string ToString()
        {
            string rez = "";
            Node current = top;
            while (current != null)
            {
                rez += current.ToString();
                current = current.adr;
            }
            return rez;
        }
        public string Pop()
        {
            
            string rez = top.val;
            top = top.adr;
            return string.Empty;
        }
        public string Peek()
        {
            return top.val;
        }
}
}
    class Program
    {  
        static string sk_open = "({[<";
        static string sk_close = ")}]>";
        //static bool para(char c, char temp)
        //{
        //    int  ind_open = sk_open.IndexOf(open);
        //    char temp_close = sk_close[ind_open];
        //}
        //static void Main(string[] args)
        //{
          
        //        string sk = "([]{()})";
        //        Dinstack st = new Dinstack(')');
        //        string ans = "Yes";
        //        foreach (var c in sk)
        //        {
        //            if (sk_open.IndexOf(c) >= 0)
        //                st.Push(c);
            
        //        else
        //        {
        //            char temp = st.Pop();
        //            if (!para(c, temp)) ans = "No";
        //        }
           
        //    }
        }
    


