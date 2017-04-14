namespace LicenseGen
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdEndDate = new System.Windows.Forms.RadioButton();
            this.rdEndDateY = new System.Windows.Forms.RadioButton();
            this.datepickEndDate = new System.Windows.Forms.DateTimePicker();
            this.datepickIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutPath = new System.Windows.Forms.TextBox();
            this.btSelectDir = new System.Windows.Forms.Button();
            this.btGen = new System.Windows.Forms.Button();
            this.tbHdCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司:";
            // 
            // tbCompany
            // 
            this.tbCompany.Font = new System.Drawing.Font("宋体", 12F);
            this.tbCompany.Location = new System.Drawing.Point(130, 47);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(251, 26);
            this.tbCompany.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(45, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "授权日期:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datepickEndDate);
            this.groupBox1.Controls.Add(this.rdEndDateY);
            this.groupBox1.Controls.Add(this.rdEndDate);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.groupBox1.Location = new System.Drawing.Point(39, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "截止日期：";
            // 
            // rdEndDate
            // 
            this.rdEndDate.AutoSize = true;
            this.rdEndDate.Checked = true;
            this.rdEndDate.Font = new System.Drawing.Font("宋体", 12F);
            this.rdEndDate.Location = new System.Drawing.Point(10, 30);
            this.rdEndDate.Name = "rdEndDate";
            this.rdEndDate.Size = new System.Drawing.Size(74, 20);
            this.rdEndDate.TabIndex = 4;
            this.rdEndDate.TabStop = true;
            this.rdEndDate.Text = "无期限";
            this.rdEndDate.UseVisualStyleBackColor = true;
            this.rdEndDate.CheckedChanged += new System.EventHandler(this.endDateCheckedChanged);
            // 
            // rdEndDateY
            // 
            this.rdEndDateY.AutoSize = true;
            this.rdEndDateY.Font = new System.Drawing.Font("宋体", 12F);
            this.rdEndDateY.Location = new System.Drawing.Point(9, 58);
            this.rdEndDateY.Name = "rdEndDateY";
            this.rdEndDateY.Size = new System.Drawing.Size(74, 20);
            this.rdEndDateY.TabIndex = 4;
            this.rdEndDateY.Text = "有期限";
            this.rdEndDateY.UseVisualStyleBackColor = true;
            this.rdEndDateY.CheckedChanged += new System.EventHandler(this.endDateCheckedChanged);
            // 
            // datepickEndDate
            // 
            this.datepickEndDate.Enabled = false;
            this.datepickEndDate.Font = new System.Drawing.Font("宋体", 12F);
            this.datepickEndDate.Location = new System.Drawing.Point(91, 53);
            this.datepickEndDate.Name = "datepickEndDate";
            this.datepickEndDate.Size = new System.Drawing.Size(200, 26);
            this.datepickEndDate.TabIndex = 5;
            // 
            // datepickIssueDate
            // 
            this.datepickIssueDate.Font = new System.Drawing.Font("宋体", 12F);
            this.datepickIssueDate.Location = new System.Drawing.Point(130, 81);
            this.datepickIssueDate.Name = "datepickIssueDate";
            this.datepickIssueDate.Size = new System.Drawing.Size(200, 26);
            this.datepickIssueDate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(46, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "输出目录:";
            // 
            // tbOutPath
            // 
            this.tbOutPath.Font = new System.Drawing.Font("宋体", 12F);
            this.tbOutPath.Location = new System.Drawing.Point(130, 291);
            this.tbOutPath.Name = "tbOutPath";
            this.tbOutPath.ReadOnly = true;
            this.tbOutPath.Size = new System.Drawing.Size(251, 26);
            this.tbOutPath.TabIndex = 9;
            // 
            // btSelectDir
            // 
            this.btSelectDir.Location = new System.Drawing.Point(388, 293);
            this.btSelectDir.Name = "btSelectDir";
            this.btSelectDir.Size = new System.Drawing.Size(75, 23);
            this.btSelectDir.TabIndex = 10;
            this.btSelectDir.Text = "选择";
            this.btSelectDir.UseVisualStyleBackColor = true;
            this.btSelectDir.Click += new System.EventHandler(this.btSelectDir_Click);
            // 
            // btGen
            // 
            this.btGen.Font = new System.Drawing.Font("宋体", 12F);
            this.btGen.Location = new System.Drawing.Point(51, 328);
            this.btGen.Name = "btGen";
            this.btGen.Size = new System.Drawing.Size(330, 55);
            this.btGen.TabIndex = 11;
            this.btGen.Text = "生成";
            this.btGen.UseVisualStyleBackColor = true;
            this.btGen.Click += new System.EventHandler(this.btGen_Click);
            // 
            // tbHdCode
            // 
            this.tbHdCode.Font = new System.Drawing.Font("宋体", 12F);
            this.tbHdCode.Location = new System.Drawing.Point(130, 224);
            this.tbHdCode.Name = "tbHdCode";
            this.tbHdCode.Size = new System.Drawing.Size(251, 26);
            this.tbHdCode.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(46, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "机器码:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 468);
            this.Controls.Add(this.tbHdCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGen);
            this.Controls.Add(this.btSelectDir);
            this.Controls.Add(this.tbOutPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datepickIssueDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCompany);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "授权生成器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdEndDateY;
        private System.Windows.Forms.RadioButton rdEndDate;
        private System.Windows.Forms.DateTimePicker datepickEndDate;
        private System.Windows.Forms.DateTimePicker datepickIssueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOutPath;
        private System.Windows.Forms.Button btSelectDir;
        private System.Windows.Forms.Button btGen;
        private System.Windows.Forms.TextBox tbHdCode;
        private System.Windows.Forms.Label label4;
    }
}

