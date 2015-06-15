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
            this.cbbJournal = new System.Windows.Forms.ComboBox();
            this.lblPaperCount = new System.Windows.Forms.Label();
            this.lblJournalCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog_paper = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_journal = new System.Windows.Forms.OpenFileDialog();
            this.lblMessage = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
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
            this.btnOpenPaper.Location = new System.Drawing.Point(616, 12);
            this.btnOpenPaper.Name = "btnOpenPaper";
            this.btnOpenPaper.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPaper.TabIndex = 1;
            this.btnOpenPaper.Text = "加载论文";
            this.btnOpenPaper.UseVisualStyleBackColor = true;
            this.btnOpenPaper.Click += new System.EventHandler(this.btnOpenPaper_Click);
            // 
            // btnOpenJounal
            // 
            this.btnOpenJounal.Location = new System.Drawing.Point(616, 50);
            this.btnOpenJounal.Name = "btnOpenJounal";
            this.btnOpenJounal.Size = new System.Drawing.Size(75, 23);
            this.btnOpenJounal.TabIndex = 3;
            this.btnOpenJounal.Text = "加载分类数据";
            this.btnOpenJounal.UseVisualStyleBackColor = true;
            this.btnOpenJounal.Click += new System.EventHandler(this.btnOpenJounal_Click);
            // 
            // cbbJournal
            // 
            this.cbbJournal.FormattingEnabled = true;
            this.cbbJournal.Location = new System.Drawing.Point(22, 51);
            this.cbbJournal.Name = "cbbJournal";
            this.cbbJournal.Size = new System.Drawing.Size(583, 20);
            this.cbbJournal.TabIndex = 2;
            // 
            // lblPaperCount
            // 
            this.lblPaperCount.AutoSize = true;
            this.lblPaperCount.Location = new System.Drawing.Point(707, 22);
            this.lblPaperCount.Name = "lblPaperCount";
            this.lblPaperCount.Size = new System.Drawing.Size(11, 12);
            this.lblPaperCount.TabIndex = 4;
            this.lblPaperCount.Text = "0";
            // 
            // lblJournalCount
            // 
            this.lblJournalCount.AutoSize = true;
            this.lblJournalCount.Location = new System.Drawing.Point(707, 61);
            this.lblJournalCount.Name = "lblJournalCount";
            this.lblJournalCount.Size = new System.Drawing.Size(11, 12);
            this.lblJournalCount.TabIndex = 5;
            this.lblJournalCount.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(616, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "分类";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 142);
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
            this.openFileDialog_journal.Multiselect = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(31, 117);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 12);
            this.lblMessage.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 178);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblJournalCount);
            this.Controls.Add(this.lblPaperCount);
            this.Controls.Add(this.btnOpenJounal);
            this.Controls.Add(this.cbbJournal);
            this.Controls.Add(this.btnOpenPaper);
            this.Controls.Add(this.cbbPapers);
            this.Name = "Form1";
            this.Text = "论文分类";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPapers;
        private System.Windows.Forms.Button btnOpenPaper;
        private System.Windows.Forms.Button btnOpenJounal;
        private System.Windows.Forms.ComboBox cbbJournal;
        private System.Windows.Forms.Label lblPaperCount;
        private System.Windows.Forms.Label lblJournalCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_paper;
        private System.Windows.Forms.OpenFileDialog openFileDialog_journal;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

