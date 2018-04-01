namespace CaterUI
{
    partial class 登录界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登录界面));
            this.label_用户名 = new System.Windows.Forms.Label();
            this.label_密码 = new System.Windows.Forms.Label();
            this.textBox_用户名 = new System.Windows.Forms.TextBox();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.button_登录 = new System.Windows.Forms.Button();
            this.button_退出 = new System.Windows.Forms.Button();
            this.label_密码错误提示 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_用户名
            // 
            this.label_用户名.AutoSize = true;
            this.label_用户名.BackColor = System.Drawing.SystemColors.Window;
            this.label_用户名.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_用户名.ForeColor = System.Drawing.Color.Black;
            this.label_用户名.Location = new System.Drawing.Point(141, 98);
            this.label_用户名.Name = "label_用户名";
            this.label_用户名.Size = new System.Drawing.Size(68, 16);
            this.label_用户名.TabIndex = 0;
            this.label_用户名.Text = "用户名:";
            // 
            // label_密码
            // 
            this.label_密码.AutoSize = true;
            this.label_密码.BackColor = System.Drawing.SystemColors.Window;
            this.label_密码.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_密码.Location = new System.Drawing.Point(141, 157);
            this.label_密码.Name = "label_密码";
            this.label_密码.Size = new System.Drawing.Size(60, 16);
            this.label_密码.TabIndex = 1;
            this.label_密码.Text = "密 码:";
            // 
            // textBox_用户名
            // 
            this.textBox_用户名.Location = new System.Drawing.Point(221, 95);
            this.textBox_用户名.Name = "textBox_用户名";
            this.textBox_用户名.Size = new System.Drawing.Size(166, 21);
            this.textBox_用户名.TabIndex = 2;
            // 
            // textBox_密码
            // 
            this.textBox_密码.Location = new System.Drawing.Point(221, 154);
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.PasswordChar = '*';
            this.textBox_密码.Size = new System.Drawing.Size(166, 21);
            this.textBox_密码.TabIndex = 3;
            // 
            // button_登录
            // 
            this.button_登录.Location = new System.Drawing.Point(144, 214);
            this.button_登录.Name = "button_登录";
            this.button_登录.Size = new System.Drawing.Size(75, 31);
            this.button_登录.TabIndex = 4;
            this.button_登录.Text = "登录";
            this.button_登录.UseVisualStyleBackColor = true;
            this.button_登录.Click += new System.EventHandler(this.button_登录_Click);
            // 
            // button_退出
            // 
            this.button_退出.Location = new System.Drawing.Point(312, 214);
            this.button_退出.Name = "button_退出";
            this.button_退出.Size = new System.Drawing.Size(75, 31);
            this.button_退出.TabIndex = 5;
            this.button_退出.Text = "退出";
            this.button_退出.UseVisualStyleBackColor = true;
            this.button_退出.Click += new System.EventHandler(this.button_退出_Click);
            // 
            // label_密码错误提示
            // 
            this.label_密码错误提示.AutoSize = true;
            this.label_密码错误提示.BackColor = System.Drawing.SystemColors.Window;
            this.label_密码错误提示.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_密码错误提示.ForeColor = System.Drawing.Color.Red;
            this.label_密码错误提示.Location = new System.Drawing.Point(211, 190);
            this.label_密码错误提示.Name = "label_密码错误提示";
            this.label_密码错误提示.Size = new System.Drawing.Size(72, 16);
            this.label_密码错误提示.TabIndex = 6;
            this.label_密码错误提示.Text = "密码错误";
            // 
            // 登录界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 333);
            this.Controls.Add(this.label_密码错误提示);
            this.Controls.Add(this.button_退出);
            this.Controls.Add(this.button_登录);
            this.Controls.Add(this.textBox_密码);
            this.Controls.Add(this.textBox_用户名);
            this.Controls.Add(this.label_密码);
            this.Controls.Add(this.label_用户名);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "登录界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_用户名;
        private System.Windows.Forms.Label label_密码;
        private System.Windows.Forms.TextBox textBox_用户名;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.Button button_登录;
        private System.Windows.Forms.Button button_退出;
        private System.Windows.Forms.Label label_密码错误提示;
    }
}