using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScrambler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         



        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;

        }
    }

    public class Scrambler
    {
        List<string> symbols = new List<string>();


        //    //List<string> symbol = new List<string>
        //    //{
        //    //    symbol.Add(str);
        //    //}
    }
}
