namespace KPO2Lab.forms
{
    partial class RegictrationForm
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
            passwordBox = new TextBox();
            label2 = new Label();
            loginBox = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 10F);
            cancelBtn.Location = new Point(302, 252);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 29);
            cancelBtn.TabIndex = 18;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            okBtn.Font = new Font("Segoe UI", 11F);
            okBtn.Location = new Point(214, 252);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(82, 29);
            okBtn.TabIndex = 17;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 12F);
            passwordBox.Location = new Point(142, 165);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(235, 29);
            passwordBox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(61, 168);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 15;
            label2.Text = "Пароль";
            // 
            // loginBox
            // 
            loginBox.Font = new Font("Segoe UI", 12F);
            loginBox.Location = new Point(144, 90);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(233, 29);
            loginBox.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(61, 93);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 13;
            label1.Text = "Логин";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 348);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(439, 22);
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 17);
            // 
            // RegictrationForm
            // 
            AcceptButton = okBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(439, 370);
            Controls.Add(statusStrip1);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(loginBox);
            Controls.Add(label1);
            Name = "RegictrationForm";
            Text = "Регистрация";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button okBtn;
        private TextBox passwordBox;
        private Label label2;
        private TextBox loginBox;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
    }
}