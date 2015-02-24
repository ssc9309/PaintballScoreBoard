namespace H_XBall
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
            this.lbl_Period1 = new System.Windows.Forms.Label();
            this.lbl_Period2 = new System.Windows.Forms.Label();
            this.lbl_Overtime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_Team1Score = new System.Windows.Forms.Label();
            this.lbl_Team1ScoreAdd = new System.Windows.Forms.Label();
            this.lbl_Team1ScoreMinus = new System.Windows.Forms.Label();
            this.lbl_Team2ScoreAdd = new System.Windows.Forms.Label();
            this.lbl_Team2ScoreMinus = new System.Windows.Forms.Label();
            this.lbl_Team2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Period1
            // 
            this.lbl_Period1.AutoSize = true;
            this.lbl_Period1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Period1.ForeColor = System.Drawing.Color.White;
            this.lbl_Period1.Location = new System.Drawing.Point(339, 44);
            this.lbl_Period1.Name = "lbl_Period1";
            this.lbl_Period1.Size = new System.Drawing.Size(145, 39);
            this.lbl_Period1.TabIndex = 0;
            this.lbl_Period1.Text = "Period 1";
            this.lbl_Period1.Click += new System.EventHandler(this.lbl_Period1_Click);
            // 
            // lbl_Period2
            // 
            this.lbl_Period2.AutoSize = true;
            this.lbl_Period2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Period2.ForeColor = System.Drawing.Color.White;
            this.lbl_Period2.Location = new System.Drawing.Point(503, 44);
            this.lbl_Period2.Name = "lbl_Period2";
            this.lbl_Period2.Size = new System.Drawing.Size(145, 39);
            this.lbl_Period2.TabIndex = 1;
            this.lbl_Period2.Text = "Period 2";
            this.lbl_Period2.Click += new System.EventHandler(this.lbl_Period2_Click);
            // 
            // lbl_Overtime
            // 
            this.lbl_Overtime.AutoSize = true;
            this.lbl_Overtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Overtime.ForeColor = System.Drawing.Color.White;
            this.lbl_Overtime.Location = new System.Drawing.Point(672, 44);
            this.lbl_Overtime.Name = "lbl_Overtime";
            this.lbl_Overtime.Size = new System.Drawing.Size(160, 39);
            this.lbl_Overtime.TabIndex = 2;
            this.lbl_Overtime.Text = "Overtime";
            this.lbl_Overtime.Click += new System.EventHandler(this.lbl_Overtime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(471, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Game Time";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(140, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 40);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Team 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(914, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 40);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Team 2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Team1Score
            // 
            this.lbl_Team1Score.AutoSize = true;
            this.lbl_Team1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team1Score.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Team1Score.Location = new System.Drawing.Point(176, 157);
            this.lbl_Team1Score.Name = "lbl_Team1Score";
            this.lbl_Team1Score.Size = new System.Drawing.Size(107, 76);
            this.lbl_Team1Score.TabIndex = 6;
            this.lbl_Team1Score.Text = "00";
            // 
            // lbl_Team1ScoreAdd
            // 
            this.lbl_Team1ScoreAdd.AutoSize = true;
            this.lbl_Team1ScoreAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Team1ScoreAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team1ScoreAdd.ForeColor = System.Drawing.Color.White;
            this.lbl_Team1ScoreAdd.Location = new System.Drawing.Point(327, 157);
            this.lbl_Team1ScoreAdd.Name = "lbl_Team1ScoreAdd";
            this.lbl_Team1ScoreAdd.Size = new System.Drawing.Size(30, 31);
            this.lbl_Team1ScoreAdd.TabIndex = 7;
            this.lbl_Team1ScoreAdd.Text = "+";
            // 
            // lbl_Team1ScoreMinus
            // 
            this.lbl_Team1ScoreMinus.AutoSize = true;
            this.lbl_Team1ScoreMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Team1ScoreMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team1ScoreMinus.ForeColor = System.Drawing.Color.White;
            this.lbl_Team1ScoreMinus.Location = new System.Drawing.Point(327, 202);
            this.lbl_Team1ScoreMinus.Name = "lbl_Team1ScoreMinus";
            this.lbl_Team1ScoreMinus.Size = new System.Drawing.Size(30, 31);
            this.lbl_Team1ScoreMinus.TabIndex = 8;
            this.lbl_Team1ScoreMinus.Text = "- ";
            this.lbl_Team1ScoreMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Team2ScoreAdd
            // 
            this.lbl_Team2ScoreAdd.AutoSize = true;
            this.lbl_Team2ScoreAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Team2ScoreAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team2ScoreAdd.ForeColor = System.Drawing.Color.White;
            this.lbl_Team2ScoreAdd.Location = new System.Drawing.Point(861, 157);
            this.lbl_Team2ScoreAdd.Name = "lbl_Team2ScoreAdd";
            this.lbl_Team2ScoreAdd.Size = new System.Drawing.Size(30, 31);
            this.lbl_Team2ScoreAdd.TabIndex = 9;
            this.lbl_Team2ScoreAdd.Text = "+";
            // 
            // lbl_Team2ScoreMinus
            // 
            this.lbl_Team2ScoreMinus.AutoSize = true;
            this.lbl_Team2ScoreMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Team2ScoreMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team2ScoreMinus.ForeColor = System.Drawing.Color.White;
            this.lbl_Team2ScoreMinus.Location = new System.Drawing.Point(861, 202);
            this.lbl_Team2ScoreMinus.Name = "lbl_Team2ScoreMinus";
            this.lbl_Team2ScoreMinus.Size = new System.Drawing.Size(30, 31);
            this.lbl_Team2ScoreMinus.TabIndex = 10;
            this.lbl_Team2ScoreMinus.Text = "- ";
            // 
            // lbl_Team2Score
            // 
            this.lbl_Team2Score.AutoSize = true;
            this.lbl_Team2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team2Score.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Team2Score.Location = new System.Drawing.Point(953, 157);
            this.lbl_Team2Score.Name = "lbl_Team2Score";
            this.lbl_Team2Score.Size = new System.Drawing.Size(107, 76);
            this.lbl_Team2Score.TabIndex = 11;
            this.lbl_Team2Score.Text = "00";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1379, 635);
            this.Controls.Add(this.lbl_Team2Score);
            this.Controls.Add(this.lbl_Team2ScoreMinus);
            this.Controls.Add(this.lbl_Team2ScoreAdd);
            this.Controls.Add(this.lbl_Team1ScoreMinus);
            this.Controls.Add(this.lbl_Team1ScoreAdd);
            this.Controls.Add(this.lbl_Team1Score);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Overtime);
            this.Controls.Add(this.lbl_Period2);
            this.Controls.Add(this.lbl_Period1);
            this.Name = "Main";
            this.Text = "H_XBall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Period1;
        private System.Windows.Forms.Label lbl_Period2;
        private System.Windows.Forms.Label lbl_Overtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_Team1Score;
        private System.Windows.Forms.Label lbl_Team1ScoreAdd;
        private System.Windows.Forms.Label lbl_Team1ScoreMinus;
        private System.Windows.Forms.Label lbl_Team2ScoreAdd;
        private System.Windows.Forms.Label lbl_Team2ScoreMinus;
        private System.Windows.Forms.Label lbl_Team2Score;
    }
}

