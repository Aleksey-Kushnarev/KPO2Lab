namespace KPO2Lab
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            treeView1 = new TreeView();
            statusBar = new Label();
            contextMenuStripProject = new ContextMenuStrip(components);
            addTaskToolStrip = new ToolStripMenuItem();
            editProject = new ToolStripMenuItem();
            deleteProject = new ToolStripMenuItem();
            contextMenuStripTask = new ContextMenuStrip(components);
            addUserToolStripMenuItem = new ToolStripMenuItem();
            editTask = new ToolStripMenuItem();
            deleteTaskToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripUser = new ContextMenuStrip(components);
            editUser = new ToolStripMenuItem();
            deleteUserToolStrip = new ToolStripMenuItem();
            contextMenuAllProjects = new ContextMenuStrip(components);
            addProjectToolStrip = new ToolStripMenuItem();
            refreshToolStripMenuItem1 = new ToolStripMenuItem();
            mainStrip = new ContextMenuStrip(components);
            userListToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStripProject.SuspendLayout();
            contextMenuStripTask.SuspendLayout();
            contextMenuStripUser.SuspendLayout();
            contextMenuAllProjects.SuspendLayout();
            mainStrip.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.AllowDrop = true;
            treeView1.Font = new Font("Segoe UI", 12F);
            treeView1.Location = new Point(22, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(766, 344);
            treeView1.TabIndex = 0;
            treeView1.ItemDrag += treeView1_ItemDrag;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            treeView1.DragDrop += treeView1_DragDrop;
            treeView1.DragEnter += treeView1_DragEnter;
            // 
            // statusBar
            // 
            statusBar.AutoSize = true;
            statusBar.Location = new Point(568, 387);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(0, 15);
            statusBar.TabIndex = 1;
            // 
            // contextMenuStripProject
            // 
            contextMenuStripProject.Items.AddRange(new ToolStripItem[] { addTaskToolStrip, editProject, deleteProject });
            contextMenuStripProject.Name = "contextMenuStripProject";
            contextMenuStripProject.Size = new Size(132, 70);
            contextMenuStripProject.Opening += contextMenuStripProject_Opening;
            // 
            // addTaskToolStrip
            // 
            addTaskToolStrip.Name = "addTaskToolStrip";
            addTaskToolStrip.Size = new Size(131, 22);
            addTaskToolStrip.Text = "Add Task...";
            addTaskToolStrip.Click += addTaskToolStrip_Click;
            // 
            // editProject
            // 
            editProject.Name = "editProject";
            editProject.Size = new Size(131, 22);
            editProject.Text = "Edit...";
            editProject.Click += editToolStripMenuItem_Click;
            // 
            // deleteProject
            // 
            deleteProject.Name = "deleteProject";
            deleteProject.Size = new Size(131, 22);
            deleteProject.Text = "Delete";
            deleteProject.Click += deleteProject_Click;
            // 
            // contextMenuStripTask
            // 
            contextMenuStripTask.Items.AddRange(new ToolStripItem[] { addUserToolStripMenuItem, editTask, deleteTaskToolStripMenuItem });
            contextMenuStripTask.Name = "contextMenuStripTask";
            contextMenuStripTask.Size = new Size(143, 70);
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(142, 22);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // editTask
            // 
            editTask.Name = "editTask";
            editTask.Size = new Size(142, 22);
            editTask.Text = "Edit Task...";
            editTask.Click += editTask_Click;
            // 
            // deleteTaskToolStripMenuItem
            // 
            deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            deleteTaskToolStripMenuItem.Size = new Size(142, 22);
            deleteTaskToolStripMenuItem.Text = "Delete Task...";
            deleteTaskToolStripMenuItem.Click += deleteTaskToolStripMenuItem_Click;
            // 
            // contextMenuStripUser
            // 
            contextMenuStripUser.Items.AddRange(new ToolStripItem[] { editUser, deleteUserToolStrip });
            contextMenuStripUser.Name = "contextMenuStripUser";
            contextMenuStripUser.Size = new Size(108, 48);
            // 
            // editUser
            // 
            editUser.Name = "editUser";
            editUser.Size = new Size(107, 22);
            editUser.Text = "Edit...";
            editUser.Click += editUser_Click;
            // 
            // deleteUserToolStrip
            // 
            deleteUserToolStrip.Name = "deleteUserToolStrip";
            deleteUserToolStrip.Size = new Size(107, 22);
            deleteUserToolStrip.Text = "Delete";
            deleteUserToolStrip.Click += deleteUserToolStrip_Click;
            // 
            // contextMenuAllProjects
            // 
            contextMenuAllProjects.Items.AddRange(new ToolStripItem[] { addProjectToolStrip, refreshToolStripMenuItem1 });
            contextMenuAllProjects.Name = "contextMenuAllProjects";
            contextMenuAllProjects.Size = new Size(176, 48);
            // 
            // addProjectToolStrip
            // 
            addProjectToolStrip.Name = "addProjectToolStrip";
            addProjectToolStrip.Size = new Size(175, 22);
            addProjectToolStrip.Text = "Create New Project";
            addProjectToolStrip.Click += addProjectToolStrip_Click;
            // 
            // refreshToolStripMenuItem1
            // 
            refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            refreshToolStripMenuItem1.Size = new Size(175, 22);
            refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // mainStrip
            // 
            mainStrip.Items.AddRange(new ToolStripItem[] { userListToolStripMenuItem });
            mainStrip.Name = "mainStrip";
            mainStrip.Size = new Size(181, 48);
            // 
            // userListToolStripMenuItem
            // 
            userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            userListToolStripMenuItem.Size = new Size(180, 22);
            userListToolStripMenuItem.Text = "User List...";
            userListToolStripMenuItem.Click += userListToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusBar);
            Controls.Add(treeView1);
            Name = "MainForm";
            Text = "Проекты";
            Load += Form1_Load;
            MouseDown += MainForm_MouseDown;
            contextMenuStripProject.ResumeLayout(false);
            contextMenuStripTask.ResumeLayout(false);
            contextMenuStripUser.ResumeLayout(false);
            contextMenuAllProjects.ResumeLayout(false);
            mainStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label statusBar;
        private ContextMenuStrip contextMenuStripProject;
        private ContextMenuStrip contextMenuStripTask;
        private ContextMenuStrip contextMenuStripUser;
        private ToolStripMenuItem addTaskToolStrip;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ContextMenuStrip contextMenuAllProjects;
        private ToolStripMenuItem addProjectToolStrip;
        private ToolStripMenuItem refreshToolStripMenuItem1;
        private ToolStripMenuItem deleteUserToolStrip;
        private ToolStripMenuItem deleteTaskToolStripMenuItem;
        private ToolStripMenuItem deleteProject;
        private ToolStripMenuItem editProject;
        private ToolStripMenuItem editTask;
        private ToolStripMenuItem editUser;
        private ContextMenuStrip mainStrip;
        private ToolStripMenuItem userListToolStripMenuItem;
    }
}
