namespace park
{
    partial class Service_Add
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
            System.Windows.Forms.Label id_serviceLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label name_serviceLabel;
            System.Windows.Forms.Label service_codeLabel;
            System.Windows.Forms.Label costLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service_Add));
            this.parkDataSet = new park.parkDataSet();
            this.service_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.service_TableAdapter = new park.parkDataSetTableAdapters.Service_TableAdapter();
            this.tableAdapterManager = new park.parkDataSetTableAdapters.TableAdapterManager();
            this.service_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.service_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_serviceTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.name_serviceTextBox = new System.Windows.Forms.TextBox();
            this.service_codeTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            id_serviceLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            name_serviceLabel = new System.Windows.Forms.Label();
            service_codeLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_BindingNavigator)).BeginInit();
            this.service_BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_serviceLabel
            // 
            id_serviceLabel.AutoSize = true;
            id_serviceLabel.Location = new System.Drawing.Point(161, 101);
            id_serviceLabel.Name = "id_serviceLabel";
            id_serviceLabel.Size = new System.Drawing.Size(53, 16);
            id_serviceLabel.TabIndex = 1;
            id_serviceLabel.Text = "Номер:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(113, 135);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(98, 16);
            idLabel.TabIndex = 3;
            idLabel.Text = "Номер услуги";
            // 
            // name_serviceLabel
            // 
            name_serviceLabel.AutoSize = true;
            name_serviceLabel.Location = new System.Drawing.Point(87, 181);
            name_serviceLabel.Name = "name_serviceLabel";
            name_serviceLabel.Size = new System.Drawing.Size(124, 16);
            name_serviceLabel.TabIndex = 5;
            name_serviceLabel.Text = "Название услуги:";
            // 
            // service_codeLabel
            // 
            service_codeLabel.AutoSize = true;
            service_codeLabel.Location = new System.Drawing.Point(121, 223);
            service_codeLabel.Name = "service_codeLabel";
            service_codeLabel.Size = new System.Drawing.Size(82, 16);
            service_codeLabel.TabIndex = 7;
            service_codeLabel.Text = "Код услуги:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(123, 261);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(80, 16);
            costLabel.TabIndex = 9;
            costLabel.Text = "Стоимость:";
            // 
            // parkDataSet
            // 
            this.parkDataSet.DataSetName = "parkDataSet";
            this.parkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // service_BindingSource
            // 
            this.service_BindingSource.DataMember = "Service$";
            this.service_BindingSource.DataSource = this.parkDataSet;
            // 
            // service_TableAdapter
            // 
            this.service_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Auth_client_TableAdapter = null;
            this.tableAdapterManager.Auth_user_TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Client_TableAdapter = null;
            this.tableAdapterManager.Content_TableAdapter = null;
            this.tableAdapterManager.Last_TableAdapter = null;
            this.tableAdapterManager.Order_TableAdapter = null;
            this.tableAdapterManager.Role_TableAdapter = null;
            this.tableAdapterManager.Service_TableAdapter = this.service_TableAdapter;
            this.tableAdapterManager.Status_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = park.parkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_TableAdapter = null;
            // 
            // service_BindingNavigator
            // 
            this.service_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.service_BindingNavigator.BindingSource = this.service_BindingSource;
            this.service_BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.service_BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.service_BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.service_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.service_BindingNavigatorSaveItem});
            this.service_BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.service_BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.service_BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.service_BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.service_BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.service_BindingNavigator.Name = "service_BindingNavigator";
            this.service_BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.service_BindingNavigator.Size = new System.Drawing.Size(478, 27);
            this.service_BindingNavigator.TabIndex = 0;
            this.service_BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // service_BindingNavigatorSaveItem
            // 
            this.service_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.service_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("service_BindingNavigatorSaveItem.Image")));
            this.service_BindingNavigatorSaveItem.Name = "service_BindingNavigatorSaveItem";
            this.service_BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.service_BindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // id_serviceTextBox
            // 
            this.id_serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_BindingSource, "Id_service", true));
            this.id_serviceTextBox.Location = new System.Drawing.Point(217, 98);
            this.id_serviceTextBox.Name = "id_serviceTextBox";
            this.id_serviceTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_serviceTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_BindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(217, 135);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 4;
            // 
            // name_serviceTextBox
            // 
            this.name_serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_BindingSource, "Name_service", true));
            this.name_serviceTextBox.Location = new System.Drawing.Point(217, 175);
            this.name_serviceTextBox.Name = "name_serviceTextBox";
            this.name_serviceTextBox.Size = new System.Drawing.Size(100, 22);
            this.name_serviceTextBox.TabIndex = 6;
            // 
            // service_codeTextBox
            // 
            this.service_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_BindingSource, "Service_code", true));
            this.service_codeTextBox.Location = new System.Drawing.Point(217, 220);
            this.service_codeTextBox.Name = "service_codeTextBox";
            this.service_codeTextBox.Size = new System.Drawing.Size(100, 22);
            this.service_codeTextBox.TabIndex = 8;
            // 
            // costTextBox
            // 
            this.costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.service_BindingSource, "Cost", true));
            this.costTextBox.Location = new System.Drawing.Point(217, 258);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 22);
            this.costTextBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(164, 329);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Service_Red
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(service_codeLabel);
            this.Controls.Add(this.service_codeTextBox);
            this.Controls.Add(name_serviceLabel);
            this.Controls.Add(this.name_serviceTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(id_serviceLabel);
            this.Controls.Add(this.id_serviceTextBox);
            this.Controls.Add(this.service_BindingNavigator);
            this.Name = "Service_Red";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парк Горького - Услуги - Добавление";
            this.Load += new System.EventHandler(this.Service_Red_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.service_BindingNavigator)).EndInit();
            this.service_BindingNavigator.ResumeLayout(false);
            this.service_BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private parkDataSet parkDataSet;
        private System.Windows.Forms.BindingSource service_BindingSource;
        private parkDataSetTableAdapters.Service_TableAdapter service_TableAdapter;
        private parkDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator service_BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton service_BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_serviceTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox name_serviceTextBox;
        private System.Windows.Forms.TextBox service_codeTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}