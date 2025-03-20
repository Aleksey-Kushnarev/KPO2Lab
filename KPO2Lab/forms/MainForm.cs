using KPO2Lab.forms;
using KPO2Lab.models;
using KPO2Lab.utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO.Packaging;
using System.Windows.Forms;

namespace KPO2Lab
{
    public partial class MainForm : Form
    {
        private readonly Orm orm;
        IServiceProvider provider;

        public MainForm(IServiceProvider provider)
        {
            Authenticate(provider);
            this.provider = provider;
            orm = new Orm(provider);
            InitializeComponent();


            FillTreeView();


        }

        private void Authenticate(IServiceProvider provider)
        {
            LoginForm loginForm = new LoginForm(provider);

            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                this.Close();
                Application.Exit();

            }



        }

        private void FillTreeView()
        {

            TreeNode root = FillProjectsNode();
            treeView1.Nodes.Add(root);
        }

        private TreeNode FillProjectsNode()
        {
            var projects = orm.GetProjects();
            TreeNode rootProjectsNode = new TreeNode("Projects");
            rootProjectsNode.Tag = 0;
            foreach (var project in projects)
            {
                TreeNode projectNode = FillTaskNode(project);
                rootProjectsNode.Nodes.Add(projectNode);
            }
            return rootProjectsNode;
        }

        private TreeNode FillTaskNode(ProjectEntity project)
        {
            TreeNode rootTaskNode = new TreeNode(project.ToString());
            rootTaskNode.Tag = project.id;
            var tasks = orm.GetTasksInProject(project);
            foreach (var task in tasks)
            {
                TreeNode taskNode = FillUserNode(task);
                rootTaskNode.Nodes.Add(taskNode);
            }
            return rootTaskNode;
        }

        private TreeNode FillUserNode(TaskEntity task)
        {
            TreeNode rootUserNode = new TreeNode(task.ToString());
            rootUserNode.Tag = task.id;
            var users = orm.GetUserInTask(task);
            foreach (var user in users)
            {

                TreeNode currentUser = new TreeNode(user.ToString());
                currentUser.Tag = user.id;
                rootUserNode.Nodes.Add(currentUser);
            }
            return rootUserNode;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Проверяем, была ли нажата ПКМ
            {
                treeView1.SelectedNode = e.Node; // Выделяем узел
                ContextMenuStrip[] contextMenuStrips = new ContextMenuStrip[]
                { contextMenuAllProjects,  contextMenuStripProject,
                    contextMenuStripTask, contextMenuStripUser}

                ;

                contextMenuStrips[e.Node.Level].Show(treeView1, e.Location);

            }
        }

        private void contextMenuStripProject_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void SendStatusMessage(string message)
        {
            statusBar.Text = message;
        }

        private void SendSuccesStatusMessage()
        {
            SendStatusMessage("Success");
        }

        private void SendErrorStatusMessage(string error)
        {
            SendStatusMessage($"Error! {error}");
        }

        private void deleteUserToolStrip_Click(object sender, EventArgs e)
        {
            DeleteNode<UserEntity>();
        }

