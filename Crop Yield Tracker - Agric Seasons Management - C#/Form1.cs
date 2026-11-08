using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace FinalAgricRec
{
    public partial class Form1 : Form
    {
        public string cropName;
        public string periodType;
        public List<string> periodNumber = new List<string>();
        public List<double> data = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void seasonsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seasonsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agricDataSet);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cropidLabel_Click(object sender, EventArgs e)
        {

        }

        private void crop_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void period_typeLabel_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agricDataSet.seasons' table. You can move, or remove it, as needed.
            this.seasonsTableAdapter.Fill(this.agricDataSet.seasons);
            seasonsDataGridView.Columns[0].HeaderText = "CROP ID";
            seasonsDataGridView.Columns[1].HeaderText = "CROP NAME";
            seasonsDataGridView.Columns[2].HeaderText = "PERIOD TYPE";
            seasonsDataGridView.Columns[3].HeaderText = "PERIOD NUMBER";
            seasonsDataGridView.Columns[4].HeaderText = "AVERAGE YIELD";
        }

        private void CreateChart2(string[] x, double[] y)
        {
            chataverage.Series[0].LegendText = periodNumber + " record of " + cropName;
            chataverage.Series[0].ChartType = SeriesChartType.Column;
            chataverage.Series[0].IsValueShownAsLabel = true;
            chataverage.Series[0].Points.DataBindXY(x, y);

        }

        private void btnaddInfor_Click(object sender, EventArgs e)
        {
            cropName = cmbcropName.Text;
            periodType = cmbperiodType.Text;

            periodNumber.Add(txtperiodNumber.Text);
            data.Add(Convert.ToInt32(txtaverageYield.Text));
            seasonsBindingSource.EndEdit();
            this.seasonsTableAdapter.Update(this.agricDataSet.seasons);
            txtaverageYield.Clear();
            txtperiodNumber.Clear();
            txtcropId.Clear();

            
        }

        private void btnvisualize_Click(object sender, EventArgs e)
        {
            string[] x = periodNumber.ToArray();
            double[] y = data.ToArray();

            CreateChart2(x, y);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void cmbperiodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbperiodType.Text == "annually")
            {
                lblperiodNumber.Text = "enter the year";
            }

            else if (cmbperiodType.Text == "monthly")
            {
                lblperiodNumber.Text = "Enter Month";
            }

            else
            {
                lblperiodNumber.Text = "Enter Week";
            }

        }

        private void btnaddNew_Click(object sender, EventArgs e)
        {
            var row1 = (DataRowView)seasonsBindingSource.AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            seasonsBindingSource.RemoveCurrent();
            this.seasonsTableAdapter.Update(this.agricDataSet.seasons);

            Console.ReadKey();

        }

        private void seasonsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
