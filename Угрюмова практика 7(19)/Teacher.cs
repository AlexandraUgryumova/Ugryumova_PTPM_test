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
    public partial class Teacher : Form
    {
        registr form1 = new registr();
        public Teacher()
        {
            InitializeComponent();
            form1.ShowDialog();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
