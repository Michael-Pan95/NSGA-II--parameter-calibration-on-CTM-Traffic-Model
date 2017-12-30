namespace UIdesign
{
    partial class Form2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Model_gb = new System.Windows.Forms.GroupBox();
            this.model2_rb = new System.Windows.Forms.RadioButton();
            this.model1_rb = new System.Windows.Forms.RadioButton();
            this.Algorithm_gb = new System.Windows.Forms.GroupBox();
            this.algorithm2_rb = new System.Windows.Forms.RadioButton();
            this.algorithm1_rb = new System.Windows.Forms.RadioButton();
            this.Roadnet_gb = new System.Windows.Forms.GroupBox();
            this.roadnet2_rb = new System.Windows.Forms.RadioButton();
            this.roadnet1_rb = new System.Windows.Forms.RadioButton();
            this.Run_btn = new System.Windows.Forms.Button();
            this.Opt_gb = new System.Windows.Forms.GroupBox();
            this.DMulObj_lb = new System.Windows.Forms.Label();
            this.HDMulObj_lb = new System.Windows.Forms.Label();
            this.GenOpt_lb = new System.Windows.Forms.Label();
            this.GenOpt_rb_4 = new System.Windows.Forms.RadioButton();
            this.HDMuti_rb_3 = new System.Windows.Forms.RadioButton();
            this.HDMuti_rb_2 = new System.Windows.Forms.RadioButton();
            this.DMulti_rb_1 = new System.Windows.Forms.RadioButton();
            this.GenOpt_rb_3 = new System.Windows.Forms.RadioButton();
            this.HDMuti_rb_1 = new System.Windows.Forms.RadioButton();
            this.GenOpt_rb_2 = new System.Windows.Forms.RadioButton();
            this.GenOpt_rb_1 = new System.Windows.Forms.RadioButton();
            this.Con_Opt_gb = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Con_Multi = new System.Windows.Forms.Label();
            this.Con_Vissim = new System.Windows.Forms.Label();
            this.ConOpt_rb_4 = new System.Windows.Forms.RadioButton();
            this.ConMul_rb_3 = new System.Windows.Forms.RadioButton();
            this.ConMul_rb_2 = new System.Windows.Forms.RadioButton();
            this.ConDMul_rb_1 = new System.Windows.Forms.RadioButton();
            this.ConOpt_rb_3 = new System.Windows.Forms.RadioButton();
            this.ConMul_rb_1 = new System.Windows.Forms.RadioButton();
            this.ConOpt_rb_2 = new System.Windows.Forms.RadioButton();
            this.ConOpt_rb_1 = new System.Windows.Forms.RadioButton();
            this.Model_gb.SuspendLayout();
            this.Algorithm_gb.SuspendLayout();
            this.Roadnet_gb.SuspendLayout();
            this.Opt_gb.SuspendLayout();
            this.Con_Opt_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Model_gb
            // 
            this.Model_gb.Controls.Add(this.model2_rb);
            this.Model_gb.Controls.Add(this.model1_rb);
            this.Model_gb.Location = new System.Drawing.Point(12, 12);
            this.Model_gb.Name = "Model_gb";
            this.Model_gb.Size = new System.Drawing.Size(261, 136);
            this.Model_gb.TabIndex = 0;
            this.Model_gb.TabStop = false;
            this.Model_gb.Text = "模型";
            // 
            // model2_rb
            // 
            this.model2_rb.AutoSize = true;
            this.model2_rb.Location = new System.Drawing.Point(27, 85);
            this.model2_rb.Name = "model2_rb";
            this.model2_rb.Size = new System.Drawing.Size(55, 19);
            this.model2_rb.TabIndex = 0;
            this.model2_rb.TabStop = true;
            this.model2_rb.Text = "CTM";
            this.model2_rb.UseVisualStyleBackColor = true;
            // 
            // model1_rb
            // 
            this.model1_rb.AutoSize = true;
            this.model1_rb.Location = new System.Drawing.Point(27, 37);
            this.model1_rb.Name = "model1_rb";
            this.model1_rb.Size = new System.Drawing.Size(91, 19);
            this.model1_rb.TabIndex = 0;
            this.model1_rb.TabStop = true;
            this.model1_rb.Text = "METANET";
            this.model1_rb.UseVisualStyleBackColor = true;
            // 
            // Algorithm_gb
            // 
            this.Algorithm_gb.Controls.Add(this.algorithm2_rb);
            this.Algorithm_gb.Controls.Add(this.algorithm1_rb);
            this.Algorithm_gb.Location = new System.Drawing.Point(12, 154);
            this.Algorithm_gb.Name = "Algorithm_gb";
            this.Algorithm_gb.Size = new System.Drawing.Size(261, 136);
            this.Algorithm_gb.TabIndex = 0;
            this.Algorithm_gb.TabStop = false;
            this.Algorithm_gb.Text = "算法";
            // 
            // algorithm2_rb
            // 
            this.algorithm2_rb.AutoSize = true;
            this.algorithm2_rb.Location = new System.Drawing.Point(27, 89);
            this.algorithm2_rb.Name = "algorithm2_rb";
            this.algorithm2_rb.Size = new System.Drawing.Size(101, 19);
            this.algorithm2_rb.TabIndex = 0;
            this.algorithm2_rb.TabStop = true;
            this.algorithm2_rb.Text = "控制+优化";
            this.algorithm2_rb.UseVisualStyleBackColor = true;
            // 
            // algorithm1_rb
            // 
            this.algorithm1_rb.AutoSize = true;
            this.algorithm1_rb.Location = new System.Drawing.Point(27, 43);
            this.algorithm1_rb.Name = "algorithm1_rb";
            this.algorithm1_rb.Size = new System.Drawing.Size(60, 19);
            this.algorithm1_rb.TabIndex = 0;
            this.algorithm1_rb.TabStop = true;
            this.algorithm1_rb.Text = "优化";
            this.algorithm1_rb.UseVisualStyleBackColor = true;
            this.algorithm1_rb.CheckedChanged += new System.EventHandler(this.algorithm1_rb_CheckedChanged);
            // 
            // Roadnet_gb
            // 
            this.Roadnet_gb.Controls.Add(this.roadnet2_rb);
            this.Roadnet_gb.Controls.Add(this.roadnet1_rb);
            this.Roadnet_gb.Location = new System.Drawing.Point(12, 330);
            this.Roadnet_gb.Name = "Roadnet_gb";
            this.Roadnet_gb.Size = new System.Drawing.Size(261, 142);
            this.Roadnet_gb.TabIndex = 0;
            this.Roadnet_gb.TabStop = false;
            this.Roadnet_gb.Text = "路网";
            // 
            // roadnet2_rb
            // 
            this.roadnet2_rb.AutoSize = true;
            this.roadnet2_rb.Location = new System.Drawing.Point(27, 98);
            this.roadnet2_rb.Name = "roadnet2_rb";
            this.roadnet2_rb.Size = new System.Drawing.Size(92, 19);
            this.roadnet2_rb.TabIndex = 0;
            this.roadnet2_rb.Text = "测试路网";
            this.roadnet2_rb.UseVisualStyleBackColor = true;
            // 
            // roadnet1_rb
            // 
            this.roadnet1_rb.AutoSize = true;
            this.roadnet1_rb.Location = new System.Drawing.Point(27, 43);
            this.roadnet1_rb.Name = "roadnet1_rb";
            this.roadnet1_rb.Size = new System.Drawing.Size(76, 19);
            this.roadnet1_rb.TabIndex = 0;
            this.roadnet1_rb.Text = "广中路";
            this.roadnet1_rb.UseVisualStyleBackColor = true;
            // 
            // Run_btn
            // 
            this.Run_btn.Location = new System.Drawing.Point(39, 508);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(179, 43);
            this.Run_btn.TabIndex = 1;
            this.Run_btn.Text = "运行";
            this.Run_btn.UseVisualStyleBackColor = true;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // Opt_gb
            // 
            this.Opt_gb.Controls.Add(this.DMulObj_lb);
            this.Opt_gb.Controls.Add(this.HDMulObj_lb);
            this.Opt_gb.Controls.Add(this.GenOpt_lb);
            this.Opt_gb.Controls.Add(this.GenOpt_rb_4);
            this.Opt_gb.Controls.Add(this.HDMuti_rb_3);
            this.Opt_gb.Controls.Add(this.HDMuti_rb_2);
            this.Opt_gb.Controls.Add(this.DMulti_rb_1);
            this.Opt_gb.Controls.Add(this.GenOpt_rb_3);
            this.Opt_gb.Controls.Add(this.HDMuti_rb_1);
            this.Opt_gb.Controls.Add(this.GenOpt_rb_2);
            this.Opt_gb.Controls.Add(this.GenOpt_rb_1);
            this.Opt_gb.Location = new System.Drawing.Point(319, 12);
            this.Opt_gb.Name = "Opt_gb";
            this.Opt_gb.Size = new System.Drawing.Size(550, 278);
            this.Opt_gb.TabIndex = 2;
            this.Opt_gb.TabStop = false;
            // 
            // DMulObj_lb
            // 
            this.DMulObj_lb.AutoSize = true;
            this.DMulObj_lb.Location = new System.Drawing.Point(386, 37);
            this.DMulObj_lb.Name = "DMulObj_lb";
            this.DMulObj_lb.Size = new System.Drawing.Size(119, 15);
            this.DMulObj_lb.TabIndex = 1;
            this.DMulObj_lb.Text = "动态多目标优化";
            // 
            // HDMulObj_lb
            // 
            this.HDMulObj_lb.AutoSize = true;
            this.HDMulObj_lb.Location = new System.Drawing.Point(208, 37);
            this.HDMulObj_lb.Name = "HDMulObj_lb";
            this.HDMulObj_lb.Size = new System.Drawing.Size(135, 15);
            this.HDMulObj_lb.TabIndex = 1;
            this.HDMulObj_lb.Text = "高维度多目标优化";
            // 
            // GenOpt_lb
            // 
            this.GenOpt_lb.AutoSize = true;
            this.GenOpt_lb.Location = new System.Drawing.Point(29, 37);
            this.GenOpt_lb.Name = "GenOpt_lb";
            this.GenOpt_lb.Size = new System.Drawing.Size(103, 15);
            this.GenOpt_lb.TabIndex = 1;
            this.GenOpt_lb.Text = "通用静态优化";
            // 
            // GenOpt_rb_4
            // 
            this.GenOpt_rb_4.AutoSize = true;
            this.GenOpt_rb_4.Location = new System.Drawing.Point(32, 216);
            this.GenOpt_rb_4.Name = "GenOpt_rb_4";
            this.GenOpt_rb_4.Size = new System.Drawing.Size(73, 19);
            this.GenOpt_rb_4.TabIndex = 0;
            this.GenOpt_rb_4.TabStop = true;
            this.GenOpt_rb_4.Text = "MOPSO";
            this.GenOpt_rb_4.UseVisualStyleBackColor = true;
            // 
            // HDMuti_rb_3
            // 
            this.HDMuti_rb_3.AutoSize = true;
            this.HDMuti_rb_3.Location = new System.Drawing.Point(211, 175);
            this.HDMuti_rb_3.Name = "HDMuti_rb_3";
            this.HDMuti_rb_3.Size = new System.Drawing.Size(73, 19);
            this.HDMuti_rb_3.TabIndex = 0;
            this.HDMuti_rb_3.TabStop = true;
            this.HDMuti_rb_3.Text = "DMOEA";
            this.HDMuti_rb_3.UseVisualStyleBackColor = true;
            // 
            // HDMuti_rb_2
            // 
            this.HDMuti_rb_2.AutoSize = true;
            this.HDMuti_rb_2.Location = new System.Drawing.Point(211, 131);
            this.HDMuti_rb_2.Name = "HDMuti_rb_2";
            this.HDMuti_rb_2.Size = new System.Drawing.Size(73, 19);
            this.HDMuti_rb_2.TabIndex = 0;
            this.HDMuti_rb_2.TabStop = true;
            this.HDMuti_rb_2.Text = "OMOEA";
            this.HDMuti_rb_2.UseVisualStyleBackColor = true;
            // 
            // DMulti_rb_1
            // 
            this.DMulti_rb_1.AutoSize = true;
            this.DMulti_rb_1.Location = new System.Drawing.Point(389, 85);
            this.DMulti_rb_1.Name = "DMulti_rb_1";
            this.DMulti_rb_1.Size = new System.Drawing.Size(100, 19);
            this.DMulti_rb_1.TabIndex = 0;
            this.DMulti_rb_1.TabStop = true;
            this.DMulti_rb_1.Text = "DNSGA-II";
            this.DMulti_rb_1.UseVisualStyleBackColor = true;
            // 
            // GenOpt_rb_3
            // 
            this.GenOpt_rb_3.AutoSize = true;
            this.GenOpt_rb_3.Location = new System.Drawing.Point(32, 175);
            this.GenOpt_rb_3.Name = "GenOpt_rb_3";
            this.GenOpt_rb_3.Size = new System.Drawing.Size(91, 19);
            this.GenOpt_rb_3.TabIndex = 0;
            this.GenOpt_rb_3.TabStop = true;
            this.GenOpt_rb_3.Text = "SPEA-II";
            this.GenOpt_rb_3.UseVisualStyleBackColor = true;
            // 
            // HDMuti_rb_1
            // 
            this.HDMuti_rb_1.AutoSize = true;
            this.HDMuti_rb_1.Location = new System.Drawing.Point(211, 85);
            this.HDMuti_rb_1.Name = "HDMuti_rb_1";
            this.HDMuti_rb_1.Size = new System.Drawing.Size(73, 19);
            this.HDMuti_rb_1.TabIndex = 0;
            this.HDMuti_rb_1.TabStop = true;
            this.HDMuti_rb_1.Text = "GMDEA";
            this.HDMuti_rb_1.UseVisualStyleBackColor = true;
            // 
            // GenOpt_rb_2
            // 
            this.GenOpt_rb_2.AutoSize = true;
            this.GenOpt_rb_2.Location = new System.Drawing.Point(32, 131);
            this.GenOpt_rb_2.Name = "GenOpt_rb_2";
            this.GenOpt_rb_2.Size = new System.Drawing.Size(91, 19);
            this.GenOpt_rb_2.TabIndex = 0;
            this.GenOpt_rb_2.TabStop = true;
            this.GenOpt_rb_2.Text = "MDEA-II";
            this.GenOpt_rb_2.UseVisualStyleBackColor = true;
            // 
            // GenOpt_rb_1
            // 
            this.GenOpt_rb_1.AutoSize = true;
            this.GenOpt_rb_1.Location = new System.Drawing.Point(32, 85);
            this.GenOpt_rb_1.Name = "GenOpt_rb_1";
            this.GenOpt_rb_1.Size = new System.Drawing.Size(91, 19);
            this.GenOpt_rb_1.TabIndex = 0;
            this.GenOpt_rb_1.TabStop = true;
            this.GenOpt_rb_1.Text = "NSGA-II";
            this.GenOpt_rb_1.UseVisualStyleBackColor = true;
            // 
            // Con_Opt_gb
            // 
            this.Con_Opt_gb.Controls.Add(this.label4);
            this.Con_Opt_gb.Controls.Add(this.Con_Multi);
            this.Con_Opt_gb.Controls.Add(this.Con_Vissim);
            this.Con_Opt_gb.Controls.Add(this.ConOpt_rb_4);
            this.Con_Opt_gb.Controls.Add(this.ConMul_rb_3);
            this.Con_Opt_gb.Controls.Add(this.ConMul_rb_2);
            this.Con_Opt_gb.Controls.Add(this.ConDMul_rb_1);
            this.Con_Opt_gb.Controls.Add(this.ConOpt_rb_3);
            this.Con_Opt_gb.Controls.Add(this.ConMul_rb_1);
            this.Con_Opt_gb.Controls.Add(this.ConOpt_rb_2);
            this.Con_Opt_gb.Controls.Add(this.ConOpt_rb_1);
            this.Con_Opt_gb.Enabled = false;
            this.Con_Opt_gb.Location = new System.Drawing.Point(319, 295);
            this.Con_Opt_gb.Name = "Con_Opt_gb";
            this.Con_Opt_gb.Size = new System.Drawing.Size(550, 278);
            this.Con_Opt_gb.TabIndex = 2;
            this.Con_Opt_gb.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "动态多目标优化";
            // 
            // Con_Multi
            // 
            this.Con_Multi.AutoSize = true;
            this.Con_Multi.Location = new System.Drawing.Point(208, 37);
            this.Con_Multi.Name = "Con_Multi";
            this.Con_Multi.Size = new System.Drawing.Size(135, 15);
            this.Con_Multi.TabIndex = 1;
            this.Con_Multi.Text = "高维度多目标优化";
            // 
            // Con_Vissim
            // 
            this.Con_Vissim.AutoSize = true;
            this.Con_Vissim.Location = new System.Drawing.Point(29, 37);
            this.Con_Vissim.Name = "Con_Vissim";
            this.Con_Vissim.Size = new System.Drawing.Size(175, 15);
            this.Con_Vissim.TabIndex = 1;
            this.Con_Vissim.Text = "静态优化+控制 VISSIM";
            // 
            // ConOpt_rb_4
            // 
            this.ConOpt_rb_4.AutoSize = true;
            this.ConOpt_rb_4.Location = new System.Drawing.Point(32, 216);
            this.ConOpt_rb_4.Name = "ConOpt_rb_4";
            this.ConOpt_rb_4.Size = new System.Drawing.Size(73, 19);
            this.ConOpt_rb_4.TabIndex = 0;
            this.ConOpt_rb_4.TabStop = true;
            this.ConOpt_rb_4.Text = "MOPSO";
            this.ConOpt_rb_4.UseVisualStyleBackColor = true;
            // 
            // ConMul_rb_3
            // 
            this.ConMul_rb_3.AutoSize = true;
            this.ConMul_rb_3.Location = new System.Drawing.Point(211, 175);
            this.ConMul_rb_3.Name = "ConMul_rb_3";
            this.ConMul_rb_3.Size = new System.Drawing.Size(73, 19);
            this.ConMul_rb_3.TabIndex = 0;
            this.ConMul_rb_3.TabStop = true;
            this.ConMul_rb_3.Text = "DMOEA";
            this.ConMul_rb_3.UseVisualStyleBackColor = true;
            // 
            // ConMul_rb_2
            // 
            this.ConMul_rb_2.AutoSize = true;
            this.ConMul_rb_2.Location = new System.Drawing.Point(211, 131);
            this.ConMul_rb_2.Name = "ConMul_rb_2";
            this.ConMul_rb_2.Size = new System.Drawing.Size(73, 19);
            this.ConMul_rb_2.TabIndex = 0;
            this.ConMul_rb_2.TabStop = true;
            this.ConMul_rb_2.Text = "OMOEA";
            this.ConMul_rb_2.UseVisualStyleBackColor = true;
            // 
            // ConDMul_rb_1
            // 
            this.ConDMul_rb_1.AutoSize = true;
            this.ConDMul_rb_1.Location = new System.Drawing.Point(389, 85);
            this.ConDMul_rb_1.Name = "ConDMul_rb_1";
            this.ConDMul_rb_1.Size = new System.Drawing.Size(100, 19);
            this.ConDMul_rb_1.TabIndex = 0;
            this.ConDMul_rb_1.TabStop = true;
            this.ConDMul_rb_1.Text = "DNSGA-II";
            this.ConDMul_rb_1.UseVisualStyleBackColor = true;
            // 
            // ConOpt_rb_3
            // 
            this.ConOpt_rb_3.AutoSize = true;
            this.ConOpt_rb_3.Location = new System.Drawing.Point(32, 175);
            this.ConOpt_rb_3.Name = "ConOpt_rb_3";
            this.ConOpt_rb_3.Size = new System.Drawing.Size(91, 19);
            this.ConOpt_rb_3.TabIndex = 0;
            this.ConOpt_rb_3.TabStop = true;
            this.ConOpt_rb_3.Text = "SPEA-II";
            this.ConOpt_rb_3.UseVisualStyleBackColor = true;
            // 
            // ConMul_rb_1
            // 
            this.ConMul_rb_1.AutoSize = true;
            this.ConMul_rb_1.Location = new System.Drawing.Point(211, 85);
            this.ConMul_rb_1.Name = "ConMul_rb_1";
            this.ConMul_rb_1.Size = new System.Drawing.Size(73, 19);
            this.ConMul_rb_1.TabIndex = 0;
            this.ConMul_rb_1.TabStop = true;
            this.ConMul_rb_1.Text = "GMDEA";
            this.ConMul_rb_1.UseVisualStyleBackColor = true;
            // 
            // ConOpt_rb_2
            // 
            this.ConOpt_rb_2.AutoSize = true;
            this.ConOpt_rb_2.Location = new System.Drawing.Point(32, 132);
            this.ConOpt_rb_2.Name = "ConOpt_rb_2";
            this.ConOpt_rb_2.Size = new System.Drawing.Size(91, 19);
            this.ConOpt_rb_2.TabIndex = 0;
            this.ConOpt_rb_2.TabStop = true;
            this.ConOpt_rb_2.Text = "MDEA-II";
            this.ConOpt_rb_2.UseVisualStyleBackColor = true;
            // 
            // ConOpt_rb_1
            // 
            this.ConOpt_rb_1.AutoSize = true;
            this.ConOpt_rb_1.Location = new System.Drawing.Point(32, 85);
            this.ConOpt_rb_1.Name = "ConOpt_rb_1";
            this.ConOpt_rb_1.Size = new System.Drawing.Size(91, 19);
            this.ConOpt_rb_1.TabIndex = 0;
            this.ConOpt_rb_1.TabStop = true;
            this.ConOpt_rb_1.Text = "NSGA-II";
            this.ConOpt_rb_1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.Run_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 585);
            this.Controls.Add(this.Con_Opt_gb);
            this.Controls.Add(this.Opt_gb);
            this.Controls.Add(this.Run_btn);
            this.Controls.Add(this.Roadnet_gb);
            this.Controls.Add(this.Algorithm_gb);
            this.Controls.Add(this.Model_gb);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "Form2";
            this.Text = " ";
            this.Model_gb.ResumeLayout(false);
            this.Model_gb.PerformLayout();
            this.Algorithm_gb.ResumeLayout(false);
            this.Algorithm_gb.PerformLayout();
            this.Roadnet_gb.ResumeLayout(false);
            this.Roadnet_gb.PerformLayout();
            this.Opt_gb.ResumeLayout(false);
            this.Opt_gb.PerformLayout();
            this.Con_Opt_gb.ResumeLayout(false);
            this.Con_Opt_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Model_gb;
        private System.Windows.Forms.GroupBox Algorithm_gb;
        private System.Windows.Forms.GroupBox Roadnet_gb;
        private System.Windows.Forms.RadioButton model2_rb;
        private System.Windows.Forms.RadioButton model1_rb;
        private System.Windows.Forms.RadioButton algorithm2_rb;
        private System.Windows.Forms.RadioButton algorithm1_rb;
        private System.Windows.Forms.RadioButton roadnet2_rb;
        private System.Windows.Forms.RadioButton roadnet1_rb;
        private System.Windows.Forms.Button Run_btn;
        private System.Windows.Forms.GroupBox Opt_gb;
        private System.Windows.Forms.Label DMulObj_lb;
        private System.Windows.Forms.Label HDMulObj_lb;
        private System.Windows.Forms.Label GenOpt_lb;
        private System.Windows.Forms.RadioButton GenOpt_rb_4;
        private System.Windows.Forms.RadioButton HDMuti_rb_3;
        private System.Windows.Forms.RadioButton HDMuti_rb_2;
        private System.Windows.Forms.RadioButton DMulti_rb_1;
        private System.Windows.Forms.RadioButton GenOpt_rb_3;
        private System.Windows.Forms.RadioButton HDMuti_rb_1;
        private System.Windows.Forms.RadioButton GenOpt_rb_2;
        private System.Windows.Forms.RadioButton GenOpt_rb_1;
        private System.Windows.Forms.GroupBox Con_Opt_gb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Con_Multi;
        private System.Windows.Forms.Label Con_Vissim;
        private System.Windows.Forms.RadioButton ConOpt_rb_4;
        private System.Windows.Forms.RadioButton ConMul_rb_3;
        private System.Windows.Forms.RadioButton ConMul_rb_2;
        private System.Windows.Forms.RadioButton ConDMul_rb_1;
        private System.Windows.Forms.RadioButton ConOpt_rb_3;
        private System.Windows.Forms.RadioButton ConMul_rb_1;
        private System.Windows.Forms.RadioButton ConOpt_rb_2;
        private System.Windows.Forms.RadioButton ConOpt_rb_1;
    }
}

