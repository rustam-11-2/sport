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

        public void CreateField()
        {
            for (int i = 0; i < 3; i++)
            {
                var columns = new DataGridViewTextBoxColumn();
                dataGridViewSections.Columns.Add(columns);
            }
            dataGridViewSections.RowCount = sportSections.Count;
        }

        public void ShowField()
        {
            for(int i = 0; i < sportSections.Count; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSectionData();
            CreateField();

        }


        private void dataGridViewSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                FormRegist formReg = new FormRegist(sportSections[0].SectionName);
                this.Hide();
                formReg.Show();
                
            }
        }
    }
}