namespace CaterUI
{
    partial class 菜单类型界面
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_菜系 = new System.Windows.Forms.Label();
            this.groupBox_添加修改 = new System.Windows.Forms.GroupBox();
            this.label_需要修改的员工编号 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_菜系 = new System.Windows.Forms.TextBox();
            this.textBox_编号 = new System.Windows.Forms.TextBox();
            this.button_删除选中的菜系 = new System.Windows.Forms.Button();
            this.button_取消 = new System.Windows.Forms.Button();
            this.button_添加 = new System.Windows.Forms.Button();
            this.label_折扣 = new System.Windows.Forms.Label();
            this.label_编号 = new System.Windows.Forms.Label();
            this.groupBox_列表 = new System.Windows.Forms.GroupBox();
            this.dataGridView_菜单类型管理 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_添加修改.SuspendLayout();
            this.groupBox_列表.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_菜单类型管理)).BeginInit();
            this.SuspendLayout();
            // 
            // label_菜系
            // 
            this.label_菜系.AutoSize = true;
            this.label_菜系.Location = new System.Drawing.Point(16, 82);
            this.label_菜系.Name = "label_菜系";
            this.label_菜系.Size = new System.Drawing.Size(35, 12);
            this.label_菜系.TabIndex = 1;
            this.label_菜系.Text = "菜系:";
            // 
            // groupBox_添加修改
            // 
            this.groupBox_添加修改.Controls.Add(this.label_需要修改的员工编号);
            this.groupBox_添加修改.Controls.Add(this.label1);
            this.groupBox_添加修改.Controls.Add(this.textBox_菜系);
            this.groupBox_添加修改.Controls.Add(this.textBox_编号);
            this.groupBox_添加修改.Controls.Add(this.button_删除选中的菜系);
            this.groupBox_添加修改.Controls.Add(this.button_取消);
            this.groupBox_添加修改.Controls.Add(this.button_添加);
            this.groupBox_添加修改.Controls.Add(this.label_折扣);
            this.groupBox_添加修改.Controls.Add(this.label_菜系);
            this.groupBox_添加修改.Controls.Add(this.label_编号);
            this.groupBox_添加修改.Location = new System.Drawing.Point(289, 8);
            this.groupBox_添加修改.Name = "groupBox_添加修改";
            this.groupBox_添加修改.Size = new System.Drawing.Size(191, 241);
            this.groupBox_添加修改.TabIndex = 5;
            this.groupBox_添加修改.TabStop = false;
            this.groupBox_添加修改.Text = "添加/修改";
            // 
            // label_需要修改的员工编号
            // 
            this.label_需要修改的员工编号.AutoSize = true;
            this.label_需要修改的员工编号.ForeColor = System.Drawing.Color.Red;
            this.label_需要修改的员工编号.Location = new System.Drawing.Point(61, 13);
            this.label_需要修改的员工编号.Name = "label_需要修改的员工编号";
            this.label_需要修改的员工编号.Size = new System.Drawing.Size(0, 12);
            this.label_需要修改的员工编号.TabIndex = 13;
            this.label_需要修改的员工编号.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "说明:选中表格某行,删除";
            // 
            // textBox_菜系
            // 
            this.textBox_菜系.Location = new System.Drawing.Point(63, 77);
            this.textBox_菜系.Name = "textBox_菜系";
            this.textBox_菜系.Size = new System.Drawing.Size(100, 21);
            this.textBox_菜系.TabIndex = 10;
            // 
            // textBox_编号
            // 
            this.textBox_编号.Location = new System.Drawing.Point(63, 28);
            this.textBox_编号.Name = "textBox_编号";
            this.textBox_编号.ReadOnly = true;
            this.textBox_编号.Size = new System.Drawing.Size(100, 21);
            this.textBox_编号.TabIndex = 9;
            // 
            // button_删除选中的菜系
            // 
            this.button_删除选中的菜系.Location = new System.Drawing.Point(18, 199);
            this.button_删除选中的菜系.Name = "button_删除选中的菜系";
            this.button_删除选中的菜系.Size = new System.Drawing.Size(154, 36);
            this.button_删除选中的菜系.TabIndex = 7;
            this.button_删除选中的菜系.Text = "删除选中的菜系";
            this.button_删除选中的菜系.UseVisualStyleBackColor = true;
            this.button_删除选中的菜系.Click += new System.EventHandler(this.button_删除选中的菜系_Click);
            // 
            // button_取消
            // 
            this.button_取消.Location = new System.Drawing.Point(113, 121);
            this.button_取消.Name = "button_取消";
            this.button_取消.Size = new System.Drawing.Size(59, 34);
            this.button_取消.TabIndex = 6;
            this.button_取消.Text = "取消";
            this.button_取消.UseVisualStyleBackColor = true;
            this.button_取消.Click += new System.EventHandler(this.button_取消_Click);
            // 
            // button_添加
            // 
            this.button_添加.Location = new System.Drawing.Point(17, 121);
            this.button_添加.Name = "button_添加";
            this.button_添加.Size = new System.Drawing.Size(59, 34);
            this.button_添加.TabIndex = 5;
            this.button_添加.Text = "添加";
            this.button_添加.UseVisualStyleBackColor = true;
            this.button_添加.Click += new System.EventHandler(this.button_添加_Click);
            // 
            // label_折扣
            // 
            this.label_折扣.AutoSize = true;
            this.label_折扣.Location = new System.Drawing.Point(16, 95);
            this.label_折扣.Name = "label_折扣";
            this.label_折扣.Size = new System.Drawing.Size(0, 12);
            this.label_折扣.TabIndex = 2;
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
            // groupBox_列表
            // 
            this.groupBox_列表.Controls.Add(this.dataGridView_菜单类型管理);
            this.groupBox_列表.Location = new System.Drawing.Point(9, 8);
            this.groupBox_列表.Name = "groupBox_列表";
            this.groupBox_列表.Size = new System.Drawing.Size(269, 241);
            this.groupBox_列表.TabIndex = 4;
            this.groupBox_列表.TabStop = false;
            this.groupBox_列表.Text = "列表";
            // 
            // dataGridView_菜单类型管理
            // 
            this.dataGridView_菜单类型管理.AllowUserToResizeColumns = false;
            this.dataGridView_菜单类型管理.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_菜单类型管理.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_菜单类型管理.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_菜单类型管理.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView_菜单类型管理.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_菜单类型管理.MultiSelect = false;
            this.dataGridView_菜单类型管理.Name = "dataGridView_菜单类型管理";
            this.dataGridView_菜单类型管理.RowHeadersWidth = 20;
            this.dataGridView_菜单类型管理.RowTemplate.Height = 23;
            this.dataGridView_菜单类型管理.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_菜单类型管理.Size = new System.Drawing.Size(257, 212);
            this.dataGridView_菜单类型管理.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DId";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DTitle";
            this.Column2.HeaderText = "菜系类型";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // 菜单类型界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 255);
            this.Controls.Add(this.groupBox_添加修改);
            this.Controls.Add(this.groupBox_列表);
            this.Name = "菜单类型界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单类型界面";
            this.Load += new System.EventHandler(this.菜单类型界面_Load);
            this.groupBox_添加修改.ResumeLayout(false);
            this.groupBox_添加修改.PerformLayout();
            this.groupBox_列表.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_菜单类型管理)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_菜系;
        private System.Windows.Forms.GroupBox groupBox_添加修改;
        private System.Windows.Forms.Label label_需要修改的员工编号;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_菜系;
        private System.Windows.Forms.TextBox textBox_编号;
        private System.Windows.Forms.Button button_删除选中的菜系;
        private System.Windows.Forms.Button button_取消;
        private System.Windows.Forms.Button button_添加;
        private System.Windows.Forms.Label label_折扣;
        private System.Windows.Forms.Label label_编号;
        private System.Windows.Forms.GroupBox groupBox_列表;
        private System.Windows.Forms.DataGridView dataGridView_菜单类型管理;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}