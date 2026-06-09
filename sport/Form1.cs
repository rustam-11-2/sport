using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sport
{
    public partial class Form1 : Form
    {
        public List<SporstSection> sportSections;

        public Form1()
        {
            InitializeComponent();
            sportSections = new List<SporstSection>();
        }

        public void LoadSectionData()
        {
            sportSections.Add(new SporstSection("Вольная борьбаб", "Сослан Коцаев", 15));
            sportSections.Add(new SporstSection("Волейбол", "Константин Брянский", 24));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSectionData();
            dataGridViewSections.DataSource = sportSections;
        }

        private void dataGridViewSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
