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
            this.btnOpenJounal = new System.Windows.Forms.Button();
            this.lblPaperCount = new System.Windows.Forms.Label();
            this.lblJournalCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog_paper = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_journal = new System.Windows.Forms.OpenFileDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // btnOpenJounal
            // 
            this.btnOpenJounal.Location = new System.Drawing.Point(616, 48);
            this.btnOpenJounal.Name = "btnOpenJounal";
            this.btnOpenJounal.Size = new System.Drawing.Size(105, 23);
            this.btnOpenJounal.TabIndex = 3;
            this.btnOpenJounal.Text = "加载分类数据";
            this.btnOpenJounal.UseVisualStyleBackColor = true;
            this.btnOpenJounal.Click += new System.EventHandler(this.btnOpenJounal_Click);
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
            this.btnStart.Location = new System.Drawing.Point(620, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "分类";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 134);
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
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(26, 166);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(293, 12);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "避免CSV格式混乱，已将Title中的双引号替换为单引号";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(22, 48);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(583, 21);
            this.txtClass.TabIndex = 9;
            // 
            // txtKey
            // 
            this.txtKey.AutoCompleteCustomSource.AddRange(new string[] {
            "Multidisciplinary",
            "MULTIDISCIPLINARY SCIENCES"});
            this.txtKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKey.Location = new System.Drawing.Point(162, 86);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(443, 21);
            this.txtKey.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "多学科对应关键词";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblJournalCount);
            this.Controls.Add(this.lblPaperCount);
            this.Controls.Add(this.btnOpenJounal);
            this.Controls.Add(this.btnOpenPaper);
            this.Controls.Add(this.cbbPapers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "论文分类";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPapers;
        private System.Windows.Forms.Button btnOpenPaper;
        private System.Windows.Forms.Button btnOpenJounal;
        private System.Windows.Forms.Label lblPaperCount;
        private System.Windows.Forms.Label lblJournalCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_paper;
        private System.Windows.Forms.OpenFileDialog openFileDialog_journal;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
    }
}

