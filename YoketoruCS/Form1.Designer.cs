namespace YoketoruCS
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonStart = new Button();
            labelTitle = new Label();
            labelGameover = new Label();
            buttonToTitle = new Button();
            labelClear = new Label();
            labelScore = new Label();
            labelTime = new Label();
            tempEnemy = new Label();
            tempitem = new Label();
            tempplayer = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.White;
            buttonStart.Font = new Font("Yu Gothic UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(309, 120);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(182, 70);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start!!!";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("HGP創英角ｺﾞｼｯｸUB", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = SystemColors.ActiveCaption;
            labelTitle.Location = new Point(293, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(204, 40);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "よけとるCS";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(309, 62);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(188, 42);
            labelGameover.TabIndex = 2;
            labelGameover.Text = "GAME OVER";
            // 
            // buttonToTitle
            // 
            buttonToTitle.Font = new Font("Yu Gothic UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToTitle.Location = new Point(319, 196);
            buttonToTitle.Name = "buttonToTitle";
            buttonToTitle.Size = new Size(158, 72);
            buttonToTitle.TabIndex = 3;
            buttonToTitle.Text = "タイトルへ";
            buttonToTitle.UseVisualStyleBackColor = true;
            buttonToTitle.Click += buttonToTitle_Click;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("源ノ角ゴシック Code JP R", 33F, FontStyle.Bold, GraphicsUnit.Point);
            labelClear.ForeColor = Color.Blue;
            labelClear.Location = new Point(261, 53);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(230, 64);
            labelClear.TabIndex = 4;
            labelClear.Text = "CLEAR!!";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelScore.Location = new Point(39, 394);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(33, 40);
            labelScore.TabIndex = 5;
            labelScore.Text = "0";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("UD デジタル 教科書体 NK-B", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.ForeColor = SystemColors.ControlText;
            labelTime.Location = new Point(770, 394);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(78, 34);
            labelTime.TabIndex = 6;
            labelTime.Text = "200";
            // 
            // tempEnemy
            // 
            tempEnemy.AutoSize = true;
            tempEnemy.Font = new Font("Yu Gothic UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tempEnemy.ForeColor = Color.FromArgb(192, 0, 0);
            tempEnemy.Location = new Point(116, 237);
            tempEnemy.Name = "tempEnemy";
            tempEnemy.Size = new Size(37, 31);
            tempEnemy.TabIndex = 7;
            tempEnemy.Text = "◆";
            // 
            // tempitem
            // 
            tempitem.AutoSize = true;
            tempitem.Font = new Font("Yu Gothic UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tempitem.ForeColor = Color.FromArgb(0, 192, 0);
            tempitem.Location = new Point(351, 401);
            tempitem.Name = "tempitem";
            tempitem.Size = new Size(37, 31);
            tempitem.TabIndex = 8;
            tempitem.Text = "●";
            tempitem.Click += tempitem_Click;
            // 
            // tempplayer
            // 
            tempplayer.AutoSize = true;
            tempplayer.Font = new Font("Yu Gothic UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            tempplayer.Location = new Point(61, 159);
            tempplayer.Name = "tempplayer";
            tempplayer.Size = new Size(63, 31);
            tempplayer.TabIndex = 9;
            tempplayer.Text = "ᔦꙬᔨ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(859, 471);
            Controls.Add(tempplayer);
            Controls.Add(tempitem);
            Controls.Add(tempEnemy);
            Controls.Add(labelTime);
            Controls.Add(labelScore);
            Controls.Add(labelClear);
            Controls.Add(buttonToTitle);
            Controls.Add(labelGameover);
            Controls.Add(labelTitle);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button buttonStart;
        private Label labelTitle;
        private Label labelGameover;
        private Button buttonToTitle;
        private Label labelClear;
        private Label labelScore;
        private Label labelTime;
        private Label tempEnemy;
        private Label tempitem;
        private Label tempplayer;
    }
}