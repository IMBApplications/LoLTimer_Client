namespace IMBApplication.Lol.Timer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTopBlue = new System.Windows.Forms.Label();
            this.lblBottomBlue = new System.Windows.Forms.Label();
            this.lblTopRed = new System.Windows.Forms.Label();
            this.lblBottomRed = new System.Windows.Forms.Label();
            this.lblDragon = new System.Windows.Forms.Label();
            this.lblBaron = new System.Windows.Forms.Label();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(45, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(82, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dragon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(154, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Baron";
            // 
            // lblTopBlue
            // 
            this.lblTopBlue.AutoSize = true;
            this.lblTopBlue.Location = new System.Drawing.Point(9, 13);
            this.lblTopBlue.Name = "lblTopBlue";
            this.lblTopBlue.Size = new System.Drawing.Size(25, 13);
            this.lblTopBlue.TabIndex = 9;
            this.lblTopBlue.Text = "000";
            this.lblTopBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBottomBlue
            // 
            this.lblBottomBlue.AutoSize = true;
            this.lblBottomBlue.Location = new System.Drawing.Point(9, 43);
            this.lblBottomBlue.Name = "lblBottomBlue";
            this.lblBottomBlue.Size = new System.Drawing.Size(25, 13);
            this.lblBottomBlue.TabIndex = 10;
            this.lblBottomBlue.Text = "000";
            this.lblBottomBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTopRed
            // 
            this.lblTopRed.AutoSize = true;
            this.lblTopRed.Location = new System.Drawing.Point(46, 13);
            this.lblTopRed.Name = "lblTopRed";
            this.lblTopRed.Size = new System.Drawing.Size(25, 13);
            this.lblTopRed.TabIndex = 11;
            this.lblTopRed.Text = "000";
            this.lblTopRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBottomRed
            // 
            this.lblBottomRed.AutoSize = true;
            this.lblBottomRed.Location = new System.Drawing.Point(46, 43);
            this.lblBottomRed.Name = "lblBottomRed";
            this.lblBottomRed.Size = new System.Drawing.Size(25, 13);
            this.lblBottomRed.TabIndex = 12;
            this.lblBottomRed.Text = "000";
            this.lblBottomRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDragon
            // 
            this.lblDragon.AutoSize = true;
            this.lblDragon.Location = new System.Drawing.Point(124, 27);
            this.lblDragon.Name = "lblDragon";
            this.lblDragon.Size = new System.Drawing.Size(25, 13);
            this.lblDragon.TabIndex = 13;
            this.lblDragon.Text = "000";
            this.lblDragon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBaron
            // 
            this.lblBaron.AutoSize = true;
            this.lblBaron.Location = new System.Drawing.Point(188, 27);
            this.lblBaron.Name = "lblBaron";
            this.lblBaron.Size = new System.Drawing.Size(25, 13);
            this.lblBaron.TabIndex = 14;
            this.lblBaron.Text = "000";
            this.lblBaron.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ticker
            // 
            this.ticker.Interval = 1000;
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 65);
            this.Controls.Add(this.lblBaron);
            this.Controls.Add(this.lblDragon);
            this.Controls.Add(this.lblBottomRed);
            this.Controls.Add(this.lblTopRed);
            this.Controls.Add(this.lblBottomBlue);
            this.Controls.Add(this.lblTopBlue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LoL Timer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTopBlue;
        private System.Windows.Forms.Label lblBottomBlue;
        private System.Windows.Forms.Label lblTopRed;
        private System.Windows.Forms.Label lblBottomRed;
        private System.Windows.Forms.Label lblDragon;
        private System.Windows.Forms.Label lblBaron;
        private System.Windows.Forms.Timer ticker;
    }
}