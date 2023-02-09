namespace park
{
    partial class Second
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
            this.FioLlabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FioLlabel
            // 
            this.FioLlabel.AutoSize = true;
            this.FioLlabel.Location = new System.Drawing.Point(260, 190);
            this.FioLlabel.Name = "FioLlabel";
            this.FioLlabel.Size = new System.Drawing.Size(41, 16);
            this.FioLlabel.TabIndex = 0;
            this.FioLlabel.Text = "ФИО:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(255, 222);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(42, 16);
            this.RoleLabel.TabIndex = 1;
            this.RoleLabel.Text = "Роль:";
            // 
            // ServiceButton
            // 
            this.ServiceButton.Location = new System.Drawing.Point(226, 352);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(99, 38);
            this.ServiceButton.TabIndex = 2;
            this.ServiceButton.Text = "Услуги";
            this.ServiceButton.UseVisualStyleBackColor = true;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(370, 352);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(96, 38);
            this.OrderButton.TabIndex = 3;
            this.OrderButton.Text = "Заказы";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // Second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.ServiceButton);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.FioLlabel);
            this.Name = "Second";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парк Горького - Пользователь";
            this.Load += new System.EventHandler(this.Second_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FioLlabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Button ServiceButton;
        private System.Windows.Forms.Button OrderButton;
    }
}