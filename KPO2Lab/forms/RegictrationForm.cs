using KPO2Lab.utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPO2Lab.forms
{
    public partial class RegictrationForm : Form
    {
        private readonly OrmUserService ormUser;
        public RegictrationForm(OrmUserService orm)
        {
            InitializeComponent();
            ormUser = orm;

        }



        private void okBtn_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            try
            {

                ormUser.RegisterUser(login, password);

                statusLabel.Text = "Succes";
            
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }


        }

    }
}
