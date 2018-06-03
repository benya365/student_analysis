namespace student_analysis
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.користувачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showindowsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeAllWindowsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbBackupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.користувачToolStripMenuItem,
            this.modulesMenuItem,
            this.viewMenuItem,
            this.adminMenuItem,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // користувачToolStripMenuItem
            // 
            this.користувачToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenuItem,
            this.disconnectMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.користувачToolStripMenuItem.Name = "користувачToolStripMenuItem";
            this.користувачToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.користувачToolStripMenuItem.Text = "Користувач";
            // 
            // connectMenuItem
            // 
            this.connectMenuItem.Enabled = false;
            this.connectMenuItem.Name = "connectMenuItem";
            this.connectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.connectMenuItem.Size = new System.Drawing.Size(210, 22);
            this.connectMenuItem.Text = "Підключитися";
            this.connectMenuItem.Click += new System.EventHandler(this.connectMenuItem_Click);
            // 
            // disconnectMenuItem
            // 
            this.disconnectMenuItem.Name = "disconnectMenuItem";
            this.disconnectMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.disconnectMenuItem.Size = new System.Drawing.Size(210, 22);
            this.disconnectMenuItem.Text = "Відключитися";
            this.disconnectMenuItem.Click += new System.EventHandler(this.disconnectMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitMenuItem.Size = new System.Drawing.Size(210, 22);
            this.exitMenuItem.Text = "Вийти з програми";
            this.exitMenuItem.Click += new System.EventHandler(this.вийтиЗПрограмиToolStripMenuItem_Click);
            // 
            // modulesMenuItem
            // 
            this.modulesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsMenuItem,
            this.groupsMenuItem,
            this.predmetyMenuItem,
            this.sessionsMenuItem});
            this.modulesMenuItem.Enabled = false;
            this.modulesMenuItem.Name = "modulesMenuItem";
            this.modulesMenuItem.Size = new System.Drawing.Size(59, 20);
            this.modulesMenuItem.Text = "Модулі";
            // 
            // studentsMenuItem
            // 
            this.studentsMenuItem.Name = "studentsMenuItem";
            this.studentsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D1)));
            this.studentsMenuItem.Size = new System.Drawing.Size(203, 22);
            this.studentsMenuItem.Text = "Студенти";
            this.studentsMenuItem.Click += new System.EventHandler(this.studentsMenuItem_Click);
            // 
            // groupsMenuItem
            // 
            this.groupsMenuItem.Name = "groupsMenuItem";
            this.groupsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D2)));
            this.groupsMenuItem.Size = new System.Drawing.Size(203, 22);
            this.groupsMenuItem.Text = "Групи";
            this.groupsMenuItem.Click += new System.EventHandler(this.groupsMenuItem_Click);
            // 
            // predmetyMenuItem
            // 
            this.predmetyMenuItem.Name = "predmetyMenuItem";
            this.predmetyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D3)));
            this.predmetyMenuItem.Size = new System.Drawing.Size(203, 22);
            this.predmetyMenuItem.Text = "Дисципліни";
            this.predmetyMenuItem.Click += new System.EventHandler(this.predmetyMenuItem_Click);
            // 
            // sessionsMenuItem
            // 
            this.sessionsMenuItem.Name = "sessionsMenuItem";
            this.sessionsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D4)));
            this.sessionsMenuItem.Size = new System.Drawing.Size(203, 22);
            this.sessionsMenuItem.Text = "Успішність";
            this.sessionsMenuItem.Click += new System.EventHandler(this.sessionsMenuItem_Click);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showindowsMenuItem,
            this.toolStripSeparator2,
            this.closeAllWindowsMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(57, 20);
            this.viewMenuItem.Text = "Вигляд";
            // 
            // showindowsMenuItem
            // 
            this.showindowsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeMenuItem,
            this.horizontalMenuItem,
            this.verticalMenuItem});
            this.showindowsMenuItem.Name = "showindowsMenuItem";
            this.showindowsMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showindowsMenuItem.Text = "Відобразити вікна";
            // 
            // cascadeMenuItem
            // 
            this.cascadeMenuItem.Name = "cascadeMenuItem";
            this.cascadeMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cascadeMenuItem.Text = "Каскадом";
            this.cascadeMenuItem.Click += new System.EventHandler(this.cascadeMenuItem_Click);
            // 
            // horizontalMenuItem
            // 
            this.horizontalMenuItem.Name = "horizontalMenuItem";
            this.horizontalMenuItem.Size = new System.Drawing.Size(127, 22);
            this.horizontalMenuItem.Text = "Стопкою";
            this.horizontalMenuItem.Click += new System.EventHandler(this.horizontalMenuItem_Click);
            // 
            // verticalMenuItem
            // 
            this.verticalMenuItem.Name = "verticalMenuItem";
            this.verticalMenuItem.Size = new System.Drawing.Size(127, 22);
            this.verticalMenuItem.Text = "Поруч";
            this.verticalMenuItem.Click += new System.EventHandler(this.verticalMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(242, 6);
            // 
            // closeAllWindowsMenuItem
            // 
            this.closeAllWindowsMenuItem.Name = "closeAllWindowsMenuItem";
            this.closeAllWindowsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.closeAllWindowsMenuItem.Size = new System.Drawing.Size(245, 22);
            this.closeAllWindowsMenuItem.Text = "Закрити всі вікна";
            this.closeAllWindowsMenuItem.Click += new System.EventHandler(this.closeAllWindowsMenuItem_Click);
            // 
            // adminMenuItem
            // 
            this.adminMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userConfigMenuItem,
            this.dbBackupMenuItem});
            this.adminMenuItem.Name = "adminMenuItem";
            this.adminMenuItem.Size = new System.Drawing.Size(111, 20);
            this.adminMenuItem.Text = "Адміністрування";
            // 
            // userConfigMenuItem
            // 
            this.userConfigMenuItem.Name = "userConfigMenuItem";
            this.userConfigMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.userConfigMenuItem.Size = new System.Drawing.Size(281, 22);
            this.userConfigMenuItem.Text = "Керування користувачами";
            this.userConfigMenuItem.Click += new System.EventHandler(this.userConfigMenuItem_Click);
            // 
            // dbBackupMenuItem
            // 
            this.dbBackupMenuItem.Name = "dbBackupMenuItem";
            this.dbBackupMenuItem.Size = new System.Drawing.Size(281, 22);
            this.dbBackupMenuItem.Text = "Створення резервної копії бази даних";
            this.dbBackupMenuItem.Click += new System.EventHandler(this.створенняРезервноїКопіїБазиДанихToolStripMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedbackMenuItem,
            this.toolStripSeparator3,
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(75, 20);
            this.helpMenuItem.Text = "Допомога";
            // 
            // feedbackMenuItem
            // 
            this.feedbackMenuItem.Name = "feedbackMenuItem";
            this.feedbackMenuItem.Size = new System.Drawing.Size(218, 22);
            this.feedbackMenuItem.Text = "Форма зворотного зв\'язку";
            this.feedbackMenuItem.Click += new System.EventHandler(this.формаЗворотногоЗвязкуToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(215, 6);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(218, 22);
            this.aboutMenuItem.Text = "Про програму";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(118, 17);
            this.statusLbl.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 442);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(512, 384);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem користувачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem modulesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showindowsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeAllWindowsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userConfigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dbBackupMenuItem;
    }
}

