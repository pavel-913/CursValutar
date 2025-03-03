namespace CursValutar
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mAIBDataSet = new CursValutar.MAIBDataSet();
            this.cursuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursuriTableAdapter = new CursValutar.MAIBDataSetTableAdapters.CursuriTableAdapter();
            this.loadBtn = new System.Windows.Forms.Button();
            this.historyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.historyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAIBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursuriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(40, 33);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(712, 350);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // mAIBDataSet
            // 
            this.mAIBDataSet.DataSetName = "MAIBDataSet";
            this.mAIBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursuriBindingSource
            // 
            this.cursuriBindingSource.DataMember = "Cursuri";
            this.cursuriBindingSource.DataSource = this.mAIBDataSet;
            // 
            // cursuriTableAdapter
            // 
            this.cursuriTableAdapter.ClearBeforeFill = true;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(702, 409);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(86, 29);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // historyBindingSource2
            // 
            this.historyBindingSource2.DataSource = typeof(CursValutar.History);
            // 
            // historyBindingSource1
            // 
            this.historyBindingSource1.DataSource = typeof(CursValutar.History);
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataSource = typeof(CursValutar.History);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.chart);
            this.Name = "Form3";
            this.Text = "Istoric Curs";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAIBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursuriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private MAIBDataSet mAIBDataSet;
        private System.Windows.Forms.BindingSource cursuriBindingSource;
        private MAIBDataSetTableAdapters.CursuriTableAdapter cursuriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private System.Windows.Forms.BindingSource historyBindingSource1;
        private System.Windows.Forms.BindingSource historyBindingSource2;
        private System.Windows.Forms.Button loadBtn;
    }
}