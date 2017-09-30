namespace Hunt
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
            this.pcMaze = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHoundPosition = new System.Windows.Forms.Label();
            this.lbPreyPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSolutionPath = new System.Windows.Forms.Label();
            this.txtSolutionPath = new System.Windows.Forms.RichTextBox();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.lbCurrentPosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // pcMaze
            // 
            this.pcMaze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcMaze.Location = new System.Drawing.Point(12, 12);
            this.pcMaze.Name = "pcMaze";
            this.pcMaze.Size = new System.Drawing.Size(624, 418);
            this.pcMaze.TabIndex = 10;
            this.pcMaze.TabStop = false;
            this.pcMaze.Paint += new System.Windows.Forms.PaintEventHandler(this.pcMaze_Paint);
            this.pcMaze.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcMaze_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "hound position";
            // 
            // lbHoundPosition
            // 
            this.lbHoundPosition.AutoSize = true;
            this.lbHoundPosition.Location = new System.Drawing.Point(1062, 53);
            this.lbHoundPosition.Name = "lbHoundPosition";
            this.lbHoundPosition.Size = new System.Drawing.Size(0, 17);
            this.lbHoundPosition.TabIndex = 12;
            // 
            // lbPreyPosition
            // 
            this.lbPreyPosition.AutoSize = true;
            this.lbPreyPosition.Location = new System.Drawing.Point(1062, 87);
            this.lbPreyPosition.Name = "lbPreyPosition";
            this.lbPreyPosition.Size = new System.Drawing.Size(0, 17);
            this.lbPreyPosition.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(933, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "prey position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(933, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Solution Path";
            // 
            // lbSolutionPath
            // 
            this.lbSolutionPath.AutoSize = true;
            this.lbSolutionPath.Location = new System.Drawing.Point(933, 197);
            this.lbSolutionPath.Name = "lbSolutionPath";
            this.lbSolutionPath.Size = new System.Drawing.Size(0, 17);
            this.lbSolutionPath.TabIndex = 16;
            // 
            // txtSolutionPath
            // 
            this.txtSolutionPath.Location = new System.Drawing.Point(936, 197);
            this.txtSolutionPath.Name = "txtSolutionPath";
            this.txtSolutionPath.Size = new System.Drawing.Size(334, 398);
            this.txtSolutionPath.TabIndex = 17;
            this.txtSolutionPath.Text = "";
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Location = new System.Drawing.Point(942, 624);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(109, 17);
            this.lbCurrent.TabIndex = 18;
            this.lbCurrent.Text = "Current Position";
            // 
            // lbCurrentPosition
            // 
            this.lbCurrentPosition.AutoSize = true;
            this.lbCurrentPosition.Location = new System.Drawing.Point(942, 653);
            this.lbCurrentPosition.Name = "lbCurrentPosition";
            this.lbCurrentPosition.Size = new System.Drawing.Size(0, 17);
            this.lbCurrentPosition.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 1045);
            this.Controls.Add(this.lbCurrentPosition);
            this.Controls.Add(this.lbCurrent);
            this.Controls.Add(this.txtSolutionPath);
            this.Controls.Add(this.lbSolutionPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPreyPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHoundPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcMaze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcMaze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHoundPosition;
        private System.Windows.Forms.Label lbPreyPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSolutionPath;
        private System.Windows.Forms.RichTextBox txtSolutionPath;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.Label lbCurrentPosition;
    }
}

