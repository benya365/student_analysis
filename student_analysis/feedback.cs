using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class feedback : Form
    {
        public feedback(string form_text)
        {
            InitializeComponent();
            Text = form_text;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string author, body;
            author = textBox1.Text;

            var fromAddress = new MailAddress("studanalysis.feedback@gmail.com", author);
            var toAddress = new MailAddress("alexben333@gmail.com", "To Developer");
            const string fromPassword = "alex_benya0964383078";

            body = richTextBox1.Text;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 10000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = "User with nickname \"" + auth.login + "\" sent a message",
                Body = body
            })
            {
                smtp.Send(message);
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1_TextChanged(this, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || richTextBox1.Text == "")
                sendBtn.Enabled = false;
            else
                sendBtn.Enabled = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
