using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Form1 : Form

      {

        string username = "ladiesman217"; //transformers reference haha
        string password = "password123";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;

            if(enteredUsername == username && enteredPassword == password)
            {
                MessageBox.Show("Welcome Back ladiesman217");
            }
            else if(enteredUsername == username && enteredPassword != password)
            {
                MessageBox.Show("The password is incorrect!");
            }
            else if(enteredUsername != username && enteredPassword == password)
            {
                MessageBox.Show("The username is incorrect");
            }
            else
            {
                MessageBox.Show("STOP TRYING TO BREAK IN!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are getting cookies!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You are getting burgers!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
