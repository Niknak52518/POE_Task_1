namespace Real_Time_Simulation_Part_One
{
    partial class frmRTS
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
            this.lblMap = new System.Windows.Forms.Label();
            this.txtInfoBox = new System.Windows.Forms.RichTextBox();
            this.btnStartPauseSim = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(13, 13);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(38, 13);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "lblMap";
            // 
            // txtInfoBox
            // 
            this.txtInfoBox.Location = new System.Drawing.Point(12, 436);
            this.txtInfoBox.Name = "txtInfoBox";
            this.txtInfoBox.Size = new System.Drawing.Size(651, 233);
            this.txtInfoBox.TabIndex = 1;
            this.txtInfoBox.Text = "";
            // 
            // btnStartPauseSim
            // 
            this.btnStartPauseSim.Location = new System.Drawing.Point(458, 386);
            this.btnStartPauseSim.Name = "btnStartPauseSim";
            this.btnStartPauseSim.Size = new System.Drawing.Size(205, 44);
            this.btnStartPauseSim.TabIndex = 3;
            this.btnStartPauseSim.Text = "PAUSE";
            this.btnStartPauseSim.UseVisualStyleBackColor = true;
            this.btnStartPauseSim.Click += new System.EventHandler(this.btnStartPauseSim_Click);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(13, 402);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(53, 13);
            this.lblRound.TabIndex = 4;
            this.lblRound.Text = "ROUND: ";
            // 
            // frmRTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 681);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnStartPauseSim);
            this.Controls.Add(this.txtInfoBox);
            this.Controls.Add(this.lblMap);
            this.Name = "frmRTS";
            this.Text = "REAL TIME SIMULATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.RichTextBox txtInfoBox;
        private System.Windows.Forms.Button btnStartPauseSim;
        private System.Windows.Forms.Label lblRound;
    }
}

