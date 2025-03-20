using KPO2Lab.models;
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
using System.Xml.Linq;

namespace KPO2Lab.forms
{
    public partial class UserForm : Form, IEntityForm<UserEntity>
    {

        public UserEntity NewEntity { get; private set; }
        public int EntityId { get; }


        public UserForm(int taskId)
        {
            InitializeComponent();
            EntityId = taskId;

        }

        public UserForm(UserEntity currentUser)

        {
            InitializeComponent();
            this.NewEntity = currentUser;
            EntityId = currentUser.task;
            nameBox.Text = currentUser.name;
            surnameBox.Text = currentUser.surname;

        }



        private void okBtn_Click(object sender, EventArgs e)
        {
            // Считываем данные с формы
            string name = nameBox.Text;
            string surname = surnameBox.Text;

            // Проверяем, что имя и фамилия не пустые
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Имя и фамилия не могут быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля пустые
            }
            if(NewEntity == null)
            {
                // Создаем нового пользователя
                NewEntity = new UserEntity
                {
                    name = name,
                    surname = surname,
                    task = EntityId
                };
            }
            else
            {
                NewEntity.name = name;
                NewEntity.surname = surname;
            }
            

            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    }

