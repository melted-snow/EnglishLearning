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
        public WordManagementForm()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            WordData.sql.CommandText = "SELECT * FROM MAIN";
            WordData.sql.ExecuteNonQuery();
            var reader = WordData.sql.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["WORD"].ToString(), reader["DESCRIPTION"].ToString());
            }
            reader.Dispose();
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
            var af = new AddForm(ref dataGridView1);
            af.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                if (r.Cells[0].Value.ToString().Contains(searchtb.Text) || r.Cells[1].Value.ToString().Contains(searchtb.Text))
                {
                    r.Visible = true;
                }
                else
                {
                    r.Visible = false;
                }
            }
        }
    }
}
