using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishLearning
{
    public partial class AddForm : Form
    {
        DataGridView d;
        public AddForm(ref DataGridView d)
        {
            InitializeComponent();
            this.d = d;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            WordData.Add(WordText.Text, DescriptionText.Text);
            d.Rows.Add(WordText.Text, DescriptionText.Text);
            WordText.Clear();
            DescriptionText.Clear();
        }
    }
}
