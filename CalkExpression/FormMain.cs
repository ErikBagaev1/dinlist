using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DinList;

namespace CalkExpression
{
    public partial class FormMain : Form
    {
        Queue<string> backExpresstion;
        Dictionary<char, byte> prioret = new Dictionary<char, byte>
        {
            {'+', 1 },
            {'-', 1 },
            {'*', 2 },
            {'/', 2 },
            {'(', 0 },
            {')', 0 }

        };
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void Expesstion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            DinStack ds = new DinStack();
            foreach (var s in BackExpression)
         
            {   char c = s[0];
                if (c >= '0' && c <= '9')
                    ds.Push(s.ToString());
                else
                {
                    int a = Convert.ToInt32(ds.Pop().toString());
                    int b = Convert.ToInt32(ds.Pop().toString());
                    switch (c)
                    {
                        case '+': a = a + b;break;
                        case '-': a = b - a; break;
                        case '*': a = a * b; break;
                        case '/': a = b / a; break;
                    }
                    ds.Push(a.ToString());
                }
            }
            labelResult.Text = ds.Pop().ToString();       
          
        }
        DinStack calc_back = new DinStack();


        private void BackExpresstion_TextChanged(object sender, EventArgs e)
        {
     
        }
        string queueToString(Queue<string> q)
        {
            string temp = "";
            foreach (var t in q)
                temp += t + " ";

        }
        private void buttonCalkBackExprisstion_Click(object sender, EventArgs e)
        {
            backExpresstion = new Queue<string>();
               string temp = "";
            foreach(var c in textBoxExpression.Text)
            {
                if (c>='0' && c <= '9')
                {
                    temp += c;
                }
                else
                {
                    if (!string.IsNullOrEmpty(temp))backExpresstion.Enqueue(temp);
                    temp = string.Empty;
                    if (c == " (")
                        calc_back.Push(c.ToString());
                    else {
                        if( c ==')')
                    {
                            while (calc_back.Peek()[0] != '('.ToString())
                            {
                                backExpresstion.Enqueue(calc_back.Peek());
                            }
                            calc_back.Peek();
                    }
                        else
                        {
                            while (!calc_back.isEmpty() &&  prioret[c]<= prioret[calc_back.Peek()[0]])
                        {
                                 backExpresstion.Enqueue(calc_back.Peek());
                        }
                            calc_back.Push(c.ToString());
                        }
                    }
                    
                }
            }
            while (!calc_back.isEmpty)
            {
                backExpresstion.Enqueue(calc_back.Pop());
            }
            textBoxBackExpresstion.Text = queueToString(backExpresstion);
        }
    }
}
