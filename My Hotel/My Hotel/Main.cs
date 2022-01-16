using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Hotel
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button_Guests_Click(object sender, EventArgs e)
        {
            new GuestsForm().ShowDialog();
        }

        private void button_Owners_Click(object sender, EventArgs e)
        {
            new OwnersForm().ShowDialog();
        }

        private void button_Apartments_Click(object sender, EventArgs e)
        {
            new ApartmentForm().ShowDialog();
        }
    }
}
