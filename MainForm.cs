using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishLearning
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            WordData.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\default.db";
            WordData.Connect();
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            var op = new OpenFileDialog();
            op.FileName = WordData.FileName;
            if (op.ShowDialog() == DialogResult.OK)
            var ofd = new OpenFileDialog();
            ofd.FileName = WordData.FileName;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                WordData.FileName = op.FileName;
                WordData.FileName = ofd.FileName;
                WordData.Connect();
            }
        }

        private void WordListButton_Click(object sender, EventArgs e)
        {
            var wlForm = new WordManagementForm();
            wlForm.Show();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var tForm = new TestForm();
            tForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            WordData.Dispose();
        }
    }
}
