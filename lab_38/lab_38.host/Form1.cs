using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_38.host
{
    public partial class Form1 : Form
    {
        ServiceHost sh;
        public Form1()
        {
            InitializeComponent();

            this.sh = new ServiceHost(typeof(Service1));
            this.sh.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
