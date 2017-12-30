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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            addcolomn("g");
            addcolomn("p");
            addcolomn("v");
            addcolomn("ri");
            addcolomn("v建议");
            addcolomn("TTS");
            addcolomn("TID");

        }

        private void addcolomn(string hder)//在dataGridView控件中添加列，hder为列名
        {
            DataGridViewTextBoxColumn cn = new DataGridViewTextBoxColumn();//定义cn为新的一列，然后设置新列的列名和宽度，然后加入控件        
            cn.HeaderText=hder;
            cn.Width=dataGridView1.Width/7;
            dataGridView1.Columns.Add(cn);
        }

        private void addrow()//在控件在添加行
        {
            DataGridViewRow rn = new DataGridViewRow();
            dataGridView1.Rows.Add(rn);
        }
    }
}
