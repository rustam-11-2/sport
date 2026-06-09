using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sport
{
    public partial class FormRegist : Form
    {
        string sectionName;
        public FormRegist(string Name)
        {
            InitializeComponent();
            sectionName = Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxFio != null && textBoxAge != null && textBoxPhone != null)
            {

            }
        }
    }
}
