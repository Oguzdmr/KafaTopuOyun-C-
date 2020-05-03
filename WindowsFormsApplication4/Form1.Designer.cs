namespace WindowsFormsApplication4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Kale1 = new System.Windows.Forms.Label();
            this.Kale2 = new System.Windows.Forms.Label();
            this.Top = new System.Windows.Forms.PictureBox();
            this.picOyuncu1 = new System.Windows.Forms.PictureBox();
            this.picOyuncu2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerHareket = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncu2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 463);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 14);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(193, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 221);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 14);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(765, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 19);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(765, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 14);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(765, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 221);
            this.label7.TabIndex = 6;
            // 
            // Kale1
            // 
            this.Kale1.BackColor = System.Drawing.Color.White;
            this.Kale1.Location = new System.Drawing.Point(1, 111);
            this.Kale1.Name = "Kale1";
            this.Kale1.Size = new System.Drawing.Size(17, 221);
            this.Kale1.TabIndex = 7;
            // 
            // Kale2
            // 
            this.Kale2.BackColor = System.Drawing.Color.White;
            this.Kale2.Location = new System.Drawing.Point(957, 111);
            this.Kale2.Name = "Kale2";
            this.Kale2.Size = new System.Drawing.Size(17, 221);
            this.Kale2.TabIndex = 8;
            // 
            // Top
            // 
            this.Top.Image = ((System.Drawing.Image)(resources.GetObject("Top.Image")));
            this.Top.Location = new System.Drawing.Point(450, 183);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(59, 50);
            this.Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Top.TabIndex = 9;
            this.Top.TabStop = false;
            this.Top.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picOyuncu1
            // 
            this.picOyuncu1.Image = ((System.Drawing.Image)(resources.GetObject("picOyuncu1.Image")));
            this.picOyuncu1.Location = new System.Drawing.Point(116, 163);
            this.picOyuncu1.Name = "picOyuncu1";
            this.picOyuncu1.Size = new System.Drawing.Size(71, 111);
            this.picOyuncu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOyuncu1.TabIndex = 10;
            this.picOyuncu1.TabStop = false;
            // 
            // picOyuncu2
            // 
            this.picOyuncu2.Image = ((System.Drawing.Image)(resources.GetObject("picOyuncu2.Image")));
            this.picOyuncu2.Location = new System.Drawing.Point(851, 163);
            this.picOyuncu2.Name = "picOyuncu2";
            this.picOyuncu2.Size = new System.Drawing.Size(71, 111);
            this.picOyuncu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOyuncu2.TabIndex = 11;
            this.picOyuncu2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerHareket
            // 
            this.timerHareket.Interval = 50;
            this.timerHareket.Tick += new System.EventHandler(this.timerHareket_Tick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(492, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 44);
            this.label8.TabIndex = 14;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(411, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 44);
            this.label9.TabIndex = 15;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(972, 461);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picOyuncu2);
            this.Controls.Add(this.picOyuncu1);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Kale2);
            this.Controls.Add(this.Kale1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kafa Topu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOyuncu2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Kale1;
        private System.Windows.Forms.Label Kale2;
        private System.Windows.Forms.PictureBox Top;
        private System.Windows.Forms.PictureBox picOyuncu1;
        private System.Windows.Forms.PictureBox picOyuncu2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerHareket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

