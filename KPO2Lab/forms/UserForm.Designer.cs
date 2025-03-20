namespace KPO2Lab.forms
{
    partial class UserForm
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
            label1 = new Label();
            nameBox = new TextBox();
            surnameBox = new TextBox();
            label2 = new Label();
            okBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(114, 34);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(187, 29);
            nameBox.TabIndex = 1;
            // 
            // surnameBox
            // 
            surnameBox.Font = new Font("Segoe UI", 12F);
            surnameBox.Location = new Point(112, 109);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(189, 29);
            surnameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(31, 112);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // okBtn
            // 
            okBtn.Font = new Font("Segoe UI", 11F);
            okBtn.Location = new Point(174, 196);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(80, 29);
            okBtn.TabIndex = 4;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 10F);
            cancelBtn.Location = new Point(272, 196);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 29);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(372, 258);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(surnameBox);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "Редактор пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private TextBox surnameBox;
        private Label label2;
        private Button okBtn;
        private Button cancelBtn;
    }
}