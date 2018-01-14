using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ServiceReference1.WebService1SoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new ServiceReference1.WebService1SoapClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = client.Sum(Int32.Parse(textBoxX.Text), Int32.Parse(textBoxY.Text)).ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = client.Sub(Int32.Parse(textBoxX.Text), Int32.Parse(textBoxY.Text)).ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = client.Mul(Int32.Parse(textBoxX.Text), Int32.Parse(textBoxY.Text)).ToString();
        }

     
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSetAppZ_Click(object sender, EventArgs e)
        {
            client.SetAppZ(Int32.Parse(textBoxSetAppZ.Text));
        }

        private void buttonGetAppZ_Click(object sender, EventArgs e)
        {
            textBoxGetAppZ.Text = client.GetAppZ().ToString();
        }

        private void buttonAddAppZ_Click(object sender, EventArgs e)
        {
            textBoxResultAppZ.Text = client.AddAppZ(Int32.Parse(textBoxAppZ.Text)).ToString();
        }
    }
}
