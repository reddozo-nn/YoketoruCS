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
            labelTitle.Location = new Point(309, 62);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(204, 40);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "よけとるCS";
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(309, 51);
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(859, 471);
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
    }
}