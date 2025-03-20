using KPO2Lab.models;
using KPO2Lab.utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
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
        public RegisteredUserEntity user;


        public RegictrationForm(OrmUserService orm)
        {
            InitializeComponent();
            ormUser = orm;

        }


        public RegictrationForm(OrmUserService orm, RegisteredUserEntity user)
        {
            InitializeComponent();
            ormUser = orm;
            this.user = user;
            loginBox.Text = user.login.ToString();


        }


        private void okBtn_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passwordBox.Text;

            try
            {
                if (user == null)
                {
                    ormUser.RegisterUser(login, password);

                    statusLabel.Text = "Succes";

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if(VerifyData(login, password))
                    {
                        user.login = login;
                        user.password = PasswordHelper.GenerateHashPassword(password);
                        user.registration_date = user.registration_date.Value.ToUniversalTime();
                        ormUser.UpdateUser(user);
                    }
                   

                    statusLabel.Text = "Succes";

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }


        }

        private bool VerifyData(string login, string password)
        {

            return VerifyLogin(login) && VerifyPassword(password);
            
        }

        private bool VerifyLogin(string login)
        {
            if (user.login != login)
            {
                var users = ormUser.FindByName(login);
                if (users.Count != 0)
                {
                    return false;
                }
                
            }
            return true;
        }

        private bool VerifyPassword(string password)
        {
            return PasswordHelper.ValidatePasswordStrength(password);
        }

    }
}
