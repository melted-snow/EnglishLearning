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
    public partial class TestForm : Form
    {
        int[] TestOrder;
        int Order = 0;

        public TestForm()
        {
            InitializeComponent();

            //TestOrder = WordData.GetIndexes();
            //int i = 0, j;
            //foreach (var key in Words.Keys)
            //{
            //    TestOrder[i] = key;
            //    i++;
            //}
            //Random rnd = new Random();
            //string temp;
            //for (i = TestOrder.Length - 1, j = rnd.Next(i + 1); i >= 1; i--, j = rnd.Next(i + 1))
            //{
            //    temp = TestOrder[i]; TestOrder[i] = TestOrder[j]; TestOrder[j] = temp;
            //}
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            //wordText.Text = TestOrder[Order];
            
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            //if (descriptionText.TextLength == 0)
            //{
            //    descriptionText.Text = Words[TestOrder[Order]];
            //}
            //else
            //{
            //    descriptionText.Clear();
            //}
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //if (Order >= TestOrder.Length - 1)
            //{
            //    return;
            //}
            //else
            //{
            //    Order++;
            //    descriptionText.Clear();
            //    wordText.Text = TestOrder[Order];
            //}
        }
    }
}
