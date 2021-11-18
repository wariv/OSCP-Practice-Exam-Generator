
namespace OSCP_Practice_Exam_Generator
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.cbVuln = new System.Windows.Forms.CheckBox();
            this.cbPG = new System.Windows.Forms.CheckBox();
            this.cbHTB = new System.Windows.Forms.CheckBox();
            this.cbHarder = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(12, 258);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(295, 39);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Create Practice Exam";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbOut
            // 
            this.rtbOut.Location = new System.Drawing.Point(12, 39);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(295, 213);
            this.rtbOut.TabIndex = 1;
            this.rtbOut.Text = "";
            // 
            // cbVuln
            // 
            this.cbVuln.AutoSize = true;
            this.cbVuln.Location = new System.Drawing.Point(12, 16);
            this.cbVuln.Name = "cbVuln";
            this.cbVuln.Size = new System.Drawing.Size(67, 17);
            this.cbVuln.TabIndex = 2;
            this.cbVuln.Text = "VulnHub";
            this.cbVuln.UseVisualStyleBackColor = true;
            // 
            // cbPG
            // 
            this.cbPG.AutoSize = true;
            this.cbPG.Checked = true;
            this.cbPG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPG.Location = new System.Drawing.Point(85, 16);
            this.cbPG.Name = "cbPG";
            this.cbPG.Size = new System.Drawing.Size(105, 17);
            this.cbPG.TabIndex = 3;
            this.cbPG.Text = "Proving Grounds";
            this.cbPG.UseVisualStyleBackColor = true;
            // 
            // cbHTB
            // 
            this.cbHTB.AutoSize = true;
            this.cbHTB.Checked = true;
            this.cbHTB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHTB.Location = new System.Drawing.Point(196, 16);
            this.cbHTB.Name = "cbHTB";
            this.cbHTB.Size = new System.Drawing.Size(91, 17);
            this.cbHTB.TabIndex = 4;
            this.cbHTB.Text = "Hack the Box";
            this.cbHTB.UseVisualStyleBackColor = true;
            // 
            // cbHarder
            // 
            this.cbHarder.AutoSize = true;
            this.cbHarder.Location = new System.Drawing.Point(463, 12);
            this.cbHarder.Name = "cbHarder";
            this.cbHarder.Size = new System.Drawing.Size(131, 17);
            this.cbHarder.TabIndex = 5;
            this.cbHarder.Text = "Include harder boxes?";
            this.cbHarder.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(98, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblStopWatch);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Location = new System.Drawing.Point(313, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timer";
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.AutoSize = true;
            this.lblStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopWatch.Location = new System.Drawing.Point(93, 76);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(80, 24);
            this.lblStopWatch.TabIndex = 9;
            this.lblStopWatch.Text = "00:00:00";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(179, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Enabled = true;
            this.lblTimer.Tick += new System.EventHandler(this.lblTimer_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(313, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(292, 110);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(618, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 324);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbHarder);
            this.Controls.Add(this.cbHTB);
            this.Controls.Add(this.cbPG);
            this.Controls.Add(this.cbVuln);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.btnGenerate);
            this.Name = "form1";
            this.Text = "Practice Exam Generator";
            this.Load += new System.EventHandler(this.form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.CheckBox cbVuln;
        private System.Windows.Forms.CheckBox cbPG;
        private System.Windows.Forms.CheckBox cbHTB;
        private System.Windows.Forms.CheckBox cbHarder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer lblTimer;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

