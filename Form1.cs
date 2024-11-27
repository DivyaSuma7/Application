using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int NumberUpperCase(string str)
        {
            int upperCase = 0;
            foreach(char c in str)
            {
                upperCase++;
            }
            return upperCase;
        }
        private int NumberLowerCase(string str)
        {
            int lowerCase = 0;
            foreach(char c in str)
            {
                lowerCase++;
            }
            return lowerCase;
        }
        private int NumberDigits(string str)
        {
            int digits = 0;
            foreach(char c in str)
            {
                digits++;
            }
            return digits;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;
            string password = passwordTextBox.Text;
            if(password.Length > MIN_LENGTH && NumberUpperCase(password) >=1 && NumberLowerCase(password)>=1 && NumberDigits(password)>=1)
            {
                MessageBox.Show("Passwprd is valid");
            }
            else
            {
                MessageBox.Show("Password is not valid");
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = string.Empty;
        }
    }
}
