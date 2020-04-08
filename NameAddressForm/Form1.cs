using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameAddressForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkASP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listCity.GetItemText(listCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string city = listCity.Text;
            string gender = string.Empty;
            
            //Figure out which radio button is selected
            if (radioFemale.Checked == true)
            {
                gender = "Female Selected";
            }
            else if (radioMale.Checked == true)
            {
                gender = "Male Selected";
            }
            else
            {
                gender = "User did not choose a Gender! WTF?";
            }

            MessageBox.Show(name + "\n" + address + "\n" + city + "\n" + gender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
