namespace BrownianMotionGUI
{
    partial class MainForm
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
            this._mainPanel = new System.Windows.Forms.Panel();
            this.nudPoints = new System.Windows.Forms.NumericUpDown();
            this.lblBrownianPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // _mainPanel
            // 
            this._mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mainPanel.Location = new System.Drawing.Point(12, 37);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(710, 383);
            this._mainPanel.TabIndex = 0;
            this._mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._mainPanel_Paint);
            // 
            // nudPoints
            // 
            this.nudPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPoints.Location = new System.Drawing.Point(602, 12);
            this.nudPoints.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPoints.Name = "nudPoints";
            this.nudPoints.Size = new System.Drawing.Size(120, 23);
            this.nudPoints.TabIndex = 1;
            this.nudPoints.ValueChanged += new System.EventHandler(this.nudPoints_ValueChanged);
            // 
            // lblBrownianPoints
            // 
            this.lblBrownianPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrownianPoints.AutoSize = true;
            this.lblBrownianPoints.Location = new System.Drawing.Point(448, 14);
            this.lblBrownianPoints.Name = "lblBrownianPoints";
            this.lblBrownianPoints.Size = new System.Drawing.Size(148, 15);
            this.lblBrownianPoints.TabIndex = 2;
            this.lblBrownianPoints.Text = "Ile punktów wygenerować:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 432);
            this.Controls.Add(this.lblBrownianPoints);
            this.Controls.Add(this.nudPoints);
            this.Controls.Add(this._mainPanel);
            this.MinimumSize = new System.Drawing.Size(370, 250);
            this.Name = "MainForm";
            this.Text = "Form";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _mainPanel;
        private System.Windows.Forms.NumericUpDown nudPoints;
        private System.Windows.Forms.Label lblBrownianPoints;
    }
}
