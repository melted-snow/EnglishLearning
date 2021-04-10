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
    public partial class WordManagementForm : Form
    {
        bool _ReaderExecuted = false;
        SqliteDataReader reader;

        public WordManagementForm()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            /*
             * foreach(var r in dataGridView1.SelectedRows)
             */
            foreach(DataGridViewRow r in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(r);
                WordData.Remove(r.Cells[0].ToString(), r.Cells[1].ToString());
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            /*
             * 編集用フォーム
             */
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            /*
             * 追加用フォーム
             */
            var af = new AddForm();
            af.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            /*
             * dataGridView1のrowを絞り込む
             */
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells[0].ToString().Contains(textBox1.Text) || r.Cells[1].ToString().Contains(textBox1.Text))
                {
                    r.Visible = false;
                }
                else
                {
                    r.Visible = true;
                }
            }
        }

        /*
         * 何回も押すと、その分同じものが追加されてしまう
         * 差分だけ追加または削除する必要がある
         */
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (_ReaderExecuted) reader.Dispose();
            WordData.sql.CommandText = $"SELECT * FROM MAIN";
            WordData.sql.ExecuteNonQuery();
            reader = WordData.sql.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader[1], reader[2]);
            }
            reader.Dispose();
        }
    }
}
