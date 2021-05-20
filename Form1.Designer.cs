using System;

namespace Lab5A
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
            this.btn_Color = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Color
            // 
            this.btn_Color.Location = new System.Drawing.Point(48, 24);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(75, 23);
            this.btn_Color.TabIndex = 0;
            this.btn_Color.Text = "Color";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(184, 24);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = " Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // theTimer
            // 
            this.theTimer.Interval = 1;
            this.theTimer.Tick += new System.EventHandler(this.theTimer_Tick);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Black;
            this.trackBar.LargeChange = 10;
            this.trackBar.Location = new System.Drawing.Point(32, 69);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(112, 45);
            this.trackBar.TabIndex = 2;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab5A.Properties.Resources.Faucet;
            this.pictureBox1.Location = new System.Drawing.Point(32, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 68);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_Color);
            this.Name = "Form1";
            this.Text = "Lab 5a";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer theTimer;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

