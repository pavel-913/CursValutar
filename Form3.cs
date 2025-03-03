using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CursValutar
{
    public partial class Form3 : Form
    {

        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;

        string connectionString = "Data Source = PAVEL\\SQLEXPRESS; Initial Catalog = MAIB; Integrated Security = True";

        public Form3()
        {
            InitializeDatabaseConnection();
            InitializeComponent();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Data Source = PAVEL\\SQLEXPRESS; Initial Catalog = MAIB; Integrated Security = True";
            connection = new SqlConnection(connectionString);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            var objChart = chart.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 12;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            objChart.AxisY.Maximum = 25;

            chart.Series.Clear();
            chart.Series.Add("Euro");

            chart.Series["Euro"].Color = Color.Red;
            chart.Series["Euro"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT ValueCurs FROM Cursuri WHERE TypeCurs = 'Euro'", connection);
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        int i = 12;
                        while (dr.Read())
                        {
                            chart.Series["Euro"].Points.AddXY(i, Convert.ToDouble(dr[0]));
                            i--;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            chart.Series.Add("USD");

            chart.Series["USD"].Color = Color.Blue;
            chart.Series["USD"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT ValueCurs FROM Cursuri WHERE TypeCurs = 'USD'", connection);
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        int i = 12;
                        while (dr.Read())
                        {
                            chart.Series["USD"].Points.AddXY(i, Convert.ToDouble(dr[0]));
                            i--;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            chart.Series.Add("RON");

            chart.Series["RON"].Color = Color.Yellow;
            chart.Series["RON"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT ValueCurs FROM Cursuri WHERE TypeCurs = 'RON'", connection);
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        int i = 12;
                        while (dr.Read())
                        {
                            chart.Series["RON"].Points.AddXY(i, Convert.ToDouble(dr[0]));
                            i--;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            chart.Series.Add("GBP");

            chart.Series["GBP"].Color = Color.Green;
            chart.Series["GBP"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT ValueCurs FROM Cursuri WHERE TypeCurs = 'GBP'", connection);
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        int i = 12;
                        while (dr.Read())
                        {
                            chart.Series["GBP"].Points.AddXY(i, Convert.ToDouble(dr[0]));
                            i--;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
