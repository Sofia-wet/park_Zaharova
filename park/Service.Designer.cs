namespace park
{
    partial class Service
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameserviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkDataSet = new park.parkDataSet();
            this.service_TableAdapter = new park.parkDataSetTableAdapters.Service_TableAdapter();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idserviceDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameserviceDataGridViewTextBoxColumn,
            this.servicecodeDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.serviceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(696, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // idserviceDataGridViewTextBoxColumn
            // 
            this.idserviceDataGridViewTextBoxColumn.DataPropertyName = "Id_service";
            this.idserviceDataGridViewTextBoxColumn.HeaderText = "Id_service";
            this.idserviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idserviceDataGridViewTextBoxColumn.Name = "idserviceDataGridViewTextBoxColumn";
            this.idserviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idserviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameserviceDataGridViewTextBoxColumn
            // 
            this.nameserviceDataGridViewTextBoxColumn.DataPropertyName = "Name_service";
            this.nameserviceDataGridViewTextBoxColumn.HeaderText = "Name_service";
            this.nameserviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameserviceDataGridViewTextBoxColumn.Name = "nameserviceDataGridViewTextBoxColumn";
            this.nameserviceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameserviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // servicecodeDataGridViewTextBoxColumn
            // 
            this.servicecodeDataGridViewTextBoxColumn.DataPropertyName = "Service_code";
            this.servicecodeDataGridViewTextBoxColumn.HeaderText = "Service_code";
            this.servicecodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicecodeDataGridViewTextBoxColumn.Name = "servicecodeDataGridViewTextBoxColumn";
            this.servicecodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.servicecodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service$";
            this.serviceBindingSource.DataSource = this.parkDataSet;
            // 
            // parkDataSet
            // 
            this.parkDataSet.DataSetName = "parkDataSet";
            this.parkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // service_TableAdapter
            // 
            this.service_TableAdapter.ClearBeforeFill = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(731, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парк Горького - Услуги";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private parkDataSet parkDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private parkDataSetTableAdapters.Service_TableAdapter service_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameserviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddButton;
    }
}