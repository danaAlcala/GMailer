using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMailTest
{
    public partial class Form1 : Form
    {
        public static string user;
        public static string sender;
        public static string password;
        public static string recipient;
        public static string subject;
        public static string body;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Commands.Send();
        }

        private void txtRecipient_TextChanged(object sender, EventArgs e)
        {
            recipient = txtRecipient.Text;
            lblTo.Text = "To: " + recipient;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            user = txtUser.Text;
            sender = user + "@gmail.com";
            lblFrom.Text = "From: " + sender;

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            password = txtPass.Text;
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            subject = txtSubject.Text;
        }

        private void rtxtBody_TextChanged(object sender, EventArgs e)
        {
            body = rtxtBody.Text;
        }

        
    }
}
