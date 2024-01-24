namespace DanielleR_CPT_206_Lab_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.productDBDataSet = new DanielleR_CPT_206_Lab_1.ProductDBDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new DanielleR_CPT_206_Lab_1.ProductDBDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new DanielleR_CPT_206_Lab_1.ProductDBDataSetTableAdapters.TableAdapterManager();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblProdNum = new System.Windows.Forms.Label();
            this.lblProdText = new System.Windows.Forms.Label();
            this.txtProductNumber = new System.Windows.Forms.TextBox();
            this.txtDescriptionText = new System.Windows.Forms.TextBox();
            this.btnProdNum = new System.Windows.Forms.Button();
            this.btnDescripText = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSortByUnitsASC = new System.Windows.Forms.Button();
            this.txtUnitAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoreThanUnits = new System.Windows.Forms.Button();
            this.btnLessThanUnits = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnFindInRange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceMin = new System.Windows.Forms.TextBox();
            this.btnSortByPriceASC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriceMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // productDBDataSet
            // 
            this.productDBDataSet.DataSetName = "ProductDBDataSet";
            this.productDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productDBDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = DanielleR_CPT_206_Lab_1.ProductDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(1157, 33);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(29, 60);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            this.productDataGridView.RowTemplate.Height = 28;
            this.productDataGridView.Size = new System.Drawing.Size(663, 597);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product_Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.HeaderText = "Units_On_Hand";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDescripText);
            this.groupBox4.Controls.Add(this.btnProdNum);
            this.groupBox4.Controls.Add(this.txtDescriptionText);
            this.groupBox4.Controls.Add(this.txtProductNumber);
            this.groupBox4.Controls.Add(this.lblProdText);
            this.groupBox4.Controls.Add(this.lblProdNum);
            this.groupBox4.Location = new System.Drawing.Point(735, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 184);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Programming Problem 4";
            // 
            // lblProdNum
            // 
            this.lblProdNum.AutoSize = true;
            this.lblProdNum.Location = new System.Drawing.Point(24, 27);
            this.lblProdNum.Name = "lblProdNum";
            this.lblProdNum.Size = new System.Drawing.Size(203, 20);
            this.lblProdNum.TabIndex = 0;
            this.lblProdNum.Text = "Search by Product Number:";
            // 
            // lblProdText
            // 
            this.lblProdText.AutoSize = true;
            this.lblProdText.Location = new System.Drawing.Point(24, 98);
            this.lblProdText.Name = "lblProdText";
            this.lblProdText.Size = new System.Drawing.Size(118, 20);
            this.lblProdText.TabIndex = 1;
            this.lblProdText.Text = "Search by Text:";
            // 
            // txtProductNumber
            // 
            this.txtProductNumber.Location = new System.Drawing.Point(57, 60);
            this.txtProductNumber.Name = "txtProductNumber";
            this.txtProductNumber.Size = new System.Drawing.Size(246, 26);
            this.txtProductNumber.TabIndex = 2;
            // 
            // txtDescriptionText
            // 
            this.txtDescriptionText.Location = new System.Drawing.Point(57, 121);
            this.txtDescriptionText.Name = "txtDescriptionText";
            this.txtDescriptionText.Size = new System.Drawing.Size(246, 26);
            this.txtDescriptionText.TabIndex = 3;
            // 
            // btnProdNum
            // 
            this.btnProdNum.Location = new System.Drawing.Point(323, 55);
            this.btnProdNum.Name = "btnProdNum";
            this.btnProdNum.Size = new System.Drawing.Size(50, 37);
            this.btnProdNum.TabIndex = 4;
            this.btnProdNum.Text = "Go";
            this.btnProdNum.UseVisualStyleBackColor = true;
            this.btnProdNum.Click += new System.EventHandler(this.btnProdNum_Click);
            // 
            // btnDescripText
            // 
            this.btnDescripText.Location = new System.Drawing.Point(323, 116);
            this.btnDescripText.Name = "btnDescripText";
            this.btnDescripText.Size = new System.Drawing.Size(50, 37);
            this.btnDescripText.TabIndex = 5;
            this.btnDescripText.Text = "Go";
            this.btnDescripText.UseVisualStyleBackColor = true;
            this.btnDescripText.Click += new System.EventHandler(this.btnDescripText_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLessThanUnits);
            this.groupBox5.Controls.Add(this.btnMoreThanUnits);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtUnitAmount);
            this.groupBox5.Controls.Add(this.btnSortByUnitsASC);
            this.groupBox5.Location = new System.Drawing.Point(735, 202);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(396, 214);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Programming Problem 5";
            // 
            // btnSortByUnitsASC
            // 
            this.btnSortByUnitsASC.Location = new System.Drawing.Point(104, 37);
            this.btnSortByUnitsASC.Name = "btnSortByUnitsASC";
            this.btnSortByUnitsASC.Size = new System.Drawing.Size(184, 37);
            this.btnSortByUnitsASC.TabIndex = 4;
            this.btnSortByUnitsASC.Text = "Sort by Units, ASC";
            this.btnSortByUnitsASC.UseVisualStyleBackColor = true;
            this.btnSortByUnitsASC.Click += new System.EventHandler(this.btnSortByUnitsASC_Click);
            // 
            // txtUnitAmount
            // 
            this.txtUnitAmount.Location = new System.Drawing.Point(258, 89);
            this.txtUnitAmount.Name = "txtUnitAmount";
            this.txtUnitAmount.Size = new System.Drawing.Size(79, 26);
            this.txtUnitAmount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Desired Unit Amount:";
            // 
            // btnMoreThanUnits
            // 
            this.btnMoreThanUnits.Location = new System.Drawing.Point(29, 135);
            this.btnMoreThanUnits.Name = "btnMoreThanUnits";
            this.btnMoreThanUnits.Size = new System.Drawing.Size(170, 54);
            this.btnMoreThanUnits.TabIndex = 7;
            this.btnMoreThanUnits.Text = "Find Products More Than Amount";
            this.btnMoreThanUnits.UseVisualStyleBackColor = true;
            this.btnMoreThanUnits.Click += new System.EventHandler(this.btnMoreThanUnits_Click);
            // 
            // btnLessThanUnits
            // 
            this.btnLessThanUnits.Location = new System.Drawing.Point(209, 135);
            this.btnLessThanUnits.Name = "btnLessThanUnits";
            this.btnLessThanUnits.Size = new System.Drawing.Size(170, 54);
            this.btnLessThanUnits.TabIndex = 8;
            this.btnLessThanUnits.Text = "Find Products Less Than Amount";
            this.btnLessThanUnits.UseVisualStyleBackColor = true;
            this.btnLessThanUnits.Click += new System.EventHandler(this.btnLessThanUnits_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtPriceMax);
            this.groupBox6.Controls.Add(this.btnFindInRange);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtPriceMin);
            this.groupBox6.Controls.Add(this.btnSortByPriceASC);
            this.groupBox6.Location = new System.Drawing.Point(735, 422);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(396, 235);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Programming Problem 6";
            // 
            // btnFindInRange
            // 
            this.btnFindInRange.Location = new System.Drawing.Point(118, 156);
            this.btnFindInRange.Name = "btnFindInRange";
            this.btnFindInRange.Size = new System.Drawing.Size(170, 54);
            this.btnFindInRange.TabIndex = 7;
            this.btnFindInRange.Text = "Find Products Within Range";
            this.btnFindInRange.UseVisualStyleBackColor = true;
            this.btnFindInRange.Click += new System.EventHandler(this.btnFindInRange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Minimum:";
            // 
            // txtPriceMin
            // 
            this.txtPriceMin.Location = new System.Drawing.Point(223, 85);
            this.txtPriceMin.Name = "txtPriceMin";
            this.txtPriceMin.Size = new System.Drawing.Size(79, 26);
            this.txtPriceMin.TabIndex = 5;
            // 
            // btnSortByPriceASC
            // 
            this.btnSortByPriceASC.Location = new System.Drawing.Point(104, 37);
            this.btnSortByPriceASC.Name = "btnSortByPriceASC";
            this.btnSortByPriceASC.Size = new System.Drawing.Size(184, 37);
            this.btnSortByPriceASC.TabIndex = 4;
            this.btnSortByPriceASC.Text = "Sort by Price, ASC";
            this.btnSortByPriceASC.UseVisualStyleBackColor = true;
            this.btnSortByPriceASC.Click += new System.EventHandler(this.btnSortByPriceASC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Maximum:";
            // 
            // txtPriceMax
            // 
            this.txtPriceMax.Location = new System.Drawing.Point(223, 117);
            this.txtPriceMax.Name = "txtPriceMax";
            this.txtPriceMax.Size = new System.Drawing.Size(79, 26);
            this.txtPriceMax.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 676);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productBindingNavigator);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danielle-CPT-206-Lab-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProductDBDataSet productDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private ProductDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblProdNum;
        private System.Windows.Forms.Label lblProdText;
        private System.Windows.Forms.Button btnDescripText;
        private System.Windows.Forms.Button btnProdNum;
        private System.Windows.Forms.TextBox txtDescriptionText;
        private System.Windows.Forms.TextBox txtProductNumber;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLessThanUnits;
        private System.Windows.Forms.Button btnMoreThanUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnitAmount;
        private System.Windows.Forms.Button btnSortByUnitsASC;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnFindInRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPriceMin;
        private System.Windows.Forms.Button btnSortByPriceASC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriceMax;
    }
}

