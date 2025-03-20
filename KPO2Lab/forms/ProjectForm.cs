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
    public partial class ProjectForm : Form, IEntityForm<ProjectEntity>
    {

        public int EntityId { get; }
        public ProjectEntity NewEntity { get; private set; }

        public ProjectForm(int taskId)
        {
            InitializeComponent();
            EntityId = taskId;

        }

        public ProjectForm(ProjectEntity currentEntity)

        {
            InitializeComponent();
            this.NewEntity = currentEntity;
            EntityId = 0;
            nameBox.Text = currentEntity.name;

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
           
            string name = nameBox.Text;
               

            // Проверяем, что имя и фамилия не пустые
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Название проекта не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если поля пустые
            }
            if (NewEntity == null) {
                NewEntity = new ProjectEntity
                {
                    name = name
                };
            }
            else
            {
                NewEntity.name = name;
            }
                // Создаем нового пользователя
                



                this.DialogResult = DialogResult.OK;
                this.Close();
            
        }
    }
}
