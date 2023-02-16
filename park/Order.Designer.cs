namespace park
{
    partial class Order
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
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alltimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkDataSet = new park.parkDataSet();
            this.order_TableAdapter = new park.parkDataSetTableAdapters.Order_TableAdapter();
            this.tableAdapterManager1 = new park.parkDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.iduserDataGridViewTextBoxColumn,
            this.codeorderDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.codeclientDataGridViewTextBoxColumn,
            this.idstatusDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.alltimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "Id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "Id_order";
            this.idorderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idorderDataGridViewTextBoxColumn.Width = 86;
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "Id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "Id_user";
            this.iduserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            this.iduserDataGridViewTextBoxColumn.Width = 80;
            // 
            // codeorderDataGridViewTextBoxColumn
            // 
            this.codeorderDataGridViewTextBoxColumn.DataPropertyName = "Code_order";
            this.codeorderDataGridViewTextBoxColumn.HeaderText = "Code_order";
            this.codeorderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeorderDataGridViewTextBoxColumn.Name = "codeorderDataGridViewTextBoxColumn";
            this.codeorderDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeorderDataGridViewTextBoxColumn.Width = 108;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "Start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Start_date";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startdateDataGridViewTextBoxColumn.Width = 97;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "Start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "Start_time";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.starttimeDataGridViewTextBoxColumn.Width = 95;
            // 
            // codeclientDataGridViewTextBoxColumn
            // 
            this.codeclientDataGridViewTextBoxColumn.DataPropertyName = "Code_client";
            this.codeclientDataGridViewTextBoxColumn.HeaderText = "Code_client";
            this.codeclientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeclientDataGridViewTextBoxColumn.Name = "codeclientDataGridViewTextBoxColumn";
            this.codeclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeclientDataGridViewTextBoxColumn.Width = 107;
            // 
            // idstatusDataGridViewTextBoxColumn
            // 
            this.idstatusDataGridViewTextBoxColumn.DataPropertyName = "Id_status";
            this.idstatusDataGridViewTextBoxColumn.HeaderText = "Id_status";
            this.idstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstatusDataGridViewTextBoxColumn.Name = "idstatusDataGridViewTextBoxColumn";
            this.idstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idstatusDataGridViewTextBoxColumn.Width = 89;
            // 
            // enddateDataGridViewTextBoxColumn
            // 
            this.enddateDataGridViewTextBoxColumn.DataPropertyName = "End_date";
            this.enddateDataGridViewTextBoxColumn.HeaderText = "End_date";
            this.enddateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
            this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.enddateDataGridViewTextBoxColumn.Width = 94;
            // 
            // alltimeDataGridViewTextBoxColumn
            // 
            this.alltimeDataGridViewTextBoxColumn.DataPropertyName = "All_time";
            this.alltimeDataGridViewTextBoxColumn.HeaderText = "All_time";
            this.alltimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alltimeDataGridViewTextBoxColumn.Name = "alltimeDataGridViewTextBoxColumn";
            this.alltimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.alltimeDataGridViewTextBoxColumn.Width = 83;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order$";
            this.orderBindingSource.DataSource = this.parkDataSet;
            // 
            // parkDataSet
            // 
            this.parkDataSet.DataSetName = "parkDataSet";
            this.parkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_TableAdapter
            // 
            this.order_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.Auth_client_TableAdapter = null;
            this.tableAdapterManager1.Auth_user_TableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Client_TableAdapter = null;
            this.tableAdapterManager1.Content_TableAdapter = null;
            this.tableAdapterManager1.Last_TableAdapter = null;
            this.tableAdapterManager1.Order_TableAdapter = this.order_TableAdapter;
            this.tableAdapterManager1.Role_TableAdapter = null;
            this.tableAdapterManager1.Service_TableAdapter = null;
            this.tableAdapterManager1.Status_TableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = park.parkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.User_TableAdapter = null;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "а";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private parkDataSet parkDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private parkDataSetTableAdapters.Order_TableAdapter order_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alltimeDataGridViewTextBoxColumn;
        private parkDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}