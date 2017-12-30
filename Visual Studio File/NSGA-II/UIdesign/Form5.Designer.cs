namespace UIdesign
{
    partial class Form5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.NoOfData = new System.Windows.Forms.Label();
            this.static_checkbox = new System.Windows.Forms.CheckBox();
            this.dynamic_checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mode2 = new System.Windows.Forms.RadioButton();
            this.mode1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.source_density = new System.Windows.Forms.RadioButton();
            this.source_speed = new System.Windows.Forms.RadioButton();
            this.source_flow = new System.Windows.Forms.RadioButton();
            this.real_checkbox = new System.Windows.Forms.CheckBox();
            this.GA_checkbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Static";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1202, 633);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(1246, 271);
            this.hScrollBar1.Maximum = 1080;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(163, 22);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // NoOfData
            // 
            this.NoOfData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoOfData.AutoSize = true;
            this.NoOfData.Location = new System.Drawing.Point(1220, 239);
            this.NoOfData.Name = "NoOfData";
            this.NoOfData.Size = new System.Drawing.Size(75, 15);
            this.NoOfData.TabIndex = 2;
            this.NoOfData.Text = "第N组数据";
            // 
            // static_checkbox
            // 
            this.static_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.static_checkbox.AutoSize = true;
            this.static_checkbox.Checked = true;
            this.static_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.static_checkbox.Location = new System.Drawing.Point(1249, 492);
            this.static_checkbox.Name = "static_checkbox";
            this.static_checkbox.Size = new System.Drawing.Size(77, 19);
            this.static_checkbox.TabIndex = 3;
            this.static_checkbox.Text = "static";
            this.static_checkbox.UseVisualStyleBackColor = true;
            this.static_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // dynamic_checkbox
            // 
            this.dynamic_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dynamic_checkbox.AutoSize = true;
            this.dynamic_checkbox.Checked = true;
            this.dynamic_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dynamic_checkbox.Location = new System.Drawing.Point(1249, 534);
            this.dynamic_checkbox.Name = "dynamic_checkbox";
            this.dynamic_checkbox.Size = new System.Drawing.Size(85, 19);
            this.dynamic_checkbox.TabIndex = 4;
            this.dynamic_checkbox.Text = "dynamic";
            this.dynamic_checkbox.UseVisualStyleBackColor = true;
            this.dynamic_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mode2);
            this.groupBox1.Controls.Add(this.mode1);
            this.groupBox1.Location = new System.Drawing.Point(1223, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像展示方法";
            // 
            // mode2
            // 
            this.mode2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mode2.AutoSize = true;
            this.mode2.Location = new System.Drawing.Point(26, 63);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(118, 19);
            this.mode2.TabIndex = 1;
            this.mode2.Text = "全局车道比较";
            this.mode2.UseVisualStyleBackColor = true;
            this.mode2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // mode1
            // 
            this.mode1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mode1.AutoSize = true;
            this.mode1.Checked = true;
            this.mode1.Location = new System.Drawing.Point(26, 25);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(73, 19);
            this.mode1.TabIndex = 0;
            this.mode1.TabStop = true;
            this.mode1.Text = "时刻点";
            this.mode1.UseVisualStyleBackColor = true;
            this.mode1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.source_density);
            this.groupBox2.Controls.Add(this.source_speed);
            this.groupBox2.Controls.Add(this.source_flow);
            this.groupBox2.Location = new System.Drawing.Point(1216, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 156);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据选择";
            // 
            // source_density
            // 
            this.source_density.AutoSize = true;
            this.source_density.Location = new System.Drawing.Point(23, 114);
            this.source_density.Name = "source_density";
            this.source_density.Size = new System.Drawing.Size(58, 19);
            this.source_density.TabIndex = 0;
            this.source_density.Text = "密度";
            this.source_density.UseVisualStyleBackColor = true;
            this.source_density.CheckedChanged += new System.EventHandler(this.source_flow_CheckedChanged);
            // 
            // source_speed
            // 
            this.source_speed.AutoSize = true;
            this.source_speed.Location = new System.Drawing.Point(23, 75);
            this.source_speed.Name = "source_speed";
            this.source_speed.Size = new System.Drawing.Size(58, 19);
            this.source_speed.TabIndex = 0;
            this.source_speed.Text = "速度";
            this.source_speed.UseVisualStyleBackColor = true;
            this.source_speed.CheckedChanged += new System.EventHandler(this.source_flow_CheckedChanged);
            // 
            // source_flow
            // 
            this.source_flow.AutoSize = true;
            this.source_flow.Checked = true;
            this.source_flow.Location = new System.Drawing.Point(23, 35);
            this.source_flow.Name = "source_flow";
            this.source_flow.Size = new System.Drawing.Size(58, 19);
            this.source_flow.TabIndex = 0;
            this.source_flow.TabStop = true;
            this.source_flow.Text = "流量";
            this.source_flow.UseVisualStyleBackColor = true;
            this.source_flow.CheckedChanged += new System.EventHandler(this.source_flow_CheckedChanged);
            // 
            // real_checkbox
            // 
            this.real_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.real_checkbox.AutoSize = true;
            this.real_checkbox.Checked = true;
            this.real_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.real_checkbox.Location = new System.Drawing.Point(1249, 571);
            this.real_checkbox.Name = "real_checkbox";
            this.real_checkbox.Size = new System.Drawing.Size(61, 19);
            this.real_checkbox.TabIndex = 4;
            this.real_checkbox.Text = "real";
            this.real_checkbox.UseVisualStyleBackColor = true;
            this.real_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // GA_checkbox
            // 
            this.GA_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GA_checkbox.AutoSize = true;
            this.GA_checkbox.Checked = true;
            this.GA_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GA_checkbox.Location = new System.Drawing.Point(1249, 607);
            this.GA_checkbox.Name = "GA_checkbox";
            this.GA_checkbox.Size = new System.Drawing.Size(45, 19);
            this.GA_checkbox.TabIndex = 4;
            this.GA_checkbox.Text = "GA";
            this.GA_checkbox.UseVisualStyleBackColor = true;
            this.GA_checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GA_checkbox);
            this.Controls.Add(this.real_checkbox);
            this.Controls.Add(this.dynamic_checkbox);
            this.Controls.Add(this.static_checkbox);
            this.Controls.Add(this.NoOfData);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.chart1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label NoOfData;
        private System.Windows.Forms.CheckBox static_checkbox;
        private System.Windows.Forms.CheckBox dynamic_checkbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mode2;
        private System.Windows.Forms.RadioButton mode1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton source_density;
        private System.Windows.Forms.RadioButton source_speed;
        private System.Windows.Forms.RadioButton source_flow;
        private System.Windows.Forms.CheckBox real_checkbox;
        private System.Windows.Forms.CheckBox GA_checkbox;
    }
}