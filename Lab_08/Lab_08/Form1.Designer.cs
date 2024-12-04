namespace Activity_01_Lab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.combo_country = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_female = new System.Windows.Forms.RadioButton();
            this.radio_Male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_unmarried = new System.Windows.Forms.RadioButton();
            this.radio_married = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_reading = new System.Windows.Forms.CheckBox();
            this.chk_painting = new System.Windows.Forms.CheckBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.customerDBDataSet5 = new Activity_01_Lab.CustomerDBDataSet5();
            this.customerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_infoTableAdapter = new Activity_01_Lab.CustomerDBDataSet5TableAdapters.Customer_infoTableAdapter();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hobbiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDBDataSet6 = new Activity_01_Lab.CustomerDBDataSet6();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Activity_01_Lab.CustomerDBDataSet6TableAdapters.CustomerTableAdapter();
            this.customerDBDataSet7 = new Activity_01_Lab.CustomerDBDataSet7();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter1 = new Activity_01_Lab.CustomerDBDataSet7TableAdapters.CustomerTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(130, 21);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(121, 20);
            this.txt_cname.TabIndex = 2;
            this.txt_cname.TextChanged += new System.EventHandler(this.txt_cname_TextChanged);
            // 
            // combo_country
            // 
            this.combo_country.FormattingEnabled = true;
            this.combo_country.Location = new System.Drawing.Point(130, 58);
            this.combo_country.Name = "combo_country";
            this.combo_country.Size = new System.Drawing.Size(121, 21);
            this.combo_country.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_female);
            this.groupBox1.Controls.Add(this.radio_Male);
            this.groupBox1.Location = new System.Drawing.Point(40, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radio_female
            // 
            this.radio_female.AutoSize = true;
            this.radio_female.Location = new System.Drawing.Point(108, 19);
            this.radio_female.Name = "radio_female";
            this.radio_female.Size = new System.Drawing.Size(59, 17);
            this.radio_female.TabIndex = 1;
            this.radio_female.TabStop = true;
            this.radio_female.Text = "Female";
            this.radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_Male
            // 
            this.radio_Male.AutoSize = true;
            this.radio_Male.Location = new System.Drawing.Point(17, 19);
            this.radio_Male.Name = "radio_Male";
            this.radio_Male.Size = new System.Drawing.Size(48, 17);
            this.radio_Male.TabIndex = 0;
            this.radio_Male.TabStop = true;
            this.radio_Male.Text = "Male";
            this.radio_Male.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_unmarried);
            this.groupBox2.Controls.Add(this.radio_married);
            this.groupBox2.Location = new System.Drawing.Point(40, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 53);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // radio_unmarried
            // 
            this.radio_unmarried.AutoSize = true;
            this.radio_unmarried.Location = new System.Drawing.Point(108, 19);
            this.radio_unmarried.Name = "radio_unmarried";
            this.radio_unmarried.Size = new System.Drawing.Size(74, 17);
            this.radio_unmarried.TabIndex = 1;
            this.radio_unmarried.TabStop = true;
            this.radio_unmarried.Text = "UnMarried";
            this.radio_unmarried.UseVisualStyleBackColor = true;
            // 
            // radio_married
            // 
            this.radio_married.AutoSize = true;
            this.radio_married.Location = new System.Drawing.Point(17, 19);
            this.radio_married.Name = "radio_married";
            this.radio_married.Size = new System.Drawing.Size(60, 17);
            this.radio_married.TabIndex = 0;
            this.radio_married.TabStop = true;
            this.radio_married.Text = "Married";
            this.radio_married.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hobby";
            // 
            // chk_reading
            // 
            this.chk_reading.AutoSize = true;
            this.chk_reading.Location = new System.Drawing.Point(79, 189);
            this.chk_reading.Name = "chk_reading";
            this.chk_reading.Size = new System.Drawing.Size(66, 17);
            this.chk_reading.TabIndex = 7;
            this.chk_reading.Text = "Reading";
            this.chk_reading.UseVisualStyleBackColor = true;
            this.chk_reading.CheckedChanged += new System.EventHandler(this.chk_reading_CheckedChanged);
            // 
            // chk_painting
            // 
            this.chk_painting.AutoSize = true;
            this.chk_painting.Location = new System.Drawing.Point(165, 190);
            this.chk_painting.Name = "chk_painting";
            this.chk_painting.Size = new System.Drawing.Size(64, 17);
            this.chk_painting.TabIndex = 8;
            this.chk_painting.Text = "Painting";
            this.chk_painting.UseVisualStyleBackColor = true;
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(28, 292);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 9;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.AutoGenerateColumns = false;
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.hobbiesDataGridViewTextBoxColumn});
            this.dtgCustomer.DataSource = this.customerBindingSource1;
            this.dtgCustomer.Location = new System.Drawing.Point(279, 21);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.Size = new System.Drawing.Size(489, 294);
            this.dtgCustomer.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(130, 292);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(132, 330);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // customerDBDataSet5
            // 
            this.customerDBDataSet5.DataSetName = "CustomerDBDataSet5";
            this.customerDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerinfoBindingSource
            // 
            this.customerinfoBindingSource.DataMember = "Customer_info";
            this.customerinfoBindingSource.DataSource = this.customerDBDataSet5;
            // 
            // customer_infoTableAdapter
            // 
            this.customer_infoTableAdapter.ClearBeforeFill = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // hobbiesDataGridViewTextBoxColumn
            // 
            this.hobbiesDataGridViewTextBoxColumn.DataPropertyName = "Hobbies";
            this.hobbiesDataGridViewTextBoxColumn.HeaderText = "Hobbies";
            this.hobbiesDataGridViewTextBoxColumn.Name = "hobbiesDataGridViewTextBoxColumn";
            // 
            // customerDBDataSet6
            // 
            this.customerDBDataSet6.DataSetName = "CustomerDBDataSet6";
            this.customerDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.customerDBDataSet6;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerDBDataSet7
            // 
            this.customerDBDataSet7.DataSetName = "CustomerDBDataSet7";
            this.customerDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.customerDBDataSet7;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 374);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.chk_painting);
            this.Controls.Add(this.chk_reading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combo_country);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.ComboBox combo_country;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_female;
        private System.Windows.Forms.RadioButton radio_Male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_unmarried;
        private System.Windows.Forms.RadioButton radio_married;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_reading;
        private System.Windows.Forms.CheckBox chk_painting;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private CustomerDBDataSet5 customerDBDataSet5;
        private System.Windows.Forms.BindingSource customerinfoBindingSource;
        private CustomerDBDataSet5TableAdapters.Customer_infoTableAdapter customer_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hobbiesDataGridViewTextBoxColumn;
        private CustomerDBDataSet6 customerDBDataSet6;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private CustomerDBDataSet6TableAdapters.CustomerTableAdapter customerTableAdapter;
        private CustomerDBDataSet7 customerDBDataSet7;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private CustomerDBDataSet7TableAdapters.CustomerTableAdapter customerTableAdapter1;
    }
}

