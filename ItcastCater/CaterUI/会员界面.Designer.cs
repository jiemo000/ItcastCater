namespace CaterUI
{
    partial class 会员界面
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
            this.dataGridView_会员管理 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_搜索 = new System.Windows.Forms.GroupBox();
            this.textBox_搜索_手机号 = new System.Windows.Forms.TextBox();
            this.textBox_搜索_姓名 = new System.Windows.Forms.TextBox();
            this.button_搜索_显示全部 = new System.Windows.Forms.Button();
            this.label_搜索_手机号 = new System.Windows.Forms.Label();
            this.label_搜索_姓名 = new System.Windows.Forms.Label();
            this.groupBox_添加删除 = new System.Windows.Forms.GroupBox();
            this.comboBox_添加_类型 = new System.Windows.Forms.ComboBox();
            this.button_添加_类型管理 = new System.Windows.Forms.Button();
            this.button_添加_删除选中的行数据 = new System.Windows.Forms.Button();
            this.label_添加_提示 = new System.Windows.Forms.Label();
            this.button_添加_取消 = new System.Windows.Forms.Button();
            this.button_添加_添加 = new System.Windows.Forms.Button();
            this.textBox_添加_余额 = new System.Windows.Forms.TextBox();
            this.label_添加_余额 = new System.Windows.Forms.Label();
            this.textBox_添加_手机号 = new System.Windows.Forms.TextBox();
            this.label_添加_手机号 = new System.Windows.Forms.Label();
            this.label_添加_类型 = new System.Windows.Forms.Label();
            this.textBox_添加_姓名 = new System.Windows.Forms.TextBox();
            this.label_添加_姓名 = new System.Windows.Forms.Label();
            this.textBox_添加_编号 = new System.Windows.Forms.TextBox();
            this.label_添加_编号 = new System.Windows.Forms.Label();
            this.groupBox_列表.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_会员管理)).BeginInit();
            this.groupBox_搜索.SuspendLayout();
            this.groupBox_添加删除.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_列表
            // 
            this.groupBox_列表.Controls.Add(this.dataGridView_会员管理);
            this.groupBox_列表.Location = new System.Drawing.Point(16, 15);
            this.groupBox_列表.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_列表.Name = "groupBox_列表";
            this.groupBox_列表.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_列表.Size = new System.Drawing.Size(607, 558);
            this.groupBox_列表.TabIndex = 0;
            this.groupBox_列表.TabStop = false;
            this.groupBox_列表.Text = "列表";
            // 
            // dataGridView_会员管理
            // 
            this.dataGridView_会员管理.AllowUserToResizeColumns = false;
            this.dataGridView_会员管理.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_会员管理.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_会员管理.Location = new System.Drawing.Point(8, 25);
            this.dataGridView_会员管理.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_会员管理.Name = "dataGridView_会员管理";
            this.dataGridView_会员管理.RowTemplate.Height = 23;
            this.dataGridView_会员管理.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_会员管理.Size = new System.Drawing.Size(591, 525);
            this.dataGridView_会员管理.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MId";
            this.Column1.HeaderText = "会员编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MName";
            this.Column2.HeaderText = "名字";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MPhone";
            this.Column3.HeaderText = "电话";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MMoney";
            this.Column4.HeaderText = "余额";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MTypeTitle";
            this.Column5.HeaderText = "会员类型";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // groupBox_搜索
            // 
            this.groupBox_搜索.Controls.Add(this.textBox_搜索_手机号);
            this.groupBox_搜索.Controls.Add(this.textBox_搜索_姓名);
            this.groupBox_搜索.Controls.Add(this.button_搜索_显示全部);
            this.groupBox_搜索.Controls.Add(this.label_搜索_手机号);
            this.groupBox_搜索.Controls.Add(this.label_搜索_姓名);
            this.groupBox_搜索.Location = new System.Drawing.Point(631, 15);
            this.groupBox_搜索.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_搜索.Name = "groupBox_搜索";
            this.groupBox_搜索.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_搜索.Size = new System.Drawing.Size(260, 149);
            this.groupBox_搜索.TabIndex = 1;
            this.groupBox_搜索.TabStop = false;
            this.groupBox_搜索.Text = "搜索";
            // 
            // textBox_搜索_手机号
            // 
            this.textBox_搜索_手机号.Location = new System.Drawing.Point(87, 68);
            this.textBox_搜索_手机号.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_搜索_手机号.Name = "textBox_搜索_手机号";
            this.textBox_搜索_手机号.Size = new System.Drawing.Size(152, 25);
            this.textBox_搜索_手机号.TabIndex = 4;
            this.textBox_搜索_手机号.TextChanged += new System.EventHandler(this.textBox_搜索_手机号_TextChanged);
            // 
            // textBox_搜索_姓名
            // 
            this.textBox_搜索_姓名.Location = new System.Drawing.Point(87, 26);
            this.textBox_搜索_姓名.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_搜索_姓名.Name = "textBox_搜索_姓名";
            this.textBox_搜索_姓名.Size = new System.Drawing.Size(152, 25);
            this.textBox_搜索_姓名.TabIndex = 3;
            this.textBox_搜索_姓名.TextChanged += new System.EventHandler(this.textBox_搜索_姓名_TextChanged);
            // 
            // button_搜索_显示全部
            // 
            this.button_搜索_显示全部.Location = new System.Drawing.Point(51, 108);
            this.button_搜索_显示全部.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_搜索_显示全部.Name = "button_搜索_显示全部";
            this.button_搜索_显示全部.Size = new System.Drawing.Size(160, 29);
            this.button_搜索_显示全部.TabIndex = 2;
            this.button_搜索_显示全部.Text = "显示全部";
            this.button_搜索_显示全部.UseVisualStyleBackColor = true;
            this.button_搜索_显示全部.Click += new System.EventHandler(this.button_搜索_显示全部_Click);
            // 
            // label_搜索_手机号
            // 
            this.label_搜索_手机号.AutoSize = true;
            this.label_搜索_手机号.Location = new System.Drawing.Point(20, 75);
            this.label_搜索_手机号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_搜索_手机号.Name = "label_搜索_手机号";
            this.label_搜索_手机号.Size = new System.Drawing.Size(60, 15);
            this.label_搜索_手机号.TabIndex = 1;
            this.label_搜索_手机号.Text = "手机号:";
            // 
            // label_搜索_姓名
            // 
            this.label_搜索_姓名.AutoSize = true;
            this.label_搜索_姓名.Location = new System.Drawing.Point(24, 35);
            this.label_搜索_姓名.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_搜索_姓名.Name = "label_搜索_姓名";
            this.label_搜索_姓名.Size = new System.Drawing.Size(45, 15);
            this.label_搜索_姓名.TabIndex = 0;
            this.label_搜索_姓名.Text = "姓名:";
            // 
            // groupBox_添加删除
            // 
            this.groupBox_添加删除.Controls.Add(this.comboBox_添加_类型);
            this.groupBox_添加删除.Controls.Add(this.button_添加_类型管理);
            this.groupBox_添加删除.Controls.Add(this.button_添加_删除选中的行数据);
            this.groupBox_添加删除.Controls.Add(this.label_添加_提示);
            this.groupBox_添加删除.Controls.Add(this.button_添加_取消);
            this.groupBox_添加删除.Controls.Add(this.button_添加_添加);
            this.groupBox_添加删除.Controls.Add(this.textBox_添加_余额);
            this.groupBox_添加删除.Controls.Add(this.label_添加_余额);
            this.groupBox_添加删除.Controls.Add(this.textBox_添加_手机号);
            this.groupBox_添加删除.Controls.Add(this.label_添加_手机号);
            this.groupBox_添加删除.Controls.Add(this.label_添加_类型);
            this.groupBox_添加删除.Controls.Add(this.textBox_添加_姓名);
            this.groupBox_添加删除.Controls.Add(this.label_添加_姓名);
            this.groupBox_添加删除.Controls.Add(this.textBox_添加_编号);
            this.groupBox_添加删除.Controls.Add(this.label_添加_编号);
            this.groupBox_添加删除.Location = new System.Drawing.Point(631, 171);
            this.groupBox_添加删除.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_添加删除.Name = "groupBox_添加删除";
            this.groupBox_添加删除.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_添加删除.Size = new System.Drawing.Size(260, 401);
            this.groupBox_添加删除.TabIndex = 2;
            this.groupBox_添加删除.TabStop = false;
            this.groupBox_添加删除.Text = "添加/删除";
            // 
            // comboBox_添加_类型
            // 
            this.comboBox_添加_类型.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_添加_类型.FormattingEnabled = true;
            this.comboBox_添加_类型.Items.AddRange(new object[] {
            "会员类型"});
            this.comboBox_添加_类型.Location = new System.Drawing.Point(87, 98);
            this.comboBox_添加_类型.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_添加_类型.Name = "comboBox_添加_类型";
            this.comboBox_添加_类型.Size = new System.Drawing.Size(152, 23);
            this.comboBox_添加_类型.TabIndex = 18;
            this.comboBox_添加_类型.DropDown += new System.EventHandler(this.comboBox_添加_类型_DropDown);
            // 
            // button_添加_类型管理
            // 
            this.button_添加_类型管理.Location = new System.Drawing.Point(87, 136);
            this.button_添加_类型管理.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_添加_类型管理.Name = "button_添加_类型管理";
            this.button_添加_类型管理.Size = new System.Drawing.Size(153, 29);
            this.button_添加_类型管理.TabIndex = 17;
            this.button_添加_类型管理.Text = "类型管理";
            this.button_添加_类型管理.UseVisualStyleBackColor = true;
            this.button_添加_类型管理.Click += new System.EventHandler(this.button_添加_类型管理_Click);
            // 
            // button_添加_删除选中的行数据
            // 
            this.button_添加_删除选中的行数据.Location = new System.Drawing.Point(31, 354);
            this.button_添加_删除选中的行数据.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_添加_删除选中的行数据.Name = "button_添加_删除选中的行数据";
            this.button_添加_删除选中的行数据.Size = new System.Drawing.Size(209, 29);
            this.button_添加_删除选中的行数据.TabIndex = 16;
            this.button_添加_删除选中的行数据.Text = "删除选中的行数据";
            this.button_添加_删除选中的行数据.UseVisualStyleBackColor = true;
            this.button_添加_删除选中的行数据.Click += new System.EventHandler(this.button_添加_删除选中的行数据_Click);
            // 
            // label_添加_提示
            // 
            this.label_添加_提示.AutoSize = true;
            this.label_添加_提示.ForeColor = System.Drawing.Color.Red;
            this.label_添加_提示.Location = new System.Drawing.Point(48, 324);
            this.label_添加_提示.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_添加_提示.Name = "label_添加_提示";
            this.label_添加_提示.Size = new System.Drawing.Size(165, 15);
            this.label_添加_提示.TabIndex = 15;
            this.label_添加_提示.Text = "提示:双加表格项进行修\r\n";
            // 
            // button_添加_取消
            // 
            this.button_添加_取消.Location = new System.Drawing.Point(140, 271);
            this.button_添加_取消.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_添加_取消.Name = "button_添加_取消";
            this.button_添加_取消.Size = new System.Drawing.Size(100, 29);
            this.button_添加_取消.TabIndex = 14;
            this.button_添加_取消.Text = "取消";
            this.button_添加_取消.UseVisualStyleBackColor = true;
            this.button_添加_取消.Click += new System.EventHandler(this.button_添加_取消_Click);
            // 
            // button_添加_添加
            // 
            this.button_添加_添加.Location = new System.Drawing.Point(31, 271);
            this.button_添加_添加.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_添加_添加.Name = "button_添加_添加";
            this.button_添加_添加.Size = new System.Drawing.Size(100, 29);
            this.button_添加_添加.TabIndex = 13;
            this.button_添加_添加.Text = "添加";
            this.button_添加_添加.UseVisualStyleBackColor = true;
            this.button_添加_添加.Click += new System.EventHandler(this.button_添加_添加_Click);
            // 
            // textBox_添加_余额
            // 
            this.textBox_添加_余额.Location = new System.Drawing.Point(87, 212);
            this.textBox_添加_余额.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_添加_余额.Name = "textBox_添加_余额";
            this.textBox_添加_余额.Size = new System.Drawing.Size(152, 25);
            this.textBox_添加_余额.TabIndex = 12;
            // 
            // label_添加_余额
            // 
            this.label_添加_余额.AutoSize = true;
            this.label_添加_余额.Location = new System.Drawing.Point(24, 220);
            this.label_添加_余额.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_添加_余额.Name = "label_添加_余额";
            this.label_添加_余额.Size = new System.Drawing.Size(45, 15);
            this.label_添加_余额.TabIndex = 11;
            this.label_添加_余额.Text = "余额:";
            // 
            // textBox_添加_手机号
            // 
            this.textBox_添加_手机号.Location = new System.Drawing.Point(87, 179);
            this.textBox_添加_手机号.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_添加_手机号.Name = "textBox_添加_手机号";
            this.textBox_添加_手机号.Size = new System.Drawing.Size(152, 25);
            this.textBox_添加_手机号.TabIndex = 10;
            // 
            // label_添加_手机号
            // 
            this.label_添加_手机号.AutoSize = true;
            this.label_添加_手机号.Location = new System.Drawing.Point(24, 186);
            this.label_添加_手机号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_添加_手机号.Name = "label_添加_手机号";
            this.label_添加_手机号.Size = new System.Drawing.Size(60, 15);
            this.label_添加_手机号.TabIndex = 9;
            this.label_添加_手机号.Text = "手机号:";
            // 
            // label_添加_类型
            // 
            this.label_添加_类型.AutoSize = true;
            this.label_添加_类型.Location = new System.Drawing.Point(24, 105);
            this.label_添加_类型.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_添加_类型.Name = "label_添加_类型";
            this.label_添加_类型.Size = new System.Drawing.Size(45, 15);
            this.label_添加_类型.TabIndex = 7;
            this.label_添加_类型.Text = "类型:";
            // 
            // textBox_添加_姓名
            // 
            this.textBox_添加_姓名.Location = new System.Drawing.Point(87, 64);
            this.textBox_添加_姓名.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_添加_姓名.Name = "textBox_添加_姓名";
            this.textBox_添加_姓名.Size = new System.Drawing.Size(152, 25);
            this.textBox_添加_姓名.TabIndex = 6;
            // 
            // label_添加_姓名
            // 
            this.label_添加_姓名.AutoSize = true;
            this.label_添加_姓名.Location = new System.Drawing.Point(24, 71);
            this.label_添加_姓名.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_添加_姓名.Name = "label_添加_姓名";
            this.label_添加_姓名.Size = new System.Drawing.Size(45, 15);
            this.label_添加_姓名.TabIndex = 5;
            this.label_添加_姓名.Text = "姓名:";
            // 
            // textBox_添加_编号
            // 
            this.textBox_添加_编号.Location = new System.Drawing.Point(87, 30);
            this.textBox_添加_编号.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_添加_编号.Name = "textBox_添加_编号";
            this.textBox_添加_编号.ReadOnly = true;
            this.textBox_添加_编号.Size = new System.Drawing.Size(152, 25);
            this.textBox_添加_编号.TabIndex = 4;
            // 
            // label_添加_编号
            // 
            this.label_添加_编号.AutoSize = true;
            this.label_添加_编号.Location = new System.Drawing.Point(24, 38);
            this.label_添加_编号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_添加_编号.Name = "label_添加_编号";
            this.label_添加_编号.Size = new System.Drawing.Size(45, 15);
            this.label_添加_编号.TabIndex = 1;
            this.label_添加_编号.Text = "编号:";
            // 
            // 会员界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 588);
            this.Controls.Add(this.groupBox_添加删除);
            this.Controls.Add(this.groupBox_搜索);
            this.Controls.Add(this.groupBox_列表);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "会员界面";
            this.Text = "会员管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.会员管理_FormClosing);
            this.Load += new System.EventHandler(this.会员界面_Load);
            this.groupBox_列表.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_会员管理)).EndInit();
            this.groupBox_搜索.ResumeLayout(false);
            this.groupBox_搜索.PerformLayout();
            this.groupBox_添加删除.ResumeLayout(false);
            this.groupBox_添加删除.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_列表;
        private System.Windows.Forms.DataGridView dataGridView_会员管理;
        private System.Windows.Forms.GroupBox groupBox_搜索;
        private System.Windows.Forms.GroupBox groupBox_添加删除;
        private System.Windows.Forms.TextBox textBox_搜索_手机号;
        private System.Windows.Forms.TextBox textBox_搜索_姓名;
        private System.Windows.Forms.Button button_搜索_显示全部;
        private System.Windows.Forms.Label label_搜索_手机号;
        private System.Windows.Forms.Label label_搜索_姓名;
        private System.Windows.Forms.Button button_添加_类型管理;
        private System.Windows.Forms.Button button_添加_删除选中的行数据;
        private System.Windows.Forms.Label label_添加_提示;
        private System.Windows.Forms.Button button_添加_取消;
        private System.Windows.Forms.Button button_添加_添加;
        private System.Windows.Forms.TextBox textBox_添加_余额;
        private System.Windows.Forms.Label label_添加_余额;
        private System.Windows.Forms.TextBox textBox_添加_手机号;
        private System.Windows.Forms.Label label_添加_手机号;
        private System.Windows.Forms.Label label_添加_类型;
        private System.Windows.Forms.TextBox textBox_添加_姓名;
        private System.Windows.Forms.Label label_添加_姓名;
        private System.Windows.Forms.TextBox textBox_添加_编号;
        private System.Windows.Forms.Label label_添加_编号;
        private System.Windows.Forms.ComboBox comboBox_添加_类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}