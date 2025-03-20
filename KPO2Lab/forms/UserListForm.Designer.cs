namespace KPO2Lab.forms
{
    partial class UserListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView1 = new ListView();
            itemContext = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteUserTool = new ToolStripMenuItem();
            listContext = new ContextMenuStrip(components);
            addUserToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            addUserToolStripMenuItem1 = new ToolStripMenuItem();
            itemContext.SuspendLayout();
            listContext.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(21, 43);
            listView1.Name = "listView1";
            listView1.Size = new Size(529, 384);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Click += listView1_Click;
            listView1.MouseClick += listView1_MouseClick;
            // 
            // itemContext
            // 
            itemContext.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteUserTool });
            itemContext.Name = "itemContext";
            itemContext.Size = new Size(181, 70);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit...";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteUserTool
            // 
            deleteUserTool.Name = "deleteUserTool";
            deleteUserTool.Size = new Size(180, 22);
            deleteUserTool.Text = "Delete...";
            deleteUserTool.Click += deleteUserTool_Click;
            // 
            // listContext
            // 
            listContext.Items.AddRange(new ToolStripItem[] { addUserToolStripMenuItem });
            listContext.Name = "listContext";
            listContext.Size = new Size(132, 26);
            listContext.MouseDown += listContext_MouseDown;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(131, 22);
            addUserToolStripMenuItem.Text = "Add User...";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addUserToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(579, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // addUserToolStripMenuItem1
            // 
            addUserToolStripMenuItem1.Name = "addUserToolStripMenuItem1";
            addUserToolStripMenuItem1.Size = new Size(76, 20);
            addUserToolStripMenuItem1.Text = "Add User...";
            addUserToolStripMenuItem1.Click += addUserToolStripMenuItem1_Click;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 514);
            Controls.Add(menuStrip1);
            Controls.Add(listView1);
            MainMenuStrip = menuStrip1;
            Name = "UserListForm";
            Text = "Список пользователей";
            itemContext.ResumeLayout(false);
            listContext.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ContextMenuStrip itemContext;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteUserTool;
        private ContextMenuStrip listContext;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addUserToolStripMenuItem1;
    }
}