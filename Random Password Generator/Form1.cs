using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Random_Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            int length = 10;
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!?";
            var random = new Random();
            string password = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            labelPassword.Text = $"{password}";
            
        }
        private void labelPassword_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(labelPassword.Text);
            MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelPassword_MouseEnter_1(object sender, EventArgs e)
        {
            labelPassword.ForeColor = System.Drawing.Color.Blue;  // Change text color
            labelPassword.Font = new System.Drawing.Font(labelPassword.Font, System.Drawing.FontStyle.Underline);
        }

        private void labelPassword_MouseLeave(object sender, EventArgs e)
        {
            labelPassword.ForeColor = System.Drawing.Color.Black;  // Reset text color
            labelPassword.Font = new System.Drawing.Font(labelPassword.Font, System.Drawing.FontStyle.Regular); // Remove underline
        }
    }
}