        private void deleteProject_Click(object sender, EventArgs e)
        {
            DeleteNode<ProjectEntity>();
        }
        private void deleteTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteNode<TaskEntity>();
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

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNode<UserEntity, UserForm>();

        }

        private void addTaskToolStrip_Click(object sender, EventArgs e)
        {
            AddNode<TaskEntity, TaskForm>();
        }

        private void addProjectToolStrip_Click(object sender, EventArgs e)
        {
            AddNode<ProjectEntity, ProjectForm>();
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is TreeNode draggedNode)
            {
                DoDragDrop(draggedNode, DragDropEffects.Move);
            }
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(TreeNode)) is TreeNode)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(TreeNode)) is not TreeNode draggedNode) return;

            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = treeView1.GetNodeAt(targetPoint);

            if (targetNode == null || draggedNode == targetNode) return;

            if (IsValidDrop(draggedNode, targetNode))
            {
                draggedNode.Remove();
                targetNode.Nodes.Add(draggedNode);
                targetNode.Expand();
                ChangeNode(draggedNode, targetNode);


            }
        }

        private bool IsValidDrop(TreeNode draggedNode, TreeNode targetNode)
        {
            // Пользователь (UserEntity) можно перетащить только на задачу (TaskEntity)
            if (draggedNode.Level == 3 && targetNode.Level == 2)

                return true;

            // Задачу (TaskEntity) можно перетащить только на проект (ProjectEntity)
            if (draggedNode.Level == 2 && targetNode.Level == 1)
                return true;

            return false;
        }

        private void ChangeNode(TreeNode draggedNode, TreeNode targetNode)
        {
            if (draggedNode.Level == 3 && targetNode.Level == 2) // User -> Task
            {
                orm.ChangeParent<UserEntity>((int)draggedNode.Tag, (int)targetNode.Tag);
            }
            else if (draggedNode.Level == 2 && targetNode.Level == 1) // Task -> Project
            {
                orm.ChangeParent<TaskEntity>((int)draggedNode.Tag, (int)targetNode.Tag);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNode<ProjectEntity, ProjectForm>();
        }

        private void editTask_Click(object sender, EventArgs e)
        {
            EditNode<TaskEntity, TaskForm>();
        }

        private void editUser_Click(object sender, EventArgs e)
        {
            EditNode<UserEntity, UserForm>();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mainStrip.Show(this, e.Location);
            }
        }

        private void userListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var form = new UserListForm(provider)) // Используем сохранённый provider
            {
                form.ShowDialog();
            }
        }

        private void EditNode<TypeEntity, TypeForm>()
                    where TypeEntity : class, IEntity
                    where TypeForm : Form, IEntityForm<TypeEntity>
        {
            TreeNode currentNode = treeView1.SelectedNode;
            if (currentNode != null && int.TryParse(currentNode.Tag.ToString(),
                out int entityId))
            {
                TypeEntity? entity = orm.FindEntityById<TypeEntity>(entityId);
                if (entity != null)
                {
                    using TypeForm form = (TypeForm)Activator.CreateInstance(typeof(TypeForm), entity)!;
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.OK)
                    {
                        orm.UpdateEntity(form.NewEntity);
                        treeView1.SelectedNode.Text = form.NewEntity.ToString(); // Обновляем отображение
                    }

                }
            }
        }

        private void AddNode<TypeEntity, TypeForm>()
            where TypeEntity : class, IEntity
            where TypeForm : Form, IEntityForm<TypeEntity>
        {

            TreeNode currentNode = treeView1.SelectedNode;
            if (currentNode != null && int.TryParse(currentNode.Tag.ToString(),
                out int entityId))
            {
                using TypeForm form = (TypeForm)Activator.CreateInstance(
                    typeof(TypeForm), entityId)!;

                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    if (orm.AddEntity(form.NewEntity))
                    {
                        SendSuccesStatusMessage();
                        TreeNode newNode = new TreeNode(form.NewEntity.ToString());
                        newNode.Tag = form.NewEntity.id;
                        currentNode.Nodes.Add(newNode);

                    }
                    else { SendErrorStatusMessage($"{form.NewEntity.name} already exists"); }
                }

            }

        }




        private void DeleteNode<T>() where T : class
        {
            TreeNode currentNode = treeView1.SelectedNode;
            if (currentNode != null && int.TryParse(currentNode.Tag.ToString(), out int entityId))
            {

                if (ConfirmDelete())
                {
                    if (orm.DeleteEntity<T>(entityId))
                    {
                        SendSuccesStatusMessage();
                        currentNode.Parent.Nodes.Remove(currentNode);
                    }
                    else
                    {
                        SendErrorStatusMessage($"{entityId} is not exists");
                    }
                }
            }
        }
    }
}
