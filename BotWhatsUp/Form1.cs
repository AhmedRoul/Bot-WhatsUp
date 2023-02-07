using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotWhatsUp
{
    public partial class Form1 : Form
    {
        public string message;
        public string choose;
        public string NameOrPhone;

        public Form1()
        {
            InitializeComponent();
            Choose_design.Items.Add("ALL");
            Choose_design.Items.Add("multi");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            message = Message_design.Text;
            choose = Choose_design.Text;
            NameOrPhone=Name_design.Text;


        }
    }
}
