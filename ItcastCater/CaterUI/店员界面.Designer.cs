namespace CaterUI
{
    partial class 店员界面
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
            this.groupBox_列表 = new System.Windows.Forms.GroupBox();
            this.dataGridView_店员列表 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_添加修改 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_密码 = new System.Windows.Forms.TextBox();
            this.textBox_用户名 = new System.Windows.Forms.TextBox();
            this.textBox_编号 = new System.Windows.Forms.TextBox();
            this.radioButton_店员 = new System.Windows.Forms.RadioButton();
            this.button_删除选中的店员 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.button_添加 = new System.Windows.Forms.Button();
            this.radioButton_经理 = new System.Windows.Forms.RadioButton();
            this.label_类型 = new System.Windows.Forms.Label();
            this.label_密码 = new System.Windows.Forms.Label();
            this.label_用户名 = new System.Windows.Forms.Label();
            this.label_编号 = new System.Windows.Forms.Label();
            this.groupBox_列表.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_店员列表)).BeginInit();
            this.groupBox_添加修改.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_列表
            // 
            this.groupBox_列表.Controls.Add(this.dataGridView_店员列表);
            this.groupBox_列表.Location = new System.Drawing.Point(10, 15);
            this.groupBox_列表.Name = "groupBox_列表";
            this.groupBox_列表.Size = new System.Drawing.Size(269, 241);
            this.groupBox_列表.TabIndex = 0;
            this.groupBox_列表.TabStop = false;
            this.groupBox_列表.Text = "列表";
            // 
            // dataGridView_店员列表
            // 
            this.dataGridView_店员列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_店员列表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_店员列表.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_店员列表.MultiSelect = false;
            this.dataGridView_店员列表.Name = "dataGridView_店员列表";
            this.dataGridView_店员列表.RowHeadersWidth = 20;
            this.dataGridView_店员列表.RowTemplate.Height = 23;
            this.dataGridView_店员列表.Size = new System.Drawing.Size(257, 212);
            this.dataGridView_店员列表.TabIndex = 0;
            this.dataGridView_店员列表.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_店员列表_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MId";
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MNam";
            this.Column2.HeaderText = "用户名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MType";
            this.Column3.HeaderText = "职位";
            this.Column3.Name = "Column3";
            this.Column3.Width = 85;
            // 
            // groupBox_添加修改
            // 
            this.groupBox_添加修改.Controls.Add(this.label1);
            this.groupBox_添加修改.Controls.Add(this.textBox_密码);
            this.groupBox_添加修改.Controls.Add(this.textBox_用户名);
            this.groupBox_添加修改.Controls.Add(this.textBox_编号);
            this.groupBox_添加修改.Controls.Add(this.radioButton_店员);
            this.groupBox_添加修改.Controls.Add(this.button_删除选中的店员);
            this.groupBox_添加修改.Controls.Add(this.button_取消);
            this.groupBox_添加修改.Controls.Add(this.button_添加);
            this.groupBox_添加修改.Controls.Add(this.radioButton_经理);
            this.groupBox_添加修改.Controls.Add(this.label_类型);
            this.groupBox_添加修改.Controls.Add(this.label_密码);
            this.groupBox_添加修改.Controls.Add(this.label_用户名);
            this.groupBox_添加修改.Controls.Add(this.label_编号);
            this.groupBox_添加修改.Location = new System.Drawing.Point(290, 15);
            this.groupBox_添加修改.Name = "groupBox_添加修改";
            this.groupBox_添加修改.Size = new System.Drawing.Size(191, 241);
            this.groupBox_添加修改.TabIndex = 1;
            this.groupBox_添加修改.TabStop = false;
            this.groupBox_添加修改.Text = "添加/修改";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "说明:选中表格某行,删除账号";
            // 
            // textBox_密码
            // 
            this.textBox_密码.Location = new System.Drawing.Point(63, 89);
            this.textBox_密码.Name = "textBox_密码";
            this.textBox_密码.Size = new System.Drawing.Size(100, 21);
            this.textBox_密码.TabIndex = 11;
            // 
            // textBox_用户名
            // 
            this.textBox_用户名.Location = new System.Drawing.Point(63, 57);
            this.textBox_用户名.Name = "textBox_用户名";
            this.textBox_用户名.Size = new System.Drawing.Size(100, 21);
            this.textBox_用户名.TabIndex = 10;
            // 
            // textBox_编号
            // 
            this.textBox_编号.Location = new System.Drawing.Point(63, 28);
            this.textBox_编号.Name = "textBox_编号";
            this.textBox_编号.ReadOnly = true;
            this.textBox_编号.Size = new System.Drawing.Size(100, 21);
            this.textBox_编号.TabIndex = 9;
            // 
            // radioButton_店员
            // 
            this.radioButton_店员.AutoSize = true;
            this.radioButton_店员.Checked = true;
            this.radioButton_店员.Location = new System.Drawing.Point(125, 123);
            this.radioButton_店员.Name = "radioButton_店员";
            this.radioButton_店员.Size = new System.Drawing.Size(47, 16);
            this.radioButton_店员.TabIndex = 8;
            this.radioButton_店员.TabStop = true;
            this.radioButton_店员.Text = "店员";
            this.radioButton_店员.UseVisualStyleBackColor = true;
            // 
            // button_删除选中的店员
            // 
            this.button_删除选中的店员.Location = new System.Drawing.Point(18, 209);
            this.button_删除选中的店员.Name = "button_删除选中的店员";
            this.button_删除选中的店员.Size = new System.Drawing.Size(154, 23);
            this.button_删除选中的店员.TabIndex = 7;
            this.button_删除选中的店员.Text = "删除选中的店员";
            this.button_删除选中的店员.UseVisualStyleBackColor = true;
            this.button_删除选中的店员.Click += new System.EventHandler(this.button_删除选中的店员_Click);
            // 
            // button_取消
            // 
            this.button_取消.Location = new System.Drawing.Point(113, 145);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(59, 23);
            this.button_取消.TabIndex = 6;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // button_添加
            // 
            this.button_添加.Location = new System.Drawing.Point(18, 145);
            this.button_添加.Name = "button_添加";
            this.button_添加.Size = new System.Drawing.Size(59, 23);
            this.button_添加.TabIndex = 5;
            this.button_添加.Text = "添加";
            this.button_添加.UseVisualStyleBackColor = true;
            this.button_添加.Click += new System.EventHandler(this.button_添加_Click);
            // 
            // radioButton_经理
            // 
            this.radioButton_经理.AutoSize = true;
            this.radioButton_经理.Location = new System.Drawing.Point(63, 123);
            this.radioButton_经理.Name = "radioButton_经理";
            this.radioButton_经理.Size = new System.Drawing.Size(47, 16);
            this.radioButton_经理.TabIndex = 4;
            this.radioButton_经理.Text = "经理";
            this.radioButton_经理.UseVisualStyleBackColor = true;
            // 
            // label_类型
            // 
            this.label_类型.AutoSize = true;
            this.label_类型.Location = new System.Drawing.Point(16, 125);
            this.label_类型.Name = "label_类型";
            this.label_类型.Size = new System.Drawing.Size(35, 12);
            this.label_类型.TabIndex = 3;
            this.label_类型.Text = "类型:";
            // 
            // label_密码
            // 
            this.label_密码.AutoSize = true;
            this.label_密码.Location = new System.Drawing.Point(16, 95);
            this.label_密码.Name = "label_密码";
            this.label_密码.Size = new System.Drawing.Size(35, 12);
            this.label_密码.TabIndex = 2;
            this.label_密码.Text = "密码:";
            // 
            // label_用户名
            // 
            this.label_用户名.AutoSize = true;
            this.label_用户名.Location = new System.Drawing.Point(16, 62);
            this.label_用户名.Name = "label_用户名";
            this.label_用户名.Size = new System.Drawing.Size(47, 12);
            this.label_用户名.TabIndex = 1;
            this.label_用户名.Text = "用户名:";
            // 
            // label_编号
            // 
            this.label_编号.AutoSize = true;
            this.label_编号.Location = new System.Drawing.Point(16, 34);
            this.label_编号.Name = "label_编号";
            this.label_编号.Size = new System.Drawing.Size(35, 12);
            this.label_编号.TabIndex = 0;
            this.label_编号.Text = "编号:";
            // 
            // 店员界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 259);
            this.Controls.Add(this.groupBox_添加修改);
            this.Controls.Add(this.groupBox_列表);
            this.Name = "店员界面";
            this.Text = "店员管理";
            this.Load += new System.EventHandler(this.ManagerInfo_Load);
            this.groupBox_列表.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_店员列表)).EndInit();
            this.groupBox_添加修改.ResumeLayout(false);
            this.groupBox_添加修改.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_列表;
        private System.Windows.Forms.DataGridView dataGridView_店员列表;
        private System.Windows.Forms.GroupBox groupBox_添加修改;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_密码;
        private System.Windows.Forms.TextBox textBox_用户名;
        private System.Windows.Forms.TextBox textBox_编号;
        private System.Windows.Forms.RadioButton radioButton_店员;
        private System.Windows.Forms.Button button_删除选中的店员;
        private System.Windows.Forms.Button button_取消;
        private System.Windows.Forms.Button button_添加;
        private System.Windows.Forms.RadioButton radioButton_经理;
        private System.Windows.Forms.Label label_类型;
        private System.Windows.Forms.Label label_密码;
        private System.Windows.Forms.Label label_用户名;
        private System.Windows.Forms.Label label_编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}