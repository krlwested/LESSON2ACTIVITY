using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace LESSON2ACTIVITY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            cmbPrograms.Items.Add("Aeronautical Engineering");
            cmbPrograms.Items.Add("Civil Engineering");
            cmbPrograms.Items.Add("Computer Engineering");
            cmbPrograms.Items.Add("Electronics Engineering");
            cmbPrograms.Items.Add("Electrical Engineering");
            cmbPrograms.Items.Add("Industrial Engineering");
            cmbPrograms.Items.Add("Mechanical Engineering");
            
            cmbPrograms.SelectedIndex = -1;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Images |*.jpg;*.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(f.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLvl.Clear();
            txtNum.Clear();
            txtScholar.Clear();


            cmbPrograms.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
               txtCode.Text,
               txtDesc.Text,
               txtLec.Text,
               txtLab.Text,
               txtUnits.Text,
               txtTime.Text,
               txtDay.Text
               
            );

            txtCode.Clear();
            txtDesc.Clear();
            txtLec.Clear();
            txtLab.Clear();
            txtUnits.Clear();
            txtTime.Clear();
            txtDay.Clear();


        }
    }
}
