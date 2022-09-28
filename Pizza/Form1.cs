using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class form1 : Form
    {
        double slices;
        double sliceCost = 15;
        double subtotal;
        double amount;
        double tax = 0.13;
        double total;
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                slices = Convert.ToDouble(slicesInput.Text);

                subtotal = slices * sliceCost;
                amount = subtotal * tax;
                total = subtotal + amount;

                subtotalOutput.Text = $"{subtotal.ToString("C")}";
                amountOutput.Text = $"{amount.ToString("C")}";
                totalOutput.Text = $"{total.ToString("C")}";

            }
            catch
            {
                subtotalOutput.Text = "!INVALID!";
                amountOutput.Text = "!INVALID!";
                totalOutput.Text = "!INVALID!";





            }
        }
    }
}
