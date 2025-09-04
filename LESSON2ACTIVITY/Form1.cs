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
            
            txtCode.Clear();
            txtDesc.Clear();
            txtbox_unitlec.Clear();
            txtbox_unitlab.Clear();
            txtbox_creditunits.Clear();
            txtTime.Clear();
            txtDay.Clear();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbox_totalnumberofunits.Enabled = false;
            txtbox_totaltuitionfee.Enabled = false;
            txtbox_creditunits.Enabled = false;
            txtbox_totalmiscellaneousfee.Enabled = false;
            txtbox_totaltuitionandotherfees.Enabled = false;
        }

        private void txtbox_creditunits_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Calculateradiobtn_Click(object sender, EventArgs e)
        {
            int credit_units, unit_lec, unit_lab;
            double tuitionperunit = 1700.00, total_tuitionfee, total_miscellaneousfee, total_tuitionandotherfees, ciscolab, exambooklet, computerlabfee;
            credit_units = Convert.ToInt32(txtbox_creditunits.Text);
            unit_lec = Convert.ToInt32(txtbox_unitlec.Text);
            unit_lab = Convert.ToInt32(txtbox_unitlab.Text);

            ciscolab = Convert.ToDouble(txtbox_ciscolab.Text);
            exambooklet = Convert.ToDouble(txtbox_booklet.Text);
            computerlabfee = Convert.ToDouble(txtbox_computerlabfee.Text);
            

            credit_units = unit_lab + unit_lec;
            

            total_numberofunits = credit_units + unit_lab;
            total_miscellaneousfee = ciscolab + exambooklet + computerlabfee;
            total_tuitionandotherfees = total_numberofunits + total_miscellaneousfee;

            txtbox_creditunits.Text = credit_units.ToString();
            txtbox_totalnumberofunits.Text = total_numberofunits.ToString();
            txtbox_unitlab.Text = unit_lab.ToString();
            txtbox_totalmiscellaneousfee.Text = total_miscellaneousfee.ToString();
            txtbox_computerlabfee.Text = computerlabfee.ToString();
            txtbox_booklet.Text = exambooklet.ToString();
            txtbox_ciscolab.Text = ciscolab.ToString();
            txtTime.Text = Time.ToString();

            total_miscellaneousfee = Convert.ToDouble(txtbox_totalmiscellaneousfee.Text);
            total_tuitionandotherfees = Convert.ToDouble(txtbox_totaltuitionandotherfees.Text);
            total_tuitionfee = (unit_lab + unit_lec * tuitionperunit);
            total_miscellaneousfee = (ciscolab + exambooklet + computerlabfee);
            total_tuitionandotherfees = total_tuitionfee + total_miscellaneousfee;

        }
    }
}
