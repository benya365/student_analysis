using System;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class Form1 : Form
    {
        //public static string datetime = DateTime.Now.ToString().Replace('.', '_').Replace(':', '_').Replace(' ', '_');
        public static string datetime = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");

        public Form1()
        {
            InitializeComponent();
        }

        public static void backup()
        {
            string dbPath = Application.StartupPath + @"\main.accdb", newPath = Application.StartupPath + @"\..\backup\" + datetime + ".main.accdb";
            File.Copy(dbPath, newPath, true);
        }

        public static void Error(string error_text)
        {
            MessageBox.Show(error_text, "Помилка!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (auth.login != "")
                modulesMenuItem.Enabled = true;
            else
                modulesMenuItem.Enabled = false;
            if (auth.login == "admin")
                dbBackupMenuItem.Enabled = userConfigMenuItem.Enabled = true;
            else
                dbBackupMenuItem.Enabled = userConfigMenuItem.Enabled = false;
            if (MdiChildren.Count() > 0)
                closeAllWindowsMenuItem.Enabled = true;
            else
                closeAllWindowsMenuItem.Enabled = false;

            statusLbl.Text = "Користувач: " + auth.login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusLbl.Text = "";
            Text = info.progname;                        
            try
            {
                backup();
            }
            catch
            {

            }
            connectMenuItem_Click(this, e);
        }

        private void формаЗворотногоЗвязкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback fbFrm = new feedback(feedbackMenuItem.Text);
            fbFrm.ShowDialog();
        }

        private void вийтиЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void connectMenuItem_Click(object sender, EventArgs e)
        {
            authForm authFrm = new authForm();
            authFrm.ShowDialog();
            connectMenuItem.Enabled = false;
            disconnectMenuItem.Enabled = true;
        }

        private void disconnectMenuItem_Click(object sender, EventArgs e)
        {
            auth.login = auth.pass = "";
            connectMenuItem.Enabled = true;
            disconnectMenuItem.Enabled = false;
        }

        private void userConfigMenuItem_Click(object sender, EventArgs e)
        {
            userConfig usrConf = new userConfig(userConfigMenuItem.Text);
            usrConf.MdiParent = this;
            usrConf.Show();
        }

        private void closeAllWindowsMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                do
                {
                    MdiChildren[0].Close();
                }
                while (MdiChildren.Count() > 0);
                closeAllWindowsMenuItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Вікна вже закриті!");
                closeAllWindowsMenuItem.Enabled = false;
            }
        }

        private void cascadeMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void studentsMenuItem_Click(object sender, EventArgs e)
        {
            studentsModule studMod = new studentsModule();
            studMod.MdiParent = this;
            studMod.Show();
        }

        private void groupsMenuItem_Click(object sender, EventArgs e)
        {
            groupsModule groupsMod = new groupsModule();
            groupsMod.MdiParent = this;
            groupsMod.Show();
        }

        private void predmetyMenuItem_Click(object sender, EventArgs e)
        {
            predmetyModule predMod = new predmetyModule();
            predMod.MdiParent = this;
            predMod.Show();
        }

        private void sessionsMenuItem_Click(object sender, EventArgs e)
        {
            uspevaemostModule uspMod = new student_analysis.uspevaemostModule();
            uspMod.MdiParent = this;
            uspMod.Show();
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            aboutForm abFrm = new aboutForm();
            abFrm.ShowDialog();
        }

        private void створенняРезервноїКопіїБазиДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                backup();
                MessageBox.Show("Резервна копія бази даних створена!", dbBackupMenuItem.Text);
            }
            catch
            {
                Error("Наразі неможливо створити резервну копію бази даних. Спробуйте пізніше.");
            }
        }
    }
}
