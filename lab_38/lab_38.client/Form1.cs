using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_38.client
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client client;

        public Form1()
        {
            InitializeComponent();

            this.client = new ServiceReference1.Service1Client();
            client.Open();

        /*    string sss = client.GetData(777);
            ServiceReference1.CompositeType ct = new ServiceReference1.CompositeType();
            ct.BoolValue = true;
            ct.StringValue = "string";

            ServiceReference1.CompositeType rc = client.GetDataUsingDataContract(ct);

            string str = client.Concant("str1","str2");
            int b = client.Sub(5, 4);
            b = client.Sum(5, 4);*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = client.Sum(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = client.Sub(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = client.Concant(textBox1.Text, textBox2.Text);
        }
    }
}
