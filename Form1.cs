using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                MessageBox.Show("Success");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usertext.Text = "";
            txtpass.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Usertext_TextChanged(object sender, EventArgs e)
        {
           
        }
        private bool isValid()
        {
            string passwordpattern="(?=.*/d)(?=.*[a-z])(?=.*[A-Z]).{8,}";
            string namepattern = @"^[a-zA-Z]+$";
            if (Usertext.Text==String.Empty)
            {
                
                Usertext.BackColor = Color.LightPink;
                Usertext.Focus();
                MessageBox.Show("Validation Error", "Error");
                return false;
            }

            else if (Regex.IsMatch(Usertext.Text, namepattern) == false){
                Usertext.BackColor = Color.LightPink;
                Usertext.Focus();
                MessageBox.Show("Should be in Characters only", "Error");
                return false;
            }
            if (txtpass.Text == String.Empty)
            {

                txtpass.BackColor = Color.LightBlue;
                txtpass.Focus();
                MessageBox.Show("Validation Error", "Error");
                return false;
            }

            else if (Regex.IsMatch(txtpass.Text,passwordpattern) == false)
            {
                txtpass.BackColor = Color.LightPink;
                txtpass.Focus();
                MessageBox.Show("PLease enter password", "Error");
                return false;
            }
            
            return true;
        }
    }
}
