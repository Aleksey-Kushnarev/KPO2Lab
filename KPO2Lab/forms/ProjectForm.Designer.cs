namespace KPO2Lab.forms
{
    partial class ProjectForm
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
            cancelBtn = new Button();
            okBtn = new Button();
            nameBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 10F);
            cancelBtn.Location = new Point(277, 197);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 29);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.Font = new Font("Segoe UI", 11F);
            okBtn.Location = new Point(179, 197);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(80, 29);
            okBtn.TabIndex = 14;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(120, 77);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(232, 29);
            nameBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 77);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 12;
            label1.Text = "Название";
            // 
            // ProjectForm
            // 
            AcceptButton = okBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(377, 258);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Name = "ProjectForm";
            Text = "Редактор проекта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button okBtn;
        private TextBox nameBox;
        private Label label1;
    }
}