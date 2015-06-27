namespace Batch_WAV_to_OGG_Converter
{
    partial class frmMain
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
            this.grpStep1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnChooseSource = new System.Windows.Forms.Button();
            this.grpBegin = new System.Windows.Forms.GroupBox();
            this.convertProgress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grpStep1.SuspendLayout();
            this.grpBegin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStep1
            // 
            this.grpStep1.Controls.Add(this.label1);
            this.grpStep1.Controls.Add(this.label2);
            this.grpStep1.Controls.Add(this.txtSource);
            this.grpStep1.Controls.Add(this.btnChooseSource);
            this.grpStep1.Location = new System.Drawing.Point(5, 2);
            this.grpStep1.Name = "grpStep1";
            this.grpStep1.Size = new System.Drawing.Size(380, 83);
            this.grpStep1.TabIndex = 5;
            this.grpStep1.TabStop = false;
            this.grpStep1.Text = "Step 1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the folder with the .wav files you wish to convert to .ogg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(57, 52);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(242, 20);
            this.txtSource.TabIndex = 0;
            // 
            // btnChooseSource
            // 
            this.btnChooseSource.Location = new System.Drawing.Point(305, 50);
            this.btnChooseSource.Name = "btnChooseSource";
            this.btnChooseSource.Size = new System.Drawing.Size(69, 23);
            this.btnChooseSource.TabIndex = 2;
            this.btnChooseSource.Text = "Browse";
            this.btnChooseSource.UseVisualStyleBackColor = true;
            this.btnChooseSource.Click += new System.EventHandler(this.btnChooseSource_Click);
            // 
            // grpBegin
            // 
            this.grpBegin.Controls.Add(this.convertProgress);
            this.grpBegin.Controls.Add(this.label3);
            this.grpBegin.Controls.Add(this.btnConvert);
            this.grpBegin.Location = new System.Drawing.Point(5, 91);
            this.grpBegin.Name = "grpBegin";
            this.grpBegin.Size = new System.Drawing.Size(380, 83);
            this.grpBegin.TabIndex = 6;
            this.grpBegin.TabStop = false;
            this.grpBegin.Text = "Step 2";
            this.grpBegin.Visible = false;
            // 
            // convertProgress
            // 
            this.convertProgress.Location = new System.Drawing.Point(9, 50);
            this.convertProgress.Name = "convertProgress";
            this.convertProgress.Size = new System.Drawing.Size(365, 23);
            this.convertProgress.TabIndex = 3;
            this.convertProgress.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Click the button below to begin. Your wav files will be moved into a new folder a" +
    "nd replaced with .ogg files.";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(161, 50);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(69, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 183);
            this.Controls.Add(this.grpBegin);
            this.Controls.Add(this.grpStep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Ascension Game Dev Batch WAV to OGG Converter";
            this.grpStep1.ResumeLayout(false);
            this.grpStep1.PerformLayout();
            this.grpBegin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStep1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnChooseSource;
        private System.Windows.Forms.GroupBox grpBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ProgressBar convertProgress;
    }
}

