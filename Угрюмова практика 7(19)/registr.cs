using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угрюмова_практика_7_19_
{
    public partial class registr : Form
    {
        private string name1;
        private string group1;
        public registr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""|| comboBox1.Text == "")
            {
                MessageBox.Show("незаполнены поля", "ошибка");
            }
            else
            {
                name1 = Set(textBox1.Text);
                group1 = Set(comboBox1.Text);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public string Set(string name)
        {
            return name;
        }
        public string GetName()
        {
            return name1;
        }
        public string GetGroup()
        {
            return group1;
        }
        private void registr_Load(object sender, EventArgs e)
        {

        }
    }
}
