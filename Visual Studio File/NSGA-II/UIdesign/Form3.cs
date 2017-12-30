using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Matlab相关空间
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using NSGA;


namespace UIdesign
{
    public partial class Form3 : Form
    {
        string Al_text;
        string Al_name;//存储从form2传来的算法种类和具体算法名称
        

        TabPage TP = new TabPage();



        public Form3(string Algorithm_text, string Algorithm_name)
        {
            InitializeComponent();
            Al_text = Algorithm_text;
            Al_name = Algorithm_name;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            TP = findandshowtabpage();//找到由form2传来的算法栏目
            addtitle(TP);

            #region nsga_2 潘正宇   此处按照下列格式写入参数数值 读取数据库部分写在button_click事件中

            //NSGA函数参数：nsga_2(pop,gen,density0,input_flow,exit_density1,exit_ratio1,enter_flow1,enter_ratio1,
            //                    enter_flow2,enter_ratio2,output_density,flow_data,speed_data,hours)
            if (Al_name == "NSGA-II" && Al_text == "优化")
            {
                addparameter("Population", 1, TP); //族群数
                addparameter("Generation", 2, TP); //代数
                addparameter("Start_Time", 3, TP);//从第几个小时开始
                addparameter("Hours", 4, TP); //仿真的小时数
            }
            #endregion


        }

        private TabPage findandshowtabpage()//找到由form2传来的算法栏目
        {
            TabPage f = new TabPage();
            foreach (TabPage tp in tabControl1.TabPages)
            {
                if (tp.Text == Al_name)
                    f = tp;
                else
                    tp.Parent = null;
            }
            return f;
        }

        private void addparameter(string para_name,int n,TabPage t)//参数：para_name为算法需要的变量名，n为第几个参数,t为需要添加参数的tabpage
        {
            Label parameter_Name = new Label();
            parameter_Name.Text = para_name;
            parameter_Name.Location = new Point(318,74+(n-1)*40);//2个label之间距离为40

            TextBox parameter_Value = new TextBox();
            parameter_Value.Name = para_name;
            parameter_Value.Location = new Point(430, 71 + (n - 1) * 40);
            parameter_Value.Size = new Size(100,21);
            t.Controls.Add(parameter_Name);
            t.Controls.Add(parameter_Value);
        }

