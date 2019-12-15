﻿using System;
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
    public partial class ShowStaff : Form
    {
        public ShowStaff()
        {
            InitializeComponent();
        }

        private void ShowStaff_Load(object sender, EventArgs e)
        {
            outputStaffList.DataSource = DAO.listStaff().Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            outputStaffList.DataSource = DAO.listStaff(inputID.Text, inputName.Text, inputSurname.Text).Tables[0];
        }
    }
}