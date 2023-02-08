namespace park
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AutharizationButton = new System.Windows.Forms.Button();
            this.ClientCheckBox = new System.Windows.Forms.CheckBox();
            this.VisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(314, 153);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(251, 22);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(314, 190);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(251, 22);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // AutharizationButton
            // 
            this.AutharizationButton.Location = new System.Drawing.Point(314, 309);
            this.AutharizationButton.Name = "AutharizationButton";
            this.AutharizationButton.Size = new System.Drawing.Size(152, 57);
            this.AutharizationButton.TabIndex = 4;
            this.AutharizationButton.Text = "Вход";
            this.AutharizationButton.UseVisualStyleBackColor = true;
            // 
            // ClientCheckBox
            // 
            this.ClientCheckBox.AutoSize = true;
            this.ClientCheckBox.Location = new System.Drawing.Point(345, 252);
            this.ClientCheckBox.Name = "ClientCheckBox";
            this.ClientCheckBox.Size = new System.Drawing.Size(75, 20);
            this.ClientCheckBox.TabIndex = 5;
            this.ClientCheckBox.Text = "клиент";
            this.ClientCheckBox.UseVisualStyleBackColor = true;
            // 
            // VisibleCheckBox
            // 
            this.VisibleCheckBox.AutoSize = true;
            this.VisibleCheckBox.Location = new System.Drawing.Point(581, 190);
            this.VisibleCheckBox.Name = "VisibleCheckBox";
            this.VisibleCheckBox.Size = new System.Drawing.Size(100, 20);
            this.VisibleCheckBox.TabIndex = 7;
            this.VisibleCheckBox.Text = "Видимость";
            this.VisibleCheckBox.UseVisualStyleBackColor = true;
            this.VisibleCheckBox.CheckedChanged += new System.EventHandler(this.VisibleCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VisibleCheckBox);
            this.Controls.Add(this.ClientCheckBox);
            this.Controls.Add(this.AutharizationButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Парк Горького - Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button AutharizationButton;
        private System.Windows.Forms.CheckBox ClientCheckBox;
        private System.Windows.Forms.CheckBox VisibleCheckBox;
    }
}

