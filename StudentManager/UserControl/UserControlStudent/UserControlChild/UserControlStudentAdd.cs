﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class UserControlStudentAdd : UserControl
    {
        public UserControlStudentAdd()
        {
            InitializeComponent();
        }

        private void cyberGroupBox1_Load(object sender, EventArgs e)
        {

        }

        private void nightPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlStudentAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnDeleteOfStudentAdd_Click(object sender, EventArgs e)
        {
            inputdiachi.Text = string.Empty;
            inputid.Text = string.Empty;
            inputname.Text = string.Empty;
            inputphone.Text = string.Empty;
            inputngaysinh.Text = string.Empty;
            inputlop.SelectedIndex = -1;


        }

        private void btnConfirmOfStudentAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
