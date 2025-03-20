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
            listContext = new ContextMenuStrip(components);
            addUserToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            itemContext.SuspendLayout();
            listContext.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(28, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(529, 384);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // itemContext
            // 
            itemContext.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            itemContext.Name = "itemContext";
            itemContext.Size = new Size(117, 48);
            // 
            // listContext
            // 
            listContext.Items.AddRange(new ToolStripItem[] { addUserToolStripMenuItem });
            listContext.Name = "listContext";
            listContext.Size = new Size(132, 26);
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(131, 22);
            addUserToolStripMenuItem.Text = "Add User...";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(116, 22);
            editToolStripMenuItem.Text = "Edit...";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(116, 22);
            deleteToolStripMenuItem.Text = "Delete...";
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 514);
            Controls.Add(listView1);
            Name = "UserListForm";
            Text = "UserListForm";
            itemContext.ResumeLayout(false);
            listContext.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ContextMenuStrip itemContext;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip listContext;
        private ToolStripMenuItem addUserToolStripMenuItem;
    }
}