namespace HostelDogs
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
            System.Windows.Forms.Label fechadeIngresoLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nombreLabel;
            this.perroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.perroBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.perroBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.perroDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadeIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            fechadeIngresoLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perroBindingSource1BindingNavigator)).BeginInit();
            this.perroBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perroDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // perroBindingSource1
            // 
            this.perroBindingSource1.DataSource = typeof(HostelDogSettings.Perro);
            // 
            // perroBindingSource1BindingNavigator
            // 
            this.perroBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.perroBindingSource1BindingNavigator.BindingSource = this.perroBindingSource1;
            this.perroBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.perroBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.perroBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.perroBindingSource1BindingNavigatorSaveItem});
            this.perroBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.perroBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.perroBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.perroBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.perroBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.perroBindingSource1BindingNavigator.Name = "perroBindingSource1BindingNavigator";
            this.perroBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.perroBindingSource1BindingNavigator.Size = new System.Drawing.Size(596, 25);
            this.perroBindingSource1BindingNavigator.TabIndex = 0;
            this.perroBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorMoveFirstItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorMovePreviousItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "bindingNavigatorPositionItem";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "bindingNavigatorCountItem";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "bindingNavigatorMoveNextItem";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "bindingNavigatorMoveLastItem";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "bindingNavigatorSeparator";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // perroBindingSource1BindingNavigatorSaveItem
            // 
            this.perroBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.perroBindingSource1BindingNavigatorSaveItem.Enabled = false;
            this.perroBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("perroBindingSource1BindingNavigatorSaveItem.Image")));
            this.perroBindingSource1BindingNavigatorSaveItem.Name = "perroBindingSource1BindingNavigatorSaveItem";
            this.perroBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.perroBindingSource1BindingNavigatorSaveItem.Text = "Save Data";
            // 
            // perroDataGridView1
            // 
            this.perroDataGridView1.AutoGenerateColumns = false;
            this.perroDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.perroDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.perroDataGridView1.DataSource = this.perroBindingSource1;
            this.perroDataGridView1.Location = new System.Drawing.Point(25, 148);
            this.perroDataGridView1.Name = "perroDataGridView1";
            this.perroDataGridView1.Size = new System.Drawing.Size(411, 104);
            this.perroDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechadeIngreso";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechadeIngreso";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // fechadeIngresoLabel
            // 
            fechadeIngresoLabel.AutoSize = true;
            fechadeIngresoLabel.Location = new System.Drawing.Point(22, 59);
            fechadeIngresoLabel.Name = "fechadeIngresoLabel";
            fechadeIngresoLabel.Size = new System.Drawing.Size(90, 13);
            fechadeIngresoLabel.TabIndex = 2;
            fechadeIngresoLabel.Text = "Fechade Ingreso:";
            // 
            // fechadeIngresoDateTimePicker
            // 
            this.fechadeIngresoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.perroBindingSource1, "FechadeIngreso", true));
            this.fechadeIngresoDateTimePicker.Location = new System.Drawing.Point(118, 55);
            this.fechadeIngresoDateTimePicker.Name = "fechadeIngresoDateTimePicker";
            this.fechadeIngresoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechadeIngresoDateTimePicker.TabIndex = 3;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(22, 84);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perroBindingSource1, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(118, 81);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 5;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(22, 110);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.perroBindingSource1, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(118, 107);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 346);
            this.Controls.Add(fechadeIngresoLabel);
            this.Controls.Add(this.fechadeIngresoDateTimePicker);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.perroDataGridView1);
            this.Controls.Add(this.perroBindingSource1BindingNavigator);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.perroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perroBindingSource1BindingNavigator)).EndInit();
            this.perroBindingSource1BindingNavigator.ResumeLayout(false);
            this.perroBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perroDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource perroBindingSource;
        private System.Windows.Forms.BindingNavigator perroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton perroBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView perroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource perroBindingSource1;
        private System.Windows.Forms.BindingNavigator perroBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton perroBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView perroDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DateTimePicker fechadeIngresoDateTimePicker;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}

