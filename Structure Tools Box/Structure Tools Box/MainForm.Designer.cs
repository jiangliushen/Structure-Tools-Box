namespace Structure_Tools_Box
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbMergeExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbParentCount = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMergeExcel,
            this.toolStripSeparator1,
            this.tsbParentCount,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 93);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbMergeExcel
            // 
            this.tsbMergeExcel.AutoSize = false;
            this.tsbMergeExcel.Image = global::Structure_Tools_Box.Properties.Resources.excelmerge;
            this.tsbMergeExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMergeExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMergeExcel.Name = "tsbMergeExcel";
            this.tsbMergeExcel.Size = new System.Drawing.Size(76, 90);
            this.tsbMergeExcel.Text = "表格合并";
            this.tsbMergeExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbMergeExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbMergeExcel.Click += new System.EventHandler(this.tsbMergeExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // tsbParentCount
            // 
            this.tsbParentCount.Image = global::Structure_Tools_Box.Properties.Resources.parentcount;
            this.tsbParentCount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbParentCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbParentCount.Name = "tsbParentCount";
            this.tsbParentCount.Size = new System.Drawing.Size(84, 90);
            this.tsbParentCount.Text = "型材数量统计";
            this.tsbParentCount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbParentCount.Click += new System.EventHandler(this.tsbParentCount_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 93);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 94);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure Tools";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbMergeExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbParentCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

