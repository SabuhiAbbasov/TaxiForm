using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksi
{
    public partial class Taksi : Form
    {
        public Taksi()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaxiList.Items.Add(Nomre.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClentList.Items.Add(nameSurname.Text);  
        }
    }
}
