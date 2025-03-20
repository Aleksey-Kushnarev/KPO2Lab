using KPO2Lab.utils;
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
    public partial class LoginForm : Form
    {
        private readonly OrmUserService ormUser;


        public LoginForm(IServiceProvider provider)
        {
            InitializeComponent();
            ormUser = new OrmUserService(provider);

        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(Object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;
            try
            {
                ormUser.LoginUser(login, password);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                statusStripLabel.Text = ex.Message;
            }




        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegictrationForm regForm = new RegictrationForm(ormUser);
            regForm.ShowDialog();
            this.Show();
            
        }
    }
}
