﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAS5206_GRP1_MVCH
{
    public partial class frmLogin : Form
    {
      

        public frmLogin()
        {

            InitializeComponent();
          
        }
      
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMainScreen mainScreen = new frmMainScreen();
            mainScreen.ShowDialog();
            
       

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
