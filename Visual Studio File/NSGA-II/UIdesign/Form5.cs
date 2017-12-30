using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIdesign
{
    public partial class Form5 : Form
    {
        private int static_Seq_No = 0;
        private int dynamic_Seq_No = 1;
        private int real_Seq_No = 2;
        private int GA_Seq_No = 3;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Name = "Static";
            chart1.Series.Add("Dynamic");
            chart1.Series.Add("Real Data");
            chart1.Series.Add("GA");

            Initialize_Chart();
        }

        //这个是作为更改数据的方式，同时配合checkchange来一同控制数据显示
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {

            DataTable dt_static = null;
            DataTable dt_dynamic = null;
            DataTable dt_real = null;
            DataTable dt_GA = null;

            if (source_flow.Checked)
            {
                dt_static = CsvControl.OpenCSV("D:\\flow_dataNSGA-II_优化.csv");
                dt_dynamic = CsvControl.OpenCSV("D:\\dynamic flow_data余1_优化.csv");
                dt_real = CsvControl.OpenCSV("D:\\real flow_data.csv");
                dt_GA = CsvControl.OpenCSV("D:\\flow_dataGA.csv");
            }
            else if (source_speed.Checked)
            {
                dt_static = CsvControl.OpenCSV("D:\\speed_dataNSGA-II_优化.csv");
                dt_dynamic = CsvControl.OpenCSV("D:\\dynamic speed_data余1_优化.csv");
                dt_real = CsvControl.OpenCSV("D:\\real speed_data.csv");
                dt_GA = CsvControl.OpenCSV("D:\\speed_dataGA.csv");
            }
            else if (source_density.Checked)
            {
                dt_static = CsvControl.OpenCSV("D:\\density_dataNSGA-II_优化.csv");
                dt_dynamic = CsvControl.OpenCSV("D:\\dynamic density_data余1_优化.csv");
                dt_real = CsvControl.OpenCSV("D:\\real density_data.csv");
                dt_GA = CsvControl.OpenCSV("D:\\density_dataGA.csv");
            }


            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();


            if (mode1.Checked)
            {
                NoOfData.Text = "第 "+hScrollBar1.Value.ToString() + " 组数据";


                if (static_checkbox.Checked)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        chart1.Series[static_Seq_No].Points.AddXY(i+1, dt_static.Rows[hScrollBar1.Value-1][i]);
                    }
                }

                if (dynamic_checkbox.Checked)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        chart1.Series[dynamic_Seq_No].Points.AddXY(i + 1, dt_dynamic.Rows[hScrollBar1.Value - 1][i]);
                    }
                }

                if (real_checkbox.Checked)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        chart1.Series[real_Seq_No].Points.AddXY(i + 1, dt_real.Rows[hScrollBar1.Value -1 + 180*6][i]);
                    }
                }

                if (GA_checkbox.Checked)
                {
                    for(int i = 0; i < 12; i++)
                    {
                        chart1.Series[GA_Seq_No].Points.AddXY(i + 1, dt_GA.Rows[hScrollBar1.Value - 1][i]);
                    }
                }


            }else if (mode2.Checked)
            {
                NoOfData.Text = "第 " + hScrollBar1.Value.ToString() + " 列数据";

                if (static_checkbox.Checked)
                {
                    for (int i = 0; i < dt_static.Rows.Count; i++)
                    {
                        chart1.Series[static_Seq_No].Points.AddXY(i + 1, dt_static.Rows[i][hScrollBar1.Value - 1]);
                    }
                }

                if (dynamic_checkbox.Checked)
                {
                    for (int i = 0; i < dt_dynamic.Rows.Count; i++)
                    {
                        chart1.Series[dynamic_Seq_No].Points.AddXY(i + 1, dt_dynamic.Rows[i][hScrollBar1.Value - 1]);
                    }
                }

                if (real_checkbox.Checked)
                {
                    for (int i = 0; i < dt_static.Rows.Count; i++)
                    {
                        chart1.Series[real_Seq_No].Points.AddXY(i + 1, dt_real.Rows[i + 180 * 6 + 1][hScrollBar1.Value - 1]);
                    }
                    
                }

                if (GA_checkbox.Checked)
                {
                    for(int i = 0; i < dt_GA.Rows.Count; i++)
                    {
                        chart1.Series[GA_Seq_No].Points.AddXY(i + 1, dt_GA.Rows[i][hScrollBar1.Value - 1]);
                    }
                }
               
            }
            
        }


        //控制显示哪一条线条的方法的一部分，配合valuechange使用
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            hScrollBar1_ValueChanged(null, null);
            #region Legends控制
            ////static
            //if (static_checkbox.Checked)
            //{
            //    if (!chart1.Series.Contains(chart1.Series.FindByName("Static")))
            //    {
            //        chart1.Series.Add("Static");
            //    }
            //}
            //else
            //{
            //    chart1.Series.Remove(chart1.Series.FindByName("Static"));
            //    Seq_No_Update(0);
            //}
            ////dynamic
            //if (dynamic_checkbox.Checked)
            //{
            //    if (!chart1.Series.Contains(chart1.Series.FindByName("Dynamic")))
            //    {
            //        chart1.Series.Add("Dynamic");
            //    }
            //}
            //else
            //{
            //    chart1.Series.Remove(chart1.Series.FindByName("Dynamic"));
            //    Seq_No_Update(1);
            //}
            ////real
            //if (real_checkbox.Checked)
            //{
            //    if (!chart1.Series.Contains(chart1.Series.FindByName("Real")))
            //    {
            //        chart1.Series.Add("Real");
            //    }
            //}
            //else
            //{
            //    chart1.Series.Remove(chart1.Series.FindByName("Real"));
            //    Seq_No_Update(2);
            //}
            ////GA
            //if (GA_checkbox.Checked)
            //{
            //    if (!chart1.Series.Contains(chart1.Series.FindByName("GA")))
            //    {
            //        chart1.Series.Add("GA");
            //    }
            //}
            //else
            //{
            //    chart1.Series.Remove(chart1.Series.FindByName("GA"));
            //    Seq_No_Update(3);
            //}
            #endregion

        }

        //控制通过时刻点显示结果还是通过全局模拟时间来看结果，配合valuechange使用
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Initialize_Chart();
            hScrollBar1_ValueChanged(null, null);
        }

        //每次改变需要对chart重新初始化
        private void Initialize_Chart()
        {
            //初始值的设定
            chart1.Series[0].Color = Color.Red;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].Color = Color.Blue;
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[2].Color = Color.Black;
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[3].Color = Color.Green;
            chart1.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            DataTable dt_static = null;
            DataTable dt_dynamic = null;
            DataTable dt_real = null;
            DataTable dt_GA = null;
            if (source_flow.Checked)
            {
                dt_static = CsvControl.OpenCSV("D:\\flow_dataNSGA-II_优化.csv");
                dt_dynamic = CsvControl.OpenCSV("D:\\dynamic flow_data余1_优化.csv");
                dt_real = CsvControl.OpenCSV("D:\\real flow_data.csv");
                dt_GA = CsvControl.OpenCSV("D:\\flow_dataGA.csv");
            }
            else if (source_speed.Checked)
            {
                dt_static = CsvControl.OpenCSV("D:\\speed_dataNSGA-II_优化.csv");
                dt_dynamic = CsvControl.OpenCSV("D:\\dynamic speed_data余1_优化.csv");
                dt_real = CsvControl.OpenCSV("D:\\real speed_data.csv");
                dt_GA = CsvControl.OpenCSV("D:\\speed_dataGA.csv");
            }
            else if (source_density.Checked)
            {
                dt_static = CsvControl.OpenCSV("D:\\density_dataNSGA-II_优化.csv");
                dt_dynamic = CsvControl.OpenCSV("D:\\dynamic density_data余1_优化.csv");
                dt_real = CsvControl.OpenCSV("D:\\real density_data.csv");
                dt_GA = CsvControl.OpenCSV("D:\\density_dataGA.csv");
            }



            //如果是按照时刻点来比较效果
            if (mode1.Checked)
            {
                chart1.ChartAreas[0].AxisX.Minimum = 1;
                chart1.ChartAreas[0].AxisX.Maximum = 12;
                hScrollBar1.Maximum = dt_static.Rows.Count;
                hScrollBar1.Minimum = 1;
                hScrollBar1.Value = 1;
                NoOfData.Text = "第 1 组数据";

                if (static_checkbox.Checked)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        chart1.Series[0].Points.AddXY(j + 1, dt_static.Rows[hScrollBar1.Value - 1][j]);
                    }
                }

                if (dynamic_checkbox.Checked)
                {
                    for (int i = 0; i < 12; i++)
                    {
                         chart1.Series[1].Points.AddXY(i + 1, dt_dynamic.Rows[hScrollBar1.Value - 1][i]);
                    }
                }
                
                if(real_checkbox.Checked)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        chart1.Series[2].Points.AddXY(i + 1, dt_real.Rows[hScrollBar1.Value - 1 + 180 * 6+1][i]);
                    }
                }

                if (GA_checkbox.Checked)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        chart1.Series[3].Points.AddXY(i + 1, dt_GA.Rows[hScrollBar1.Value - 1][i]);
                    }
                }
            }

            //如果是按照全部模拟时间来比较
            if (mode2.Checked)
            {
                chart1.ChartAreas[0].AxisX.Minimum = 1;
                chart1.ChartAreas[0].AxisX.Maximum = dt_static.Rows.Count;
                hScrollBar1.Maximum = dt_static.Columns.Count;
                hScrollBar1.Minimum = 1;
                hScrollBar1.Value = 1;
                NoOfData.Text = "第 1 车道";
                if (static_checkbox.Checked)
                {
                    for (int i = 0; i < dt_static.Rows.Count; i++)
                    {
                        chart1.Series[0].Points.AddXY(i + 1, dt_static.Rows[i][hScrollBar1.Value-1]);
                    }
                }

                if (static_checkbox.Checked)
                {
                    for (int i = 0; i < dt_static.Rows.Count; i++)
                    {
                        chart1.Series[1].Points.AddXY(i + 1, dt_dynamic.Rows[i][hScrollBar1.Value - 1]);
                    }
                }

                if (real_checkbox.Checked)
                {
                    for (int i = 0; i < dt_static.Rows.Count; i++)
                    {
                        chart1.Series[2].Points.AddXY(i + 1, dt_real.Rows[i+180*6+1][hScrollBar1.Value - 1]);
                    }
                }

                if (GA_checkbox.Checked)
                {
                    for (int i = 0; i < dt_GA.Rows.Count; i++)
                    {
                        chart1.Series[3].Points.AddXY(i + 1, dt_GA.Rows[i][hScrollBar1.Value - 1]);
                    }
                }
            }
        }

        private void source_flow_CheckedChanged(object sender, EventArgs e)
        {
            Initialize_Chart();
            hScrollBar1_ValueChanged(null, null);
        }
        
        //为了改变legend时候，依旧能按顺序读取文件
        private void Seq_No_Update(int no)
        {
            int[] temp = new int[] { static_Seq_No, dynamic_Seq_No, real_Seq_No, GA_Seq_No };
            for(int i = 0; i < 4; i++)
            {
                if (temp[i] > temp[no])
                {
                    temp[i] -= 1;
                }
            }
            temp[no] = 4;
            static_Seq_No = temp[0];
            dynamic_Seq_No = temp[1];
            real_Seq_No = temp[2];
            GA_Seq_No = temp[3];
        }
    }
}
