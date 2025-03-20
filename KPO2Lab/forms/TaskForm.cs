using KPO2Lab.models;
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
    public partial class TaskForm : Form, IEntityForm<TaskEntity>
    {

        public int EntityId { get; }
        public TaskEntity NewEntity { get; private set; }

        public TaskForm(int projectId)
        {
            InitializeComponent();
            EntityId = projectId;

        }

        public TaskForm(TaskEntity currentEntity)

        {
            InitializeComponent();
            this.NewEntity = currentEntity;

            EntityId = currentEntity.project;
            nameBox.Text = currentEntity.name;

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
           

            string name = nameBox.Text;


            // Проверяем, что имя и фамилия не пустые
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название задачи не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля пустые
            }
            if(NewEntity == null)
            {
                // Создаем нового пользователя
                NewEntity = new TaskEntity
                {
                    name = name,
                    project = EntityId
                };
            }
            else
            {
                NewEntity.name = name;
            }
                



                this.DialogResult = DialogResult.OK;
                this.Close();

            
        }
    }
}
