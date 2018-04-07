namespace CaterUI
{
    partial class 主界面
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(主界面));
            this.menuStrip_主界面 = new System.Windows.Forms.MenuStrip();
            this.Menu_店员管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_会员管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_菜单管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_餐桌管理 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_付款 = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_退出 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_主界面.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_主界面
            // 
            this.menuStrip_主界面.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip_主界面.BackgroundImage")));
            this.menuStrip_主界面.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip_主界面.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.menuStrip_主界面.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_店员管理,
            this.Menu_会员管理,
            this.Menu_菜单管理,
            this.Menu_餐桌管理,
            this.Menu_付款,
            this.Menu_退出});
            this.menuStrip_主界面.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_主界面.Name = "menuStrip_主界面";
            this.menuStrip_主界面.Size = new System.Drawing.Size(617, 72);
            this.menuStrip_主界面.TabIndex = 0;
            this.menuStrip_主界面.Text = "menuStrip1";
            // 
            // Menu_店员管理
            // 
            this.Menu_店员管理.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Menu_店员管理.Image = ((System.Drawing.Image)(resources.GetObject("Menu_店员管理.Image")));
            this.Menu_店员管理.Name = "Menu_店员管理";
            this.Menu_店员管理.Size = new System.Drawing.Size(76, 68);
            this.Menu_店员管理.Text = "toolStripMenuItem1";
            this.Menu_店员管理.Click += new System.EventHandler(this.Menu_店员管理_Click);
            // 
            // Menu_会员管理
            // 
            this.Menu_会员管理.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Menu_会员管理.Image = ((System.Drawing.Image)(resources.GetObject("Menu_会员管理.Image")));
            this.Menu_会员管理.Name = "Menu_会员管理";
            this.Menu_会员管理.Size = new System.Drawing.Size(76, 68);
            this.Menu_会员管理.Text = "toolStripMenuItem1";
            this.Menu_会员管理.Click += new System.EventHandler(this.Menu_会员管理_Click);
            // 
            // Menu_菜单管理
            // 
            this.Menu_菜单管理.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Menu_菜单管理.Image = ((System.Drawing.Image)(resources.GetObject("Menu_菜单管理.Image")));
            this.Menu_菜单管理.Name = "Menu_菜单管理";
            this.Menu_菜单管理.Size = new System.Drawing.Size(76, 68);
            this.Menu_菜单管理.Text = "toolStripMenuItem1";
            this.Menu_菜单管理.Click += new System.EventHandler(this.Menu_菜单管理_Click);
            // 
            // Menu_餐桌管理
            // 
            this.Menu_餐桌管理.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Menu_餐桌管理.Image = ((System.Drawing.Image)(resources.GetObject("Menu_餐桌管理.Image")));
            this.Menu_餐桌管理.Name = "Menu_餐桌管理";
            this.Menu_餐桌管理.Size = new System.Drawing.Size(76, 68);
            this.Menu_餐桌管理.Text = "toolStripMenuItem1";
            // 
            // Menu_付款
            // 
            this.Menu_付款.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Menu_付款.Image = ((System.Drawing.Image)(resources.GetObject("Menu_付款.Image")));
            this.Menu_付款.Name = "Menu_付款";
            this.Menu_付款.Size = new System.Drawing.Size(76, 68);
            this.Menu_付款.Text = "toolStripMenuItem1";
            // 
            // Menu_退出
            // 
            this.Menu_退出.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Menu_退出.Image = ((System.Drawing.Image)(resources.GetObject("Menu_退出.Image")));
            this.Menu_退出.Name = "Menu_退出";
            this.Menu_退出.Size = new System.Drawing.Size(76, 68);
            this.Menu_退出.Text = "toolStripMenuItem2";
            this.Menu_退出.Click += new System.EventHandler(this.Menu_退出_Click);
            // 
            // 主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 261);
            this.Controls.Add(this.menuStrip_主界面);
            this.MainMenuStrip = this.menuStrip_主界面;
            this.Name = "主界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.主界面_FormClosed);
            this.Load += new System.EventHandler(this.主界面_Load);
            this.menuStrip_主界面.ResumeLayout(false);
            this.menuStrip_主界面.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_主界面;
        private System.Windows.Forms.ToolStripMenuItem Menu_店员管理;
        private System.Windows.Forms.ToolStripMenuItem Menu_会员管理;
        private System.Windows.Forms.ToolStripMenuItem Menu_菜单管理;
        private System.Windows.Forms.ToolStripMenuItem Menu_餐桌管理;
        private System.Windows.Forms.ToolStripMenuItem Menu_付款;
        private System.Windows.Forms.ToolStripMenuItem Menu_退出;
    }
}