using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharpplayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] array ={ {"a","s","r","t"},{"3","4","6","7"}};
            for (int i = 0; i <array.GetLength(0); i++)
            {
                for (int j=0; j<array.GetLength(1);j++)
                {
                    Console.WriteLine(array[i, j]);
                    textBox1.Text = textBox1.Text + array[i,j];
                }

            }

           // string[][] array2 = { { "a", "s", "r", "t" }},{{ "3", "4", "6", "7" } };
       

         
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaction t1 = new Transaction("001", "9/23/2015", 1000000);

            textBox1.Text = t1.showTransaction();
        }
    }
}
