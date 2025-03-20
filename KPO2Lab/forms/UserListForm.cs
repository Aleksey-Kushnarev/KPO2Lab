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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KPO2Lab.forms
{
    public partial class UserListForm : Form
    {
        private readonly OrmUserService ormUser;
        public UserListForm(IServiceProvider provider)
        {
            InitializeComponent();
            ormUser = new OrmUserService(provider);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadUsers();
        }

        private void LoadUsers()
        {
            listView1.Items.Clear();
            var users = ormUser.GetUsers();

            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.id.ToString());
                item.SubItems.Add(user.login);
                item.SubItems.Add(user.is_active ? "Активен" : "Заблокирован");
                item.Tag = user;
                listView1.Items.Add(item);
            }
        }
    }

   
}
