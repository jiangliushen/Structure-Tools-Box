namespace Structure_Tools_Box
{
    partial class ParentCountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentCountForm));
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.rtbCount = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFinish = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(524, 56);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开文件夹";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件路径：";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(134, 56);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(370, 21);
            this.tbFile.TabIndex = 2;
            // 
            // rtbCount
            // 
            this.rtbCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCount.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbCount.Location = new System.Drawing.Point(134, 107);
            this.rtbCount.Name = "rtbCount";
            this.rtbCount.Size = new System.Drawing.Size(306, 120);
            this.rtbCount.TabIndex = 12;
            this.rtbCount.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "单张图纸：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "总根数：";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(134, 248);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 21);
            this.tbCount.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "打开数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbFinish
            // 
            this.tbFinish.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbFinish.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFinish.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFinish.Location = new System.Drawing.Point(553, 293);
            this.tbFinish.Name = "tbFinish";
            this.tbFinish.Size = new System.Drawing.Size(69, 16);
            this.tbFinish.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(81, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "进度条:";
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(134, 298);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(400, 10);
            this.pgb.TabIndex = 24;
            // 
            // ParentCountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 321);
            this.Controls.Add(this.tbFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbCount);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentCountForm";
            this.Text = "型材数量统计—SHEN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.RichTextBox rtbCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pgb;
    }
}

