using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

namespace student_analysis
{
    public partial class uspevaemostModule : Form
    {
        public string search_query, row_val;
        public int stud_ID, sem_ID;

        public uspevaemostModule()
        {
            InitializeComponent();
            MinimumSize = new Size(info.minSize[0]+100, info.minSize[1]);
        }

        private void uspevaemostModule_Resize(object sender, EventArgs e)
        {            
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 75;
            }
            for (int i = 1; i < resultTable.Columns.Count; i++)
            {
                resultTable.Columns[i].Width = 75;
            }
            dataGridView1.Columns[3].Width = ClientSize.Width - 357;
            resultTable.Columns[0].Width = ClientSize.Width - 357;
        }

        private void uspevaemostModule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mainDataSet1.predmety". При необходимости она может быть перемещена или удалена.
            this.predmetyTableAdapter.Fill(this.mainDataSet1.predmety);
            this.studentsTableAdapter.Fill(this.mainDataSet1.students);
            this.uspevaemostTableAdapter.Fill(this.mainDataSet1.uspevaemost);
            // не забути потім видалити два рядка коду нижче
            /*searchTxtBox.Text = "бен";
            semestrTxtBox.Text = "9";*/

            uspevaemostModule_Resize(this, e);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.uspevaemostTableAdapter.Update(this.mainDataSet1.uspevaemost);
            this.uspevaemostTableAdapter.Fill(this.mainDataSet1.uspevaemost);
            if (tabControl1.SelectedIndex == 1)
                exportToExcelBtn.Enabled = searchTxtBox.Enabled  = semestrTxtBox.Enabled = true;
            else
                exportToExcelBtn.Enabled = searchBtn.Enabled = searchTxtBox.Enabled = semestrTxtBox.Enabled = false;
        }        

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {            
            semestrTxtBox_TextChanged(this, e);
        }

        private void semestrTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "" || semestrTxtBox.Text == "")
                searchBtn.Enabled = false;
            else
                searchBtn.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            /*Random rand = new Random();
            for (int i = 0; i < resultTable.Columns.Count; i++)
            {
                resultTable[i, 0].Value = rand.Next(0, 50);
            }*/
            string[] row1 = new string[] { "Беньковський Олексій Костянтинович", "9", "Основи програмної інженерії", "5", "4.57" };
            string[] row2 = new string[] { "", "9", "Проектний практикум", "4", "" };
            string[] row3 = new string[] { "", "9", "Людино-машинний інтерфейс", "4", "" };
            string[] row4 = new string[] { "", "9", "Математичні методи дослідження операцій", "5", "" };
            string[] row5 = new string[] { "", "9", "Адміністрування програмних систем і комплексів", "5", "" };
            string[] row6 = new string[] { "", "9", "Алгоритми та структури даних", "4", "" };
            string[] row7 = new string[] { "", "9", "Законодавство в ІТ-галузі", "5", "" };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6, row7 };
            foreach (string[] rowArray in rows)
            {
                resultTable.Rows.Add(rowArray);
            }
            toolStripButton2.Visible = false;
        }

        private void exportToExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application ExcelApp = new Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                ExcelApp.Columns.ColumnWidth = 25;

                for (int i = 0; i < resultTable.Columns.Count; i++)
                {
                    ExcelApp.Cells[1, i + 1] = resultTable.Columns[i].HeaderText;
                    //ExcelApp.Columns[1, i + 1].ColumnWidth = resultTable.Columns[i].Width;
                }

                for (int i = 0; i < resultTable.Columns.Count; i++)
                {
                    for (int j = 0; j < resultTable.Rows.Count - 1; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = (resultTable[i, j].Value).ToString();
                    }
                }
                ExcelApp.Visible = true;
            }
            catch
            {
                Form1.Error("На комп'ютері не встановлено пакет Microsoft Office версії 2007 або вище. Встановіть, будь ласка, пакет та перезапустіть програму.");
                exportToExcelBtn.Enabled = false;
            }
        }

        private void uspevaemostModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("taskkill", "/f /im excel.exe");
            }
            catch
            {

            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            // переключення вкладок через комбінацію клавіш Ctrl+Tab

            /*if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl1.SelectedIndex < tabControl1.TabCount)
                    tabControl1.SelectedIndex++;
                else
                    tabControl1.SelectedIndex = 0;
            }*/
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            tabControl1_KeyDown(this, e);
        }

        private void resultTable_KeyDown(object sender, KeyEventArgs e)
        {
            tabControl1_KeyDown(this, e);
        }

        private void semestrTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            search_query = searchTxtBox.Text.ToLower();
            sem_ID = Convert.ToInt32(semestrTxtBox.Text);
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++) // пошук студента за запитом в полі пошуку
            {
                row_val = dataGridView2[1, i].Value.ToString();
                try
                {
                    if (row_val.ToLower().Contains(search_query))
                    {
                        stud_ID = Convert.ToInt32(dataGridView2[0, i].Value);
                        resultTable[0, 0].Value = row_val;
                        resultTable[1, 0].Value = sem_ID;
                    }
                    else
                    {
                                                
                    }
                }
                catch
                {
                    Form1.Error("При здійсненні пошуку здійснилася помилка!");
                    searchTxtBox.Text = semestrTxtBox.Text = "";
                    searchTxtBox.Focus();
                }
            }
        }
    }
}
