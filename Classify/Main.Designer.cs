namespace Classify
{
    partial class Main
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
            this.cbbPapers = new System.Windows.Forms.ComboBox();
            this.btnOpenPaper = new System.Windows.Forms.Button();
            this.btnOpenJournal = new System.Windows.Forms.Button();
            this.lblPaperCount = new System.Windows.Forms.Label();
            this.lblJournalCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog_paper = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_journal = new System.Windows.Forms.OpenFileDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtJournal = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRatioThirdClass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRatioSecendClass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinReferenceCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbPapers
            // 
            this.cbbPapers.FormattingEnabled = true;
            this.cbbPapers.Location = new System.Drawing.Point(22, 13);
            this.cbbPapers.Name = "cbbPapers";
            this.cbbPapers.Size = new System.Drawing.Size(583, 20);
            this.cbbPapers.TabIndex = 0;
            // 
            // btnOpenPaper
            // 
            this.btnOpenPaper.Location = new System.Drawing.Point(616, 10);
            this.btnOpenPaper.Name = "btnOpenPaper";
            this.btnOpenPaper.Size = new System.Drawing.Size(105, 23);
            this.btnOpenPaper.TabIndex = 1;
            this.btnOpenPaper.Text = "加载论文";
            this.btnOpenPaper.UseVisualStyleBackColor = true;
            this.btnOpenPaper.Click += new System.EventHandler(this.btnOpenPaper_Click);
            // 
            // btnOpenJournal
            // 
            this.btnOpenJournal.Location = new System.Drawing.Point(616, 48);
            this.btnOpenJournal.Name = "btnOpenJournal";
            this.btnOpenJournal.Size = new System.Drawing.Size(105, 23);
            this.btnOpenJournal.TabIndex = 3;
            this.btnOpenJournal.Text = "加载分类数据";
            this.btnOpenJournal.UseVisualStyleBackColor = true;
            this.btnOpenJournal.Click += new System.EventHandler(this.btnOpenJounal_Click);
            // 
            // lblPaperCount
            // 
            this.lblPaperCount.AutoSize = true;
            this.lblPaperCount.Location = new System.Drawing.Point(727, 16);
            this.lblPaperCount.Name = "lblPaperCount";
            this.lblPaperCount.Size = new System.Drawing.Size(11, 12);
            this.lblPaperCount.TabIndex = 4;
            this.lblPaperCount.Text = "0";
            // 
            // lblJournalCount
            // 
            this.lblJournalCount.AutoSize = true;
            this.lblJournalCount.Location = new System.Drawing.Point(727, 55);
            this.lblJournalCount.Name = "lblJournalCount";
            this.lblJournalCount.Size = new System.Drawing.Size(11, 12);
            this.lblJournalCount.TabIndex = 5;
            this.lblJournalCount.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(620, 140);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "分类";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(748, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // openFileDialog_paper
            // 
            this.openFileDialog_paper.Multiselect = true;
            // 
            // openFileDialog_journal
            // 
            this.openFileDialog_journal.FileName = "openFileDialog2";
            this.openFileDialog_journal.Filter = "CSV|*.csv|All Files|*.*";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(26, 202);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(293, 12);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "避免CSV格式混乱，已将Title中的双引号替换为单引号";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // txtJournal
            // 
            this.txtJournal.Location = new System.Drawing.Point(22, 48);
            this.txtJournal.Name = "txtJournal";
            this.txtJournal.Size = new System.Drawing.Size(583, 21);
            this.txtJournal.TabIndex = 9;
            this.txtJournal.TextChanged += new System.EventHandler(this.txtClass_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.AutoCompleteCustomSource.AddRange(new string[] {
            "Multidisciplinary",
            "MULTIDISCIPLINARY SCIENCES"});
            this.txtKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKey.Location = new System.Drawing.Point(162, 140);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(443, 21);
            this.txtKey.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "多学科对应关键词 ？";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRatioThirdClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRatioSecendClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMinReferenceCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(22, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 48);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "阈值";
            // 
            // txtRatioThirdClass
            // 
            this.txtRatioThirdClass.AutoCompleteCustomSource.AddRange(new string[] {
            "Multidisciplinary",
            "MULTIDISCIPLINARY SCIENCES"});
            this.txtRatioThirdClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRatioThirdClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRatioThirdClass.Location = new System.Drawing.Point(515, 17);
            this.txtRatioThirdClass.Name = "txtRatioThirdClass";
            this.txtRatioThirdClass.Size = new System.Drawing.Size(66, 21);
            this.txtRatioThirdClass.TabIndex = 17;
            this.txtRatioThirdClass.Text = "1.4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "第三个学科";
            // 
            // txtRatioSecendClass
            // 
            this.txtRatioSecendClass.AutoCompleteCustomSource.AddRange(new string[] {
            "Multidisciplinary",
            "MULTIDISCIPLINARY SCIENCES"});
            this.txtRatioSecendClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRatioSecendClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRatioSecendClass.Location = new System.Drawing.Point(335, 17);
            this.txtRatioSecendClass.Name = "txtRatioSecendClass";
            this.txtRatioSecendClass.Size = new System.Drawing.Size(66, 21);
            this.txtRatioSecendClass.TabIndex = 15;
            this.txtRatioSecendClass.Text = "1.2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "第二个学科";
            // 
            // txtMinReferenceCount
            // 
            this.txtMinReferenceCount.AutoCompleteCustomSource.AddRange(new string[] {
            "Multidisciplinary",
            "MULTIDISCIPLINARY SCIENCES"});
            this.txtMinReferenceCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMinReferenceCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMinReferenceCount.Location = new System.Drawing.Point(155, 17);
            this.txtMinReferenceCount.Name = "txtMinReferenceCount";
            this.txtMinReferenceCount.Size = new System.Drawing.Size(66, 21);
            this.txtMinReferenceCount.TabIndex = 13;
            this.txtMinReferenceCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "参考文献数(0表示不限制)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtJournal);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblJournalCount);
            this.Controls.Add(this.lblPaperCount);
            this.Controls.Add(this.btnOpenJournal);
            this.Controls.Add(this.btnOpenPaper);
            this.Controls.Add(this.cbbPapers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "论文分类";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPapers;
        private System.Windows.Forms.Button btnOpenPaper;
        private System.Windows.Forms.Button btnOpenJournal;
        private System.Windows.Forms.Label lblPaperCount;
        private System.Windows.Forms.Label lblJournalCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_paper;
        private System.Windows.Forms.OpenFileDialog openFileDialog_journal;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtJournal;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRatioThirdClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRatioSecendClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinReferenceCount;
        private System.Windows.Forms.Label label2;
    }
}

