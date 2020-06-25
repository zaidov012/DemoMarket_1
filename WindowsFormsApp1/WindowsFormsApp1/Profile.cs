using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void buttonAddBalance_Click(object sender, EventArgs e)
        {
            double balance = Convert.ToDouble(labelBalance.Text);

            balance += Convert.ToDouble(textBoxAddBalance.Text);

            labelBalance.Text = balance.ToString();

            textBoxAddBalance.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Buy b = new Buy();
            b.Show();
            this.Hide();
        }
    }
}
