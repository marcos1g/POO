using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  listBox1.Items.ToString().s

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(var d in listBox1.Items)
            {
                if (d.ToString().Length>5) { 
                listBox2.Items.Add(d);
                listBox1.Items.Remove(d);
                
                }


            }
            
            foreach(var g in listBox2.Items) {

                if (g.ToString().Length>5) { 
                listBox1.Items.Add(g);
                listBox2.Items.Remove(g);
                
                }
            
            
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
         //   listBox2.Items.Add(listBox1.SelectedItems[1]);
         //   listBox1.Items.Remove(listBox1.SelectedItems[10]);

           // listBox1.Items.Add();
           // listBox2.Items.Remove();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
         
            foreach (var c in listBox1.Items)
            {

                if (c.ToString().Length<5)
                {
                    listBox1.Items.Remove(c);

                }


            }

            foreach (var r in listBox2.Items)
            {

                if (r.ToString().Length<5)
                {
                    listBox2.Items.Remove(r);

                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
