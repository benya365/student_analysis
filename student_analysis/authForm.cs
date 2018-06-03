using System;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();
        }

        private void loginTxtBox_TextChanged(object sender, EventArgs e)
        {
            passTxtBox_TextChanged(this, e);
        }

        private void passTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (loginTxtBox.Text == "" || passTxtBox.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginTxtBox.Text.ToLower();
            string pass = passTxtBox.Text;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    if (dataGridView1[1, i].Value.ToString() == login)
                    {
                        if (dataGridView1[2, i].Value.ToString() == pass)
                        {
                            auth.login = login;
                            auth.pass = pass;
                            i = dataGridView1.Rows.Count;
                            this.Hide();
                        }
                        else
                        {
                            Form1.Error("Ви ввели неправильний пароль!");
                            passTxtBox.SelectAll();
                            passTxtBox.Focus();
                            break;
                        }
                    }
                }
                catch
                {
                    Form1.Error("В базі немає такого користувача!");
                    passTxtBox.Clear();
                    loginTxtBox.SelectAll();
                    loginTxtBox.Focus();
                }
            }
        }

        private void authForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter1.Fill(this.mainDataSet1.users);
        }

        private void authForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginTxtBox.Clear();
            passTxtBox.Clear();
            loginTxtBox.Focus();
        }

        private void loginTxtBox_Enter(object sender, EventArgs e)
        {
            loginTxtBox.SelectAll();
        }

        private void passTxtBox_Enter(object sender, EventArgs e)
        {
            passTxtBox.SelectAll();
        }

        private void passTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(this, e);
        }

        private void authForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
