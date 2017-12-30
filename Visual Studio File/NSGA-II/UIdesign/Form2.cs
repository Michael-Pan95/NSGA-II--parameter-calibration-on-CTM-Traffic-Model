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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //初始化每个左侧groupbox状态
            model1_rb.Checked = true;
            algorithm1_rb.Checked = true;
            roadnet1_rb.Checked = true;
            GenOpt_rb_1.Checked = true;
            ConOpt_rb_1.Checked = true;
        }
        


        //获取每个groupbox的选中项并输出
        private void Run_btn_Click(object sender, EventArgs e)
        {
            string model_text = getRadiobuttonText(Model_gb.Controls);
            string algorithm_text = getRadiobuttonText(Algorithm_gb.Controls);
            string roadnet_text = getRadiobuttonText(Roadnet_gb.Controls);
            string algorithm_name;
            if(algorithm1_rb.Checked)
            {
                algorithm_name = getRadiobuttonText(Opt_gb.Controls);
            }
            else
            {
                algorithm_name = getRadiobuttonText(Con_Opt_gb.Controls);
            }
            
            Form3 f3 = new Form3(algorithm_text, algorithm_name);
            f3.Show();
            this.Hide();
        }


        //获取组件中激活的radiobutton的text
        private string getRadiobuttonText(Control.ControlCollection controlcollection)
        {
            foreach(var item in controlcollection)
            {
                if(item is RadioButton)
                {
                    RadioButton radiobutton = item as RadioButton;
                    if (radiobutton.Checked)
                    {
                        return radiobutton.Text;
                    }
                }
            }
            return null;
        }

        //当算法选择改变时，控制Opt&Con_Opt groupbox
        private void algorithm1_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (algorithm1_rb.Checked)
            {
                Opt_gb.Enabled = true;
                Con_Opt_gb.Enabled = false;
            }
            else
            {
                Opt_gb.Enabled = false;
                Con_Opt_gb.Enabled = true;
            }
        }
    }
}
