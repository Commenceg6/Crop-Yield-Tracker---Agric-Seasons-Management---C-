namespace FinalAgricRec
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
            System.Windows.Forms.Label cropidLabel;
            System.Windows.Forms.Label crop_nameLabel;
            System.Windows.Forms.Label period_typeLabel;
            System.Windows.Forms.Label average_yieldLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblperiodNumber = new System.Windows.Forms.Label();
            this.agricDataSet = new WindowsFormsApplication1.agricDataSet();
            this.seasonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seasonsTableAdapter = new WindowsFormsApplication1.agricDataSetTableAdapters.seasonsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.agricDataSetTableAdapters.TableAdapterManager();
            this.txtcropId = new System.Windows.Forms.TextBox();
            this.cmbcropName = new System.Windows.Forms.ComboBox();
            this.cmbperiodType = new System.Windows.Forms.ComboBox();
            this.txtperiodNumber = new System.Windows.Forms.TextBox();
            this.txtaverageYield = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnaddNew = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnvisualize = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.chataverage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.seasonsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cropidLabel = new System.Windows.Forms.Label();
            crop_nameLabel = new System.Windows.Forms.Label();
            period_typeLabel = new System.Windows.Forms.Label();
            average_yieldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agricDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chataverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cropidLabel
            // 
            cropidLabel.AutoSize = true;
            cropidLabel.Location = new System.Drawing.Point(13, 87);
            cropidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cropidLabel.Name = "cropidLabel";
            cropidLabel.Size = new System.Drawing.Size(51, 17);
            cropidLabel.TabIndex = 0;
            cropidLabel.Text = "cropid:";
            cropidLabel.Click += new System.EventHandler(this.cropidLabel_Click);
            // 
            // crop_nameLabel
            // 
            crop_nameLabel.AutoSize = true;
            crop_nameLabel.Location = new System.Drawing.Point(13, 119);
            crop_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            crop_nameLabel.Name = "crop_nameLabel";
            crop_nameLabel.Size = new System.Drawing.Size(79, 17);
            crop_nameLabel.TabIndex = 2;
            crop_nameLabel.Text = "crop name:";
            crop_nameLabel.Click += new System.EventHandler(this.crop_nameLabel_Click);
            // 
            // period_typeLabel
            // 
            period_typeLabel.AutoSize = true;
            period_typeLabel.Location = new System.Drawing.Point(13, 153);
            period_typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            period_typeLabel.Name = "period_typeLabel";
            period_typeLabel.Size = new System.Drawing.Size(83, 17);
            period_typeLabel.TabIndex = 4;
            period_typeLabel.Text = "period type:";
            period_typeLabel.Click += new System.EventHandler(this.period_typeLabel_Click);
            // 
            // average_yieldLabel
            // 
            average_yieldLabel.AutoSize = true;
            average_yieldLabel.Location = new System.Drawing.Point(13, 218);
            average_yieldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            average_yieldLabel.Name = "average_yieldLabel";
            average_yieldLabel.Size = new System.Drawing.Size(97, 17);
            average_yieldLabel.TabIndex = 8;
            average_yieldLabel.Text = "average yield:";
            // 
            // lblperiodNumber
            // 
            this.lblperiodNumber.AutoSize = true;
            this.lblperiodNumber.Location = new System.Drawing.Point(13, 186);
            this.lblperiodNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblperiodNumber.Name = "lblperiodNumber";
            this.lblperiodNumber.Size = new System.Drawing.Size(104, 17);
            this.lblperiodNumber.TabIndex = 16;
            this.lblperiodNumber.Text = "period number:";
            this.lblperiodNumber.Click += new System.EventHandler(this.lblperiodNumber_Click);
            // 
            // agricDataSet
            // 
            this.agricDataSet.DataSetName = "agricDataSet";
            this.agricDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seasonsBindingSource
            // 
            this.seasonsBindingSource.DataMember = "seasons";
            this.seasonsBindingSource.DataSource = this.agricDataSet;
            // 
            // seasonsTableAdapter
            // 
            this.seasonsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.seasonsTableAdapter = this.seasonsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.agricDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtcropId
            // 
            this.txtcropId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seasonsBindingSource, "cropid", true));
            this.txtcropId.Location = new System.Drawing.Point(124, 84);
            this.txtcropId.Margin = new System.Windows.Forms.Padding(4);
            this.txtcropId.Name = "txtcropId";
            this.txtcropId.Size = new System.Drawing.Size(117, 22);
            this.txtcropId.TabIndex = 1;
            // 
            // cmbcropName
            // 
            this.cmbcropName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seasonsBindingSource, "crop_name", true));
            this.cmbcropName.FormattingEnabled = true;
            this.cmbcropName.Items.AddRange(new object[] {
            "Maize",
            "Beans",
            "Wheat",
            "Potatoes"});
            this.cmbcropName.Location = new System.Drawing.Point(124, 116);
            this.cmbcropName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbcropName.Name = "cmbcropName";
            this.cmbcropName.Size = new System.Drawing.Size(117, 24);
            this.cmbcropName.TabIndex = 3;
            // 
            // cmbperiodType
            // 
            this.cmbperiodType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seasonsBindingSource, "period_type", true));
            this.cmbperiodType.FormattingEnabled = true;
            this.cmbperiodType.Items.AddRange(new object[] {
            "weekly ",
            "monthly",
            "annually"});
            this.cmbperiodType.Location = new System.Drawing.Point(124, 149);
            this.cmbperiodType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbperiodType.Name = "cmbperiodType";
            this.cmbperiodType.Size = new System.Drawing.Size(117, 24);
            this.cmbperiodType.TabIndex = 5;
            this.cmbperiodType.SelectedIndexChanged += new System.EventHandler(this.cmbperiodType_SelectedIndexChanged);
            // 
            // txtperiodNumber
            // 
            this.txtperiodNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seasonsBindingSource, "period_number", true));
            this.txtperiodNumber.Location = new System.Drawing.Point(124, 182);
            this.txtperiodNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtperiodNumber.Name = "txtperiodNumber";
            this.txtperiodNumber.Size = new System.Drawing.Size(117, 22);
            this.txtperiodNumber.TabIndex = 7;
            // 
            // txtaverageYield
            // 
            this.txtaverageYield.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.seasonsBindingSource, "average_yield", true));
            this.txtaverageYield.Location = new System.Drawing.Point(124, 214);
            this.txtaverageYield.Margin = new System.Windows.Forms.Padding(4);
            this.txtaverageYield.Name = "txtaverageYield";
            this.txtaverageYield.Size = new System.Drawing.Size(117, 22);
            this.txtaverageYield.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnaddNew);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnvisualize);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.cmbperiodType);
            this.groupBox1.Controls.Add(cropidLabel);
            this.groupBox1.Controls.Add(this.txtaverageYield);
            this.groupBox1.Controls.Add(this.txtcropId);
            this.groupBox1.Controls.Add(average_yieldLabel);
            this.groupBox1.Controls.Add(crop_nameLabel);
            this.groupBox1.Controls.Add(this.txtperiodNumber);
            this.groupBox1.Controls.Add(this.cmbcropName);
            this.groupBox1.Controls.Add(this.lblperiodNumber);
            this.groupBox1.Controls.Add(period_typeLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(264, 455);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnaddNew
            // 
            this.btnaddNew.Location = new System.Drawing.Point(69, 300);
            this.btnaddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddNew.Name = "btnaddNew";
            this.btnaddNew.Size = new System.Drawing.Size(100, 28);
            this.btnaddNew.TabIndex = 18;
            this.btnaddNew.Text = "add new";
            this.btnaddNew.UseVisualStyleBackColor = true;
            this.btnaddNew.Click += new System.EventHandler(this.btnaddNew_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(124, 336);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 28);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnvisualize
            // 
            this.btnvisualize.Location = new System.Drawing.Point(69, 372);
            this.btnvisualize.Margin = new System.Windows.Forms.Padding(4);
            this.btnvisualize.Name = "btnvisualize";
            this.btnvisualize.Size = new System.Drawing.Size(100, 28);
            this.btnvisualize.TabIndex = 11;
            this.btnvisualize.Text = "visualize";
            this.btnvisualize.UseVisualStyleBackColor = true;
            this.btnvisualize.Click += new System.EventHandler(this.btnvisualize_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(8, 336);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 28);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnaddInfor_Click);
            // 
            // chataverage
            // 
            chartArea1.Name = "ChartArea1";
            this.chataverage.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chataverage.Legends.Add(legend1);
            this.chataverage.Location = new System.Drawing.Point(288, 15);
            this.chataverage.Margin = new System.Windows.Forms.Padding(4);
            this.chataverage.Name = "chataverage";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chataverage.Series.Add(series1);
            this.chataverage.Size = new System.Drawing.Size(403, 455);
            this.chataverage.TabIndex = 11;
            this.chataverage.Text = "monthly weekly and annualy averages";
            this.chataverage.Click += new System.EventHandler(this.chart1_Click);
            // 
            // seasonsDataGridView
            // 
            this.seasonsDataGridView.AutoGenerateColumns = false;
            this.seasonsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seasonsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.seasonsDataGridView.DataSource = this.seasonsBindingSource;
            this.seasonsDataGridView.Location = new System.Drawing.Point(699, 15);
            this.seasonsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.seasonsDataGridView.Name = "seasonsDataGridView";
            this.seasonsDataGridView.Size = new System.Drawing.Size(577, 455);
            this.seasonsDataGridView.TabIndex = 11;
            this.seasonsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seasonsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cropid";
            this.dataGridViewTextBoxColumn1.HeaderText = "cropid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "crop_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "crop_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "period_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "period_type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "period_number";
            this.dataGridViewTextBoxColumn4.HeaderText = "period_number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "average_yield";
            this.dataGridViewTextBoxColumn5.HeaderText = "average_yield";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1313, 524);
            this.Controls.Add(this.seasonsDataGridView);
            this.Controls.Add(this.chataverage);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agricDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chataverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void lblperiodNumber_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private WindowsFormsApplication1.agricDataSet agricDataSet;
        private System.Windows.Forms.BindingSource seasonsBindingSource;
        private WindowsFormsApplication1.agricDataSetTableAdapters.seasonsTableAdapter seasonsTableAdapter;
        private WindowsFormsApplication1.agricDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtcropId;
        private System.Windows.Forms.ComboBox cmbcropName;
        private System.Windows.Forms.ComboBox cmbperiodType;
        private System.Windows.Forms.TextBox txtperiodNumber;
        private System.Windows.Forms.TextBox txtaverageYield;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnvisualize;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chataverage;
        private System.Windows.Forms.Label lblperiodNumber;
        private System.Windows.Forms.DataGridView seasonsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnaddNew;
        private System.Windows.Forms.Button btndelete;

    }
}

