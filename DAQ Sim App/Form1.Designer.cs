
namespace DAQ_Sim_App_1
{
    partial class Form1
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
            this.gBxSampling = new System.Windows.Forms.GroupBox();
            this.lblSampling = new System.Windows.Forms.Label();
            this.btnSampling = new System.Windows.Forms.Button();
            this.txtSampling = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gBxLogging = new System.Windows.Forms.GroupBox();
            this.lblLogging = new System.Windows.Forms.Label();
            this.btnLogging = new System.Windows.Forms.Button();
            this.txtLogging = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gBxSenVal = new System.Windows.Forms.GroupBox();
            this.txtSenVal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.tmrSampling = new System.Windows.Forms.Timer(this.components);
            this.tmrLogging = new System.Windows.Forms.Timer(this.components);
            this.lblNotice = new System.Windows.Forms.Label();
            this.lblNoticeL = new System.Windows.Forms.Label();
            this.lblNoticeS = new System.Windows.Forms.Label();
            this.gBxSampling.SuspendLayout();
            this.gBxLogging.SuspendLayout();
            this.gBxSenVal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBxSampling
            // 
            this.gBxSampling.Controls.Add(this.lblSampling);
            this.gBxSampling.Controls.Add(this.btnSampling);
            this.gBxSampling.Controls.Add(this.txtSampling);
            this.gBxSampling.Controls.Add(this.groupBox2);
            this.gBxSampling.Location = new System.Drawing.Point(38, 67);
            this.gBxSampling.Name = "gBxSampling";
            this.gBxSampling.Size = new System.Drawing.Size(399, 173);
            this.gBxSampling.TabIndex = 0;
            this.gBxSampling.TabStop = false;
            this.gBxSampling.Text = "Sampling";
            // 
            // lblSampling
            // 
            this.lblSampling.AutoSize = true;
            this.lblSampling.Location = new System.Drawing.Point(18, 50);
            this.lblSampling.Name = "lblSampling";
            this.lblSampling.Size = new System.Drawing.Size(188, 25);
            this.lblSampling.TabIndex = 3;
            this.lblSampling.Text = "Next Sampling Time";
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(23, 110);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(171, 36);
            this.btnSampling.TabIndex = 2;
            this.btnSampling.Text = "Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            this.btnSampling.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // txtSampling
            // 
            this.txtSampling.Location = new System.Drawing.Point(226, 47);
            this.txtSampling.Name = "txtSampling";
            this.txtSampling.Size = new System.Drawing.Size(156, 29);
            this.txtSampling.TabIndex = 1;
            this.txtSampling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSampling.TextChanged += new System.EventHandler(this.txtSampling_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(59, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gBxLogging
            // 
            this.gBxLogging.Controls.Add(this.lblLogging);
            this.gBxLogging.Controls.Add(this.btnLogging);
            this.gBxLogging.Controls.Add(this.txtLogging);
            this.gBxLogging.Controls.Add(this.groupBox3);
            this.gBxLogging.Location = new System.Drawing.Point(38, 268);
            this.gBxLogging.Name = "gBxLogging";
            this.gBxLogging.Size = new System.Drawing.Size(399, 173);
            this.gBxLogging.TabIndex = 1;
            this.gBxLogging.TabStop = false;
            this.gBxLogging.Text = "Logging";
            // 
            // lblLogging
            // 
            this.lblLogging.AutoSize = true;
            this.lblLogging.Location = new System.Drawing.Point(18, 50);
            this.lblLogging.Name = "lblLogging";
            this.lblLogging.Size = new System.Drawing.Size(176, 25);
            this.lblLogging.TabIndex = 3;
            this.lblLogging.Text = "Next Logging Time";
            // 
            // btnLogging
            // 
            this.btnLogging.Location = new System.Drawing.Point(23, 110);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(171, 36);
            this.btnLogging.TabIndex = 2;
            this.btnLogging.Text = "Logging on File";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click);
            // 
            // txtLogging
            // 
            this.txtLogging.Location = new System.Drawing.Point(226, 47);
            this.txtLogging.Name = "txtLogging";
            this.txtLogging.Size = new System.Drawing.Size(156, 29);
            this.txtLogging.TabIndex = 1;
            this.txtLogging.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogging.TextChanged += new System.EventHandler(this.txtLogging_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(59, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(8, 8);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // gBxSenVal
            // 
            this.gBxSenVal.Controls.Add(this.txtSenVal);
            this.gBxSenVal.Location = new System.Drawing.Point(466, 67);
            this.gBxSenVal.Name = "gBxSenVal";
            this.gBxSenVal.Size = new System.Drawing.Size(348, 395);
            this.gBxSenVal.TabIndex = 2;
            this.gBxSenVal.TabStop = false;
            this.gBxSenVal.Text = "SensorValues";
            // 
            // txtSenVal
            // 
            this.txtSenVal.Location = new System.Drawing.Point(17, 28);
            this.txtSenVal.Multiline = true;
            this.txtSenVal.Name = "txtSenVal";
            this.txtSenVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSenVal.Size = new System.Drawing.Size(308, 346);
            this.txtSenVal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Operations";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(233, 13);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 35);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // tmrSampling
            // 
            this.tmrSampling.Interval = 1000;
            this.tmrSampling.Tick += new System.EventHandler(this.tmrSampling_Tick);
            // 
            // tmrLogging
            // 
            this.tmrLogging.Interval = 1000;
            this.tmrLogging.Tick += new System.EventHandler(this.tmrLogging_Tick);
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Location = new System.Drawing.Point(301, 243);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(0, 25);
            this.lblNotice.TabIndex = 7;
            // 
            // lblNoticeL
            // 
            this.lblNoticeL.AutoSize = true;
            this.lblNoticeL.Location = new System.Drawing.Point(168, 455);
            this.lblNoticeL.Name = "lblNoticeL";
            this.lblNoticeL.Size = new System.Drawing.Size(0, 35);
            this.lblNoticeL.TabIndex = 8;
            // 
            // lblNoticeS
            // 
            this.lblNoticeS.AutoSize = true;
            this.lblNoticeS.Location = new System.Drawing.Point(168, 243);
            this.lblNoticeS.Name = "lblNoticeS";
            this.lblNoticeS.Size = new System.Drawing.Size(0, 35);
            this.lblNoticeS.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 498);
            this.Controls.Add(this.lblNoticeS);
            this.Controls.Add(this.lblNoticeL);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBxSenVal);
            this.Controls.Add(this.gBxLogging);
            this.Controls.Add(this.gBxSampling);
            this.Name = "Form1";
            this.Text = "DAQ Simulation App";
            this.gBxSampling.ResumeLayout(false);
            this.gBxSampling.PerformLayout();
            this.gBxLogging.ResumeLayout(false);
            this.gBxLogging.PerformLayout();
            this.gBxSenVal.ResumeLayout(false);
            this.gBxSenVal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBxSampling;
        private System.Windows.Forms.Label lblSampling;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.TextBox txtSampling;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gBxLogging;
        private System.Windows.Forms.Label lblLogging;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.TextBox txtLogging;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gBxSenVal;
        private System.Windows.Forms.TextBox txtSenVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer tmrSampling;
        private System.Windows.Forms.Timer tmrLogging;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblNoticeL;
        private System.Windows.Forms.Label lblNoticeS;
    }
}

