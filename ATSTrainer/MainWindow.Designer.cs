
namespace ATSTrainer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.SetMoney = new System.Windows.Forms.Button();
            this.MoneyAmount = new System.Windows.Forms.TextBox();
            this.SetEXP = new System.Windows.Forms.Button();
            this.EXPAmount = new System.Windows.Forms.TextBox();
            this.MyPFP = new System.Windows.Forms.PictureBox();
            this.MadeBy = new System.Windows.Forms.Label();
            this.GameFound = new System.Windows.Forms.Label();
            this.ProcOpenLabel = new System.Windows.Forms.Label();
            this.Instructions = new System.Windows.Forms.Label();
            this.rgch = new System.Windows.Forms.CheckBox();
            this.rmd = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyPFP)).BeginInit();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // SetMoney
            // 
            this.SetMoney.Location = new System.Drawing.Point(327, 12);
            this.SetMoney.Name = "SetMoney";
            this.SetMoney.Size = new System.Drawing.Size(80, 29);
            this.SetMoney.TabIndex = 0;
            this.SetMoney.Text = "SetMoney";
            this.SetMoney.UseVisualStyleBackColor = true;
            this.SetMoney.Click += new System.EventHandler(this.SetMoney_Click);
            // 
            // MoneyAmount
            // 
            this.MoneyAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoneyAmount.Location = new System.Drawing.Point(12, 12);
            this.MoneyAmount.Name = "MoneyAmount";
            this.MoneyAmount.Size = new System.Drawing.Size(298, 29);
            this.MoneyAmount.TabIndex = 1;
            // 
            // SetEXP
            // 
            this.SetEXP.Location = new System.Drawing.Point(327, 47);
            this.SetEXP.Name = "SetEXP";
            this.SetEXP.Size = new System.Drawing.Size(80, 30);
            this.SetEXP.TabIndex = 2;
            this.SetEXP.Text = "SetEXP";
            this.SetEXP.UseVisualStyleBackColor = true;
            this.SetEXP.Click += new System.EventHandler(this.SetEXP_Click);
            // 
            // EXPAmount
            // 
            this.EXPAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EXPAmount.Location = new System.Drawing.Point(12, 48);
            this.EXPAmount.Name = "EXPAmount";
            this.EXPAmount.Size = new System.Drawing.Size(298, 29);
            this.EXPAmount.TabIndex = 3;
            // 
            // MyPFP
            // 
            this.MyPFP.Image = ((System.Drawing.Image)(resources.GetObject("MyPFP.Image")));
            this.MyPFP.Location = new System.Drawing.Point(12, 150);
            this.MyPFP.Name = "MyPFP";
            this.MyPFP.Size = new System.Drawing.Size(80, 80);
            this.MyPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPFP.TabIndex = 4;
            this.MyPFP.TabStop = false;
            // 
            // MadeBy
            // 
            this.MadeBy.AutoSize = true;
            this.MadeBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MadeBy.Location = new System.Drawing.Point(98, 209);
            this.MadeBy.Name = "MadeBy";
            this.MadeBy.Size = new System.Drawing.Size(165, 21);
            this.MadeBy.TabIndex = 5;
            this.MadeBy.Text = "Made By Saniee#0007";
            // 
            // GameFound
            // 
            this.GameFound.AutoSize = true;
            this.GameFound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameFound.Location = new System.Drawing.Point(98, 176);
            this.GameFound.Name = "GameFound";
            this.GameFound.Size = new System.Drawing.Size(113, 21);
            this.GameFound.TabIndex = 6;
            this.GameFound.Text = "Game Found? :";
            // 
            // ProcOpenLabel
            // 
            this.ProcOpenLabel.AutoSize = true;
            this.ProcOpenLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcOpenLabel.ForeColor = System.Drawing.Color.Red;
            this.ProcOpenLabel.Location = new System.Drawing.Point(217, 176);
            this.ProcOpenLabel.Name = "ProcOpenLabel";
            this.ProcOpenLabel.Size = new System.Drawing.Size(38, 21);
            this.ProcOpenLabel.TabIndex = 7;
            this.ProcOpenLabel.Text = "N/A";
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Instructions.ForeColor = System.Drawing.Color.Green;
            this.Instructions.Location = new System.Drawing.Point(161, 134);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(246, 42);
            this.Instructions.TabIndex = 8;
            this.Instructions.Text = "To see the changes,\r\ngo into the map and then go back.";
            // 
            // rgch
            // 
            this.rgch.AutoSize = true;
            this.rgch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgch.Location = new System.Drawing.Point(12, 84);
            this.rgch.Name = "rgch";
            this.rgch.Size = new System.Drawing.Size(238, 25);
            this.rgch.TabIndex = 9;
            this.rgch.Text = "Remove Garage Money Check";
            this.rgch.UseVisualStyleBackColor = true;
            this.rgch.CheckedChanged += new System.EventHandler(this.rgch_CheckedChanged);
            // 
            // rmd
            // 
            this.rmd.AutoSize = true;
            this.rmd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rmd.Location = new System.Drawing.Point(12, 112);
            this.rmd.Name = "rmd";
            this.rmd.Size = new System.Drawing.Size(211, 25);
            this.rmd.TabIndex = 10;
            this.rmd.Text = "Reverse Money Deduction";
            this.rmd.UseVisualStyleBackColor = true;
            this.rmd.CheckedChanged += new System.EventHandler(this.rmd_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 242);
            this.Controls.Add(this.rmd);
            this.Controls.Add(this.rgch);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.ProcOpenLabel);
            this.Controls.Add(this.GameFound);
            this.Controls.Add(this.MadeBy);
            this.Controls.Add(this.MyPFP);
            this.Controls.Add(this.EXPAmount);
            this.Controls.Add(this.SetEXP);
            this.Controls.Add(this.MoneyAmount);
            this.Controls.Add(this.SetMoney);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "ATS Trainer (By Saniee)";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MyPFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Button SetMoney;
        private System.Windows.Forms.TextBox MoneyAmount;
        private System.Windows.Forms.Button SetEXP;
        private System.Windows.Forms.TextBox EXPAmount;
        private System.Windows.Forms.PictureBox MyPFP;
        private System.Windows.Forms.Label MadeBy;
        private System.Windows.Forms.Label GameFound;
        private System.Windows.Forms.Label ProcOpenLabel;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.CheckBox rgch;
        private System.Windows.Forms.CheckBox rmd;
    }
}

