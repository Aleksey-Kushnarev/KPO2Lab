using KPO2Lab.models;
using KPO2Lab.utils;
using Microsoft.VisualBasic.ApplicationServices;
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
            CreateColumns();
            LoadUsers();
        }

        private void LoadUsers()
        {
            listView1.Items.Clear();
            var users = ormUser.GetUsers();

            foreach (var user in users)
            {
                AddItem(user);
            }
        }

        private void CreateColumns()
        {
            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("ID", 50);
                listView1.Columns.Add("Логин", 150);
                listView1.Columns.Add("Дата регистрации", 120);
                listView1.Columns.Add("Статус", 100);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Проверяем, что нажата правая кнопка мыши
            {
                ListViewItem clickedItem = listView1.GetItemAt(e.X, e.Y);

                if (clickedItem != null)
                {
                    // Если кликнули по элементу, показываем контекстное меню для элемента
                    listView1.SelectedItems.Clear(); // Очищаем предыдущее выделение
                    clickedItem.Selected = true;     // Выделяем кликнутый элемент
                    itemContext.Show(listView1, e.Location);
                }
                else
                {
                    // Если кликнули на пустом месте, показываем общее меню
                    listContext.Show(listView1, e.Location);
                }
            }
        }

        private void listContext_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegictrationForm regForm = new RegictrationForm(ormUser);
            DialogResult result = regForm.ShowDialog();
            if (result == DialogResult.OK)
            {

                AddUserToList();
            }
        }

        private void AddUserToList()
        {
            RegisteredUserEntity? user = ormUser.GetLastUser();
            if (user != null)
            {
                AddItem(user);
            }
        }

        private void AddItem(RegisteredUserEntity user)
        {
            ListViewItem item = new ListViewItem(user.id.ToString());
            item.SubItems.Add(user.login);
            item.SubItems.Add(user.registration_date.ToString());
            item.SubItems.Add(user.is_active ? "Активен" : "Заблокирован");
            item.Tag = user;
            listView1.Items.Add(item);
        }

        private void deleteUserTool_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];

            if (item != null && ConfirmDelete())
            {
                DeleteUserFromList(item);
            }
        }

        private bool ConfirmDelete()
        {

            DialogResult result = MessageBox.Show(
               "Вы уверены?",
               "Подтвердите удаление",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        private void DeleteUserFromList(ListViewItem item)
        {
            if (int.TryParse(item.Text, out int userId))
            {
                listView1.Items.Remove(item);

                ormUser.DeleteUser((RegisteredUserEntity?)item.Tag);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            if (item != null)
            {
                EditUserFromList(item);
            }
        }
        private void EditUserFromList(ListViewItem item)
        {
            var user = (RegisteredUserEntity?)item.Tag;
            if (user != null)
            {
                RegictrationForm regForm = new RegictrationForm(ormUser, user);
                var res = regForm.ShowDialog();
                if (res == DialogResult.OK)
                {
                    user = regForm.user;
                    item.SubItems[1].Text = user.login;
                    item.SubItems[2].Text = user.registration_date.ToString();
                    item.SubItems[3].Text = user.is_active ? "Активен" : "Заблокирован";
                    item.Tag = user;
                }
            }
        }

    }


}