        private void addtitle(TabPage t)//添加左侧4个label栏
        {
            Label algorithm = new Label();
            algorithm.Text = Al_text + "算法";
            algorithm.Location = new Point(55, 75);
            algorithm.AutoSize = true;

            Label al_name = new Label();
            al_name.Text = Al_name + "=";
            al_name.Location = new Point(55, 115);
            al_name.AutoSize = true;

            Label parameter = new Label();
            parameter.Text = "参数级是";
            parameter.Location = new Point(155, 75);
            parameter.AutoSize = true;

            Label al_parameter = new Label();
            al_parameter.Text = Al_text + "参数";
            al_parameter.Location = new Point(155, 115);
            al_parameter.AutoSize = true;

            t.Controls.Add(algorithm);
            t.Controls.Add(al_name);
            t.Controls.Add(parameter);
            t.Controls.Add(al_parameter);
        }

        
        private void Eva_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Eva_btn_Click(sender, e);
            }


        }//回车快捷键控制

        //这里写与数据库交互相关代码，以及写入csv文件代码
        private void Eva_btn_Click(object sender, EventArgs e)
        {

            #region 按照下列格式读取数据库并处理，然后调用自己的matlab方法
            //静态输出的
            if (Al_name == "NSGA-II" && Al_text == "优化")
            {
                string filepath = "";//存储csv路径,静态
                string filepath_d = "";//存储csv路径，动态
                string starttext = ((TextBox)(TP.Controls.Find("Start_Time", true)[0])).Text;
                string hourtext = ((TextBox)(TP.Controls.Find("Hours", true)[0])).Text;
                string poptext = ((TextBox)(TP.Controls.Find("Population", true)[0])).Text;
                string genetext = ((TextBox)(TP.Controls.Find("Generation", true)[0])).Text;

                
                // 下面4个rush都是高峰时间段的设置
                double rushHourStart_am = 7.5;
                double rushHourEnd_am = 9.5;
                double rushHourStart_pm = 16.5;
                double rushHourEnd_pm = 18.5;

                //时间数据
                double hour_T = double.Parse(DateTime.Now.Hour.ToString());
                double min_T = double.Parse(DateTime.Now.Minute.ToString()) / 60;
                double time_T = hour_T + min_T;

                #region  模拟的时间对应filepath和filepath_d           注释部分：现在时间情况判定和修改filepath
                //参数标定的时候还是要根据模拟的时间来确定是否是高峰时间，以便按照对应文件名写入
                
                if (double.Parse(starttext) >= rushHourStart_am && (double.Parse(starttext) + double.Parse(hourtext)) <= rushHourEnd_am)
                {
                     //早高峰情况
                        filepath = "D:\\" + Al_name + " " + Al_text + "_rushhour_am.csv";
                        filepath_d = "D:\\dynamic " + Al_name + " " + Al_text + "_rushhour_am.csv";
                }
                else if (double.Parse(starttext) >= rushHourStart_pm && (double.Parse(starttext) + double.Parse(hourtext)) <= rushHourEnd_pm)
                {
                    //晚高峰情况
                    filepath = "D:\\" + Al_name + "_" + Al_text + "_rushhour_pm.csv";
                    filepath_d = "D:\\dynamic " + Al_name + "_" + Al_text + "_rushhour_pm.csv";
                }
                else
                {
                    filepath = "D:\\" + Al_name + "_" + Al_text + ".csv";
                    filepath_d = "D:\\dynamic " + Al_name + "_" + Al_text + ".csv";
                }

                //为求GA的f1,f2而设立的语句，忽略
                //DataTable gatemp = Nsga_simulation(6, "6", 6, "D:\\ga.csv")[0];


                /*
                

                if (time_T > rushHourStart_am && time_T < rushHourEnd_am)
                {
                    //早高峰

                    filepath = "D:\\" + Al_name + " " + Al_text + "_rushhour_am.csv";
                }
                else if (time_T > rushHourStart_pm && time_T < rushHourEnd_pm)
                {
                    //晚高峰

                    filepath = "D:\\" + Al_name + "_" + Al_text + "_rushhour_pm.csv";
                }
                else
                {
                    //平时情况

                    filepath = "D:\\" + Al_name + "_" + Al_text + ".csv";
                }
                
                */
                #endregion


                #region 获取开始时间和仿真的小时数，没有就变成0
                double start_time = -1;
                if(starttext != "")
                {
                    start_time=double.Parse(starttext);
                }
                else
                {
                    start_time = 0;
                }
                
                double hours = -1;
                if (hourtext != "")
                {
                    hours = double.Parse(hourtext);
                }
                else
                {
                    hours = 0;
                }
                   
               

                int population;
                if(poptext == "")
                {
                     population = 0;
                }
                else
                {
                     population = int.Parse(poptext);
                }
                int generation;
                if(genetext == "")
                {
                    generation = 0;
                }
                else
                {
                    generation = int.Parse(genetext);
                }

                #endregion




                ///两个空值就是表示是数据带入模拟，否则则是参数标定
                if (population==0 && generation==0 && hours >0)
                {

                    DataTable[] temp = Nsga_simulation(start_time, starttext, hours,filepath);
                    DataTable dt_speed_return = temp[0];
                    DataTable dt_flow_return = temp[1];
                    DataTable dt_density_return = temp[2];
                    //写至D盘根目录下，以flow_data.csv 和 speed_data.csv命名
                    filepath = "D:\\speed_data" + Al_name + "_" + Al_text + ".csv";
                    CsvControl.SaveCSV(dt_speed_return, filepath);
                    filepath = "D:\\flow_data" + Al_name + "_" + Al_text + ".csv";
                    CsvControl.SaveCSV(dt_flow_return, filepath);
                    filepath= "D:\\density_data" + Al_name + "_" + Al_text + ".csv";
                    CsvControl.SaveCSV(dt_density_return, filepath);
                }
                else if(hours > 0)
                {
                    //参数标定
                    Nsga_para_deter(start_time,starttext,hours,population,generation,filepath);
                }else if (!File.Exists("D:\\speed_dataGA.csv") && hours ==0)
                {
                    DataTable[] temp = Nsga_simulation(6, "6", 6, "D://ga.csv");
                    DataTable dt_speed_return = temp[0];
                    DataTable dt_flow_return = temp[1];
                    DataTable dt_density_return = temp[2];
                    //写至D盘根目录下，以flow_data.csv 和 speed_data.csv命名
                    filepath = "D:\\speed_dataGA.csv";
                    CsvControl.SaveCSV(dt_speed_return, filepath);
                    filepath = "D:\\flow_dataGA.csv";
                    CsvControl.SaveCSV(dt_flow_return, filepath);
                    filepath = "D:\\density_dataGA.csv";
                    CsvControl.SaveCSV(dt_density_return, filepath);
                }

                
            }

            #endregion

            ///<summary>
            ///起初以平日参数进行计算，随后每半小时进行一次标定并更新模型参数，动静态测试对比时间为早6点到12点
            /// </summary>
            
            if(Al_name == "DNSGA-II" && Al_text == "优化")
            {
                //承载输出结果的两个datatable
                DataTable dt_dynamic_flow_result=new DataTable("dynamic flow result");
                DataTable dt_dynamic_speed_result=new DataTable("dynamic speed result");
                DataTable dt_dynamic_density_result = new DataTable("dynamic density result");
                //读取初次的模拟数据
                string filepath_d = "D:\\dynamic " + Al_name + "_" + Al_text + ".csv";
                DataTable[] temp;
                temp = Nsga_simulation(6, "6", 0.5, filepath_d);
                DataTable results_speed=dt_dynamic_speed_result.Clone();
                DataTable results_flow = dt_dynamic_flow_result.Clone();
                DataTable results_density = dt_dynamic_density_result.Clone();
                string filepath_d_speed = "D:\\dynamic speed_data" + Al_name + "_" + Al_text + ".csv";
                string filepath_d_flow = "D:\\dynamic flow_data" + Al_name + "_" + Al_text + ".csv";
                string filepath_d_density = "D:\\dynamic density_data" + Al_name + "_" + Al_text + ".csv";
                //1.模拟半小时 
                //2.每半小时进行一次标定，
                for (double time=6;time<12;time +=0.5)
                {
                    //temp = Nsga_simulation(time, time.ToString(), 0.5, filepath_d);
                    temp = Nsga_simulation(time-0.5, time.ToString(), 1, filepath_d);
                    //将每一次的计算结果都进行合并
                    dt_dynamic_speed_result = temp[0];
                    dt_dynamic_flow_result = temp[1];
                    dt_dynamic_density_result = temp[2];

                    results_speed.Merge(dt_dynamic_speed_result);
                    results_flow.Merge(dt_dynamic_flow_result);
                    results_density.Merge(dt_dynamic_density_result);

                    Nsga_para_deter(time, time.ToString(), 0.5, 50, 20, filepath_d,true);
                    //MessageBox.Show(time.ToString()+"点已完成");
                }

                CsvControl.SaveCSV(results_flow,filepath_d_flow);
                CsvControl.SaveCSV(results_speed,filepath_d_speed);
                CsvControl.SaveCSV(results_density, filepath_d_density);
            }

            



            //Form4 f4 = new Form4();
            //f4.Show();
            //this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();

        }

        
        //nsga（动态静态）数据库读取用
        private MWNumericArray[] Nsga_database_read(double start_time,string starttext,double hours)
        {
            #region 从数据库获取剩余参数
            //根据每20秒测一次计算出截取数据库开始的时间段和结束的时间段
            string start_temp = (start_time * 180 + 1).ToString();
            string end_temp = (start_time * 180 + 2 * hours * 180).ToString();
            DataTable density0_r = null;
            if (starttext == "0")
            {
                density0_r = DbHelperSQL.Query("select * from Ini_Density");
            }
            else
            {
                density0_r = DbHelperSQL.Query("select * from Real_Density where [No.] = " + (int.Parse(start_temp) - 1).ToString());
            }

            DataTable input_flow_r = DbHelperSQL.Query("select * from MainFlowInput where [No.] between " + start_temp + " and " + end_temp);
            DataTable exit_density1_r = DbHelperSQL.Query("select * from ExitRampDensity where [No.] between " + start_temp + " and " + end_temp);
            DataTable exit_ratio1_r = DbHelperSQL.Query("select * from ExitRampRatio where [No.] between " + start_temp + " and " + end_temp);
            DataTable enter_flow1_r = DbHelperSQL.Query("select * from EnterRampInput1 where [No.] between " + start_temp + " and " + end_temp);
            DataTable enter_ratio1_r = DbHelperSQL.Query("select * from EnterRampRatio1 where [No.] between " + start_temp + " and " + end_temp);
            DataTable enter_flow2_r = DbHelperSQL.Query("select * from EnterRampInput2 where [No.] between " + start_temp + " and " + end_temp);
            DataTable enter_ratio2_r = DbHelperSQL.Query("select * from EnterRampRatio2 where [No.] between " + start_temp + " and " + end_temp);
            DataTable output_density_r = DbHelperSQL.Query("select * from OutputDensity where [No.] between " + start_temp + " and " + end_temp);
            DataTable flow_data_r = DbHelperSQL.Query("select * from Real_Flow where [No.] between " + start_temp + " and " + end_temp);
            DataTable speed_data_r = DbHelperSQL.Query("select * from Real_Speed where [No.] between " + start_temp + " and " + end_temp);
            DataTable density_data_r = DbHelperSQL.Query("select * from Real_Density where [No.] between " + start_temp + " and " + end_temp);

            //处理每个数据
            double[] density0_A = new double[density0_r.Columns.Count - 1];
            double[] input_flow_A = new double[input_flow_r.Rows.Count];
            double[] exit_density1_A = new double[exit_density1_r.Rows.Count];
            double[] exit_ratio1_A = new double[exit_ratio1_r.Rows.Count];
            double[] enter_flow1_A = new double[enter_flow1_r.Rows.Count];
            double[] enter_ratio1_A = new double[enter_ratio1_r.Rows.Count];
            double[] enter_flow2_A = new double[enter_flow2_r.Rows.Count];
            double[] enter_ratio2_A = new double[enter_ratio2_r.Rows.Count];
            double[] output_density_A = new double[output_density_r.Rows.Count];
            double[,] flow_data_A = new double[flow_data_r.Columns.Count - 1, flow_data_r.Rows.Count];
            double[,] speed_data_A = new double[speed_data_r.Columns.Count - 1, speed_data_r.Rows.Count];
            double[,] density_data_A = new double[density_data_r.Rows.Count, density_data_r.Columns.Count - 1];

            for (int i = 1; i < density0_r.Columns.Count; i++)
            {
                density0_A[i - 1] = double.Parse(density0_r.Rows[0][i].ToString());
            }

            for (int i = 0; i < input_flow_r.Rows.Count; i++)
            {
                input_flow_A[i] = double.Parse(input_flow_r.Rows[i][1].ToString());
            }

            for (int i = 0; i < exit_density1_r.Rows.Count; i++)
            {
                exit_density1_A[i] = double.Parse(exit_density1_r.Rows[i][1].ToString());
            }

            for (int i = 0; i < exit_ratio1_r.Rows.Count; i++)
            {
                exit_ratio1_A[i] = double.Parse(exit_ratio1_r.Rows[i][1].ToString());
            }

            for (int i = 0; i < enter_flow1_r.Rows.Count; i++)
            {
                enter_flow1_A[i] = double.Parse(enter_flow1_r.Rows[i][1].ToString());
            }

            for (int i = 0; i < enter_ratio1_r.Rows.Count; i++)
            {
                enter_ratio1_A[i] = double.Parse(enter_ratio1_r.Rows[i][1].ToString());
            }

            for (int i = 0; i < enter_flow2_r.Rows.Count; i++)
            {
                enter_flow2_A[i] = double.Parse(enter_flow2_r.Rows[i][1].ToString());
            }

            for (int i = 0; i < enter_ratio2_r.Rows.Count; i++)
            {
                enter_ratio2_A[i] = double.Parse(enter_ratio2_r.Rows[i][1].ToString());
            }

            for (int i = 0; i < output_density_r.Rows.Count; i++)
            {
                output_density_A[i] = double.Parse(output_density_r.Rows[i][1].ToString());
            }

            for (int j = 1; j < flow_data_r.Columns.Count; j++)
            {
                for (int i = 0; i < flow_data_r.Rows.Count; i++)
                {
                    flow_data_A[j - 1, i] = double.Parse(flow_data_r.Rows[i][j].ToString());
                }
            }

            for (int j = 1; j < speed_data_r.Columns.Count; j++)
            {
                for (int i = 0; i < speed_data_r.Rows.Count; i++)
                {
                    speed_data_A[j - 1, i] = double.Parse(speed_data_r.Rows[i][j].ToString());
                }
            }

            for (int i = 1; i < density_data_r.Rows.Count; i++)
            {
                for (int j = 1; j < density_data_r.Columns.Count - 1; j++)
                {
                    density_data_A[i, j] = double.Parse(density_data_r.Rows[i][j].ToString());
                }
            }

            //Matlab类型的变量定义
            MWNumericArray density0 = density0_A;
            MWNumericArray input_flow = input_flow_A;
            MWNumericArray exit_density1 = exit_density1_A;
            MWNumericArray exit_ratio1 = exit_ratio1_A;
            MWNumericArray enter_flow1 = enter_flow1_A;
            MWNumericArray enter_ratio1 = enter_ratio1_A;
            MWNumericArray enter_flow2 = enter_flow2_A;
            MWNumericArray enter_ratio2 = enter_ratio2_A;
            MWNumericArray output_density = output_density_A;
            MWNumericArray flow_data = flow_data_A;
            MWNumericArray speed_data = speed_data_A;
            #endregion

            MWNumericArray[] data ={density0, input_flow, exit_density1, exit_ratio1, enter_flow1,
                enter_ratio1,enter_flow2,enter_ratio2,output_density,flow_data,speed_data};

            return data;
        }

        //参数标定并写入csv文件
        private void Nsga_para_deter(double start_time,string starttext,double hours, int population,int generation,string filepath, bool elit=false)
        {
            #region 参数标定，并将标定的值写入文件
            //计算6个参数以及4个变量
            MWNumericArray[] database_database = Nsga_database_read(start_time, starttext, hours);

            NSGA.NSGA_Class nsga = new NSGA_Class();
            MWArray[] result;
            if(elit)//如果有精英参数，则调用含有varargin的nsga函数
            {
                //获取精英参数进行插队
                DataTable read_data = CsvControl.OpenCSV(filepath);
                double[] result_data = new double[6];
                for (int i = 0; i < 6; i++)//只需要前6个参数
                {

                    result_data[i] = double.Parse(read_data.Rows[0][i].ToString());
                }

                result = nsga.nsga_2(1, population, generation, database_database[0],
                    database_database[1], database_database[2], database_database[3], database_database[4],
                    database_database[5], database_database[6], database_database[7], database_database[8],
                    database_database[9], database_database[10], hours, result_data[0], result_data[1], result_data[2],
                    result_data[3], result_data[4], result_data[5]);
            }
            else
            {
                
                result = nsga.nsga_2(1, population, generation, database_database[0],
                    database_database[1], database_database[2], database_database[3], database_database[4],
                    database_database[5], database_database[6], database_database[7], database_database[8],
                    database_database[9], database_database[10], hours);
            }
            
            double[] para = new double[result[0].Dimensions[1]];
            for (int row = 0; row < result[0].Dimensions[1]; row++)
            {
                //避免出现无穷值导致程序出错（出现在crowding dis中）,将无穷的值转换成-1
                if (result[0][1, row + 1].ToString() == "Inf")
                {
                    para[row] = -1;
                    continue;
                }
                para[row] = double.Parse(result[0][1, row + 1].ToString());
            }
            string sql_combination = "'" + DateTime.Now.ToString() + "'";

            foreach (double p in para)
            {
                sql_combination += "," + ((decimal)p).ToString("G");
            }
            sql_combination = "Insert Into Para_6 Values(" + sql_combination + ")";
            DbHelperSQL.ExucuteSql(sql_combination);
            #endregion

            #region 将6个参数 +4个相关参量写到csv
            DataTable dt = new DataTable("NSGA-II");
            dt.Columns.Add("X1", typeof(Double));
            dt.Columns.Add("X2", typeof(Double));
            dt.Columns.Add("X3", typeof(Double));
            dt.Columns.Add("X4", typeof(Double));
            dt.Columns.Add("X5", typeof(Double));
            dt.Columns.Add("X6", typeof(Double));
            dt.Columns.Add("f1", typeof(Double));
            dt.Columns.Add("f2", typeof(Double));
            dt.Columns.Add("Rank", typeof(int));
            dt.Columns.Add("CrowdingDistance", typeof(Double));

            dt.Rows.Add(para[0], para[1], para[2], para[3], para[4], para[5], para[6], para[7], para[8], para[9]);

            if (elit)
            {
                DataTable read_data = CsvControl.OpenCSV(filepath);
                DataTable combination = new DataTable("combination");
                combination = dt.Clone();
                for(int i = 0; i < read_data.Rows.Count; i++)
                {

                    if (read_data.Rows[i][9].ToString() != "Inf")
                    {
                        combination.Rows.Add(double.Parse(read_data.Rows[i][0].ToString()), double.Parse(read_data.Rows[i][1].ToString()), double.Parse(read_data.Rows[i][2].ToString()),
                        double.Parse(read_data.Rows[i][3].ToString()), double.Parse(read_data.Rows[i][4].ToString()), double.Parse(read_data.Rows[i][5].ToString()), double.Parse(read_data.Rows[i][6].ToString()),
                        double.Parse(read_data.Rows[i][7].ToString()), double.Parse(read_data.Rows[i][8].ToString()), double.Parse(read_data.Rows[i][9].ToString()));
                    }
                    else
                    {
                        combination.Rows.Add(double.Parse(read_data.Rows[i][0].ToString()), double.Parse(read_data.Rows[i][1].ToString()), double.Parse(read_data.Rows[i][2].ToString()),
                        double.Parse(read_data.Rows[i][3].ToString()), double.Parse(read_data.Rows[i][4].ToString()), double.Parse(read_data.Rows[i][5].ToString()), double.Parse(read_data.Rows[i][6].ToString()),
                        double.Parse(read_data.Rows[i][7].ToString()), double.Parse(read_data.Rows[i][8].ToString()), -1);
                    }
                }
                dt.Merge(combination);
            }
            
            CsvControl.SaveCSV(dt, filepath);
            #endregion
        }

        //nsga(动态静态）仿真,返回0，speed,返回1，flow
        private DataTable[] Nsga_simulation(double start_time,string starttext,double hours,string filepath)
        {
            #region 将参数代回模型，计算得到模拟的速度和流量的量，下一步通过matlab处理（理由：Matlab处理更方便）
            NSGA.NSGA_Class nsga = new NSGA_Class();

            DataTable read_data = CsvControl.OpenCSV(filepath);
            double[] result_data = new double[6];
            for (int i = 0; i < 6; i++)//只需要前6个参数
            {

                result_data[i] = double.Parse(read_data.Rows[0][i].ToString());
            }


            //database_data是个包含了11个参数的数组
            MWNumericArray[] database_data = Nsga_database_read(start_time, starttext, hours);
            MWNumericArray result = result_data;

            //这里有个很好玩的彩蛋：mwarray本身可以等于数组，所以这里不用mwarray数组
            //MWArray[] ModelValue = nsga.PI(6, result, density0, input_flow, exit_density1, exit_ratio1, enter_flow1,
            //                 enter_ratio1, enter_flow2, enter_ratio2, output_density,
            //                 flow_data, speed_data, hours);

            MWArray[] ModelValue = nsga.PI(5, result, database_data[0], database_data[1], database_data[2],
                database_data[3], database_data[4], database_data[5], database_data[6], database_data[7],
                database_data[8], database_data[9], database_data[10], hours);

            //
            //为求GA,f1,f2而设立的语句，忽略
            //MWArray ga_f1 = ModelValue[0];
            //MWArray ga_f2 = ModelValue[1];
            //double sum_f1=0;
            //double sum_f2=0;
            //for(int i = 0;i<ga_f1.Dimensions[0];i++)
            //{
            //    for(int j = 0; j < ga_f1.Dimensions[1]; j++)
            //    {
            //        sum_f1 += double.Parse(ga_f1[i+1,j+1].ToString());
            //        sum_f2 += double.Parse(ga_f2[i+1,j+1].ToString());
            //    }
            //}
            //MessageBox.Show("f1 = " + sum_f1 + "\nf2 = " + sum_f2);
            //
            //



            MWArray speed_return = ModelValue[2];
            MWArray flow_return = ModelValue[3];
            MWArray density_return = ModelValue[4];

            DataTable dt_speed_return = new DataTable("Speed_Return");
            DataTable dt_flow_return = new DataTable("Flow_Return");
            DataTable dt_density_return = new DataTable("Density_Return");

            //必需先构建一个空的表
            for (int i = 0; i < speed_return.Dimensions[1]; i++)
            {
                dt_speed_return.Rows.Add();

            }

            for (int j = 0; j < speed_return.Dimensions[0]; j++)
            {
                dt_speed_return.Columns.Add();
            }


            for (int i = 0; i < flow_return.Dimensions[1]; i++)
            {
                dt_flow_return.Rows.Add();
            }

            for (int j = 0; j < flow_return.Dimensions[0]; j++)
            {
                dt_flow_return.Columns.Add();
            }

            for (int i = 0; i < density_return.Dimensions[1]; i++)
            {
                dt_density_return.Rows.Add();

            }

            for (int j = 0; j < speed_return.Dimensions[0]; j++)
            {
                dt_density_return.Columns.Add();
            }

            //这里开始赋值
            int rowcount = speed_return.Dimensions[1];
            int columncount = speed_return.Dimensions[0];
            for (int i = 0; i < rowcount; i++)
            {
                for (int j = 0; j < columncount; j++)
                {

                    dt_speed_return.Rows[i][j] = speed_return[j + 1, i + 1];
                }
            }

            rowcount = flow_return.Dimensions[1];
            columncount = flow_return.Dimensions[0];
            for (int i = 0; i < rowcount; i++)
            {
                for (int j = 0; j < columncount; j++)
                {

                    dt_flow_return.Rows[i][j] = flow_return[j + 1, i + 1];
                }
            }

            rowcount = density_return.Dimensions[1];
            columncount = density_return.Dimensions[0];
            for (int i = 0; i < rowcount; i++)
            {

                for (int j = 0; j < columncount; j++)
                {

                    dt_density_return.Rows[i][j] = density_return[j + 1, i + 1];
                }
            }

            DataTable[] returnresult = { dt_speed_return, dt_flow_return,dt_density_return};
            return returnresult;
            #endregion
        }
    }


}
