using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationAutomation
{
    public partial class EditStaff : Form
    {
        bool check1, check2, check3 = false;
        public EditStaff()
        {
            InitializeComponent();
        }
        private void EditStaff_Load(object sender, EventArgs e)
        {
            outputStaffList.DataSource = DAO.listStaff().Tables[0];
        }
        //private static void UpdateGridView() => outputStaffList.DataSource = DAO.listStaff().Tables[0];

        private void outputStaffList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            inputID.Text = outputStaffList.CurrentRow.Cells[0].Value.ToString();
            inputName.Text = outputStaffList.CurrentRow.Cells[1].Value.ToString();
            inputSurname.Text = outputStaffList.CurrentRow.Cells[2].Value.ToString();
            textInputDepartment.Text = outputStaffList.CurrentRow.Cells[4].Value.ToString();
            textInputTask.Text = outputStaffList.CurrentRow.Cells[5].Value.ToString();
            textInputEducation.Text = outputStaffList.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Text = outputStaffList.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            if (inputID.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 karakter uzunluğunda olmak zorundadır.");
            }
            else
            {
                staff.setID(inputID.Text);
                staff.setName(inputName.Text);
                staff.setSurname(inputSurname.Text);
                staff.setTask(textInputTask.Text);
                staff.setDepartment(textInputDepartment.Text);
                staff.setEducationLevel(textInputEducation.Text);
                staff.setDate(dateTimePicker1.Value);
                DAO.addStaff(staff);
            }
            outputStaffList.DataSource = DAO.listStaff().Tables[0];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputID.Text = "";
            inputName.Text = "";
            inputSurname.Text = "";
            textInputDepartment.Text = "";
            textInputEducation.Text = "";
            textInputTask.Text = "";
            
        }
        //CheckBox işlemleri
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!check1)
            {
                comboBoxDepartment.Visible = false;
                textInputDepartment.Visible = true;
                check1 = true;
            }
            else
            {
                comboBoxDepartment.Visible = true;
                textInputDepartment.Visible = false;
                check1 = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!check2)
            {
                comboBoxTask.Visible = false;
                textInputTask.Visible = true;
                check2 = true;
            }
            else
            {

                comboBoxTask.Visible = true;
                textInputTask.Visible = false;
                check2 = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!check3)
            {
                comboBoxEducation.Visible = false;
                textInputEducation.Visible = true;
                check3 = true;
            }
            else
            {

                comboBoxEducation.Visible = true;
                textInputEducation.Visible = false;
                check3 = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.UtcNow;
        }
    }
}
