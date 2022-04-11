
namespace snake_games
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.highscorelb = new System.Windows.Forms.Label();
            this.scorelb = new System.Windows.Forms.Label();
            this.btnrestart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 529);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // highscorelb
            // 
            this.highscorelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.highscorelb.AutoSize = true;
            this.highscorelb.Location = new System.Drawing.Point(764, 39);
            this.highscorelb.Name = "highscorelb";
            this.highscorelb.Size = new System.Drawing.Size(80, 17);
            this.highscorelb.TabIndex = 2;
            this.highscorelb.Text = "High score:";
            this.highscorelb.Click += new System.EventHandler(this.label1_Click);
            // 
            // scorelb
            // 
            this.scorelb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scorelb.AutoSize = true;
            this.scorelb.Location = new System.Drawing.Point(764, 75);
            this.scorelb.Name = "scorelb";
            this.scorelb.Size = new System.Drawing.Size(49, 17);
            this.scorelb.TabIndex = 3;
            this.scorelb.Text = "Score:";
            this.scorelb.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestart.Location = new System.Drawing.Point(764, 120);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(106, 46);
            this.btnrestart.TabIndex = 4;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.StartGame);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 553);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.scorelb);
            this.Controls.Add(this.highscorelb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Snake games";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label highscorelb;
        private System.Windows.Forms.Label scorelb;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Timer timer1;
    }
}

