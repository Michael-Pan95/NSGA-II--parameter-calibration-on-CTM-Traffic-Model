namespace UIdesign
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.userlabel = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.passwlabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userlabel.Location = new System.Drawing.Point(41, 111);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(56, 16);
            this.userlabel.TabIndex = 0;
            this.userlabel.Text = "用户名";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(124, 52);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(40, 16);
            this.login.TabIndex = 1;
            this.login.Text = "登陆";
            // 
            // passwlabel
            // 
            this.passwlabel.AutoSize = true;
            this.passwlabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwlabel.Location = new System.Drawing.Point(48, 156);
            this.passwlabel.Name = "passwlabel";
            this.passwlabel.Size = new System.Drawing.Size(40, 16);
            this.passwlabel.TabIndex = 2;
            this.passwlabel.Text = "密码";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(115, 106);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(112, 21);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(115, 151);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(112, 21);
            this.password.TabIndex = 4;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(106, 201);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 5;
            this.confirm.Text = "确定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.passwlabel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.userlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label passwlabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button confirm;
    }
}

