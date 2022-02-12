
namespace DAQ_Sim_App
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
            this.gbxSampling = new System.Windows.Forms.GroupBox();
            this.btnSampling = new System.Windows.Forms.Button();
            this.lblSampling = new System.Windows.Forms.Label();
            this.txtbxSampling = new System.Windows.Forms.TextBox();
            this.gbxLogging = new System.Windows.Forms.GroupBox();
            this.txtLogging = new System.Windows.Forms.TextBox();
            this.lblLogging = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxSensorValues = new System.Windows.Forms.GroupBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblOperations = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtSensorValues = new System.Windows.Forms.TextBox();
            this.gbxSampling.SuspendLayout();
            this.gbxLogging.SuspendLayout();
            this.gbxSensorValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSampling
            // 
            this.gbxSampling.Controls.Add(this.txtbxSampling);
            this.gbxSampling.Controls.Add(this.lblSampling);
            this.gbxSampling.Controls.Add(this.btnSampling);
            this.gbxSampling.Location = new System.Drawing.Point(25, 41);
            this.gbxSampling.Name = "gbxSampling";
            this.gbxSampling.Size = new System.Drawing.Size(235, 96);
            this.gbxSampling.TabIndex = 6;
            this.gbxSampling.TabStop = false;
            this.gbxSampling.Text = "Sampling";
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(9, 61);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(94, 23);
            this.btnSampling.TabIndex = 7;
            this.btnSampling.Text = "Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            // 
            // lblSampling
            // 
            this.lblSampling.AutoSize = true;
            this.lblSampling.Location = new System.Drawing.Point(6, 22);
            this.lblSampling.Name = "lblSampling";
            this.lblSampling.Size = new System.Drawing.Size(101, 13);
            this.lblSampling.TabIndex = 9;
            this.lblSampling.Text = "Next Sampling Time";
            // 
            // txtbxSampling
            // 
            this.txtbxSampling.Location = new System.Drawing.Point(121, 19);
            this.txtbxSampling.Name = "txtbxSampling";
            this.txtbxSampling.Size = new System.Drawing.Size(100, 20);
            this.txtbxSampling.TabIndex = 9;
            this.txtbxSampling.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // gbxLogging
            // 
            this.gbxLogging.Controls.Add(this.txtLogging);
            this.gbxLogging.Controls.Add(this.lblLogging);
            this.gbxLogging.Controls.Add(this.button2);
            this.gbxLogging.Location = new System.Drawing.Point(25, 153);
            this.gbxLogging.Name = "gbxLogging";
            this.gbxLogging.Size = new System.Drawing.Size(235, 96);
            this.gbxLogging.TabIndex = 9;
            this.gbxLogging.TabStop = false;
            this.gbxLogging.Text = "Logging";
            this.gbxLogging.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtLogging
            // 
            this.txtLogging.Location = new System.Drawing.Point(121, 19);
            this.txtLogging.Name = "txtLogging";
            this.txtLogging.Size = new System.Drawing.Size(100, 20);
            this.txtLogging.TabIndex = 9;
            // 
            // lblLogging
            // 
            this.lblLogging.AutoSize = true;
            this.lblLogging.Location = new System.Drawing.Point(6, 22);
            this.lblLogging.Name = "lblLogging";
            this.lblLogging.Size = new System.Drawing.Size(96, 13);
            this.lblLogging.TabIndex = 9;
            this.lblLogging.Text = "Next Logging Time";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Logging on File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbxSensorValues
            // 
            this.gbxSensorValues.Controls.Add(this.txtSensorValues);
            this.gbxSensorValues.Location = new System.Drawing.Point(283, 41);
            this.gbxSensorValues.Name = "gbxSensorValues";
            this.gbxSensorValues.Size = new System.Drawing.Size(144, 208);
            this.gbxSensorValues.TabIndex = 10;
            this.gbxSensorValues.TabStop = false;
            this.gbxSensorValues.Text = "Sensor Values";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(143, 9);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(29, 13);
            this.lblHelp.TabIndex = 11;
            this.lblHelp.Text = "Help";
            // 
            // lblOperations
            // 
            this.lblOperations.AutoSize = true;
            this.lblOperations.Location = new System.Drawing.Point(55, 9);
            this.lblOperations.Name = "lblOperations";
            this.lblOperations.Size = new System.Drawing.Size(58, 13);
            this.lblOperations.TabIndex = 12;
            this.lblOperations.Text = "Operations";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 9);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 13;
            this.lblFile.Text = "File";
            // 
            // txtSensorValues
            // 
            this.txtSensorValues.Location = new System.Drawing.Point(6, 22);
            this.txtSensorValues.Multiline = true;
            this.txtSensorValues.Name = "txtSensorValues";
            this.txtSensorValues.Size = new System.Drawing.Size(129, 180);
            this.txtSensorValues.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 276);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblOperations);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.gbxSensorValues);
            this.Controls.Add(this.gbxLogging);
            this.Controls.Add(this.gbxSampling);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DAQ Simulation Application";
            this.gbxSampling.ResumeLayout(false);
            this.gbxSampling.PerformLayout();
            this.gbxLogging.ResumeLayout(false);
            this.gbxLogging.PerformLayout();
            this.gbxSensorValues.ResumeLayout(false);
            this.gbxSensorValues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxSampling;
        private System.Windows.Forms.TextBox txtbxSampling;
        private System.Windows.Forms.Label lblSampling;
        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.GroupBox gbxLogging;
        private System.Windows.Forms.TextBox txtLogging;
        private System.Windows.Forms.Label lblLogging;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbxSensorValues;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblOperations;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtSensorValues;
    }
}

