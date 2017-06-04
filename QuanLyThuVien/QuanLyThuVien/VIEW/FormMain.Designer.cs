namespace QuanLyThuVien
{
    partial class FormMain
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Độc Giả");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Sách");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mượn Trả Sách");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hướng Dẫn");
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tre = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(146, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(615, 497);
            this.pnlMain.TabIndex = 0;
            // 
            // tre
            // 
            this.tre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tre.Dock = System.Windows.Forms.DockStyle.Left;
            this.tre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tre.Location = new System.Drawing.Point(0, 0);
            this.tre.Name = "tre";
            treeNode5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            treeNode5.Name = "docgia";
            treeNode5.Text = "Độc Giả";
            treeNode6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            treeNode6.Name = "sach";
            treeNode6.Text = "Sách";
            treeNode7.Name = "muonsach";
            treeNode7.Text = "Mượn Trả Sách";
            treeNode8.Name = "huongdan";
            treeNode8.Text = "Hướng Dẫn";
            this.tre.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.tre.Size = new System.Drawing.Size(146, 497);
            this.tre.TabIndex = 29;
            this.tre.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tre_AfterSelect);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 497);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tre);
            this.Name = "FormMain";
            this.Text = "Phần mềm - Quản lý thư viện";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TreeView tre;
    }
}

