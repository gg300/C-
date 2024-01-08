namespace Remember_The_Cards_Atestat
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
            this.b_play = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_play
            // 
            this.b_play.Location = new System.Drawing.Point(307, 132);
            this.b_play.Name = "b_play";
            this.b_play.Size = new System.Drawing.Size(107, 55);
            this.b_play.TabIndex = 0;
            this.b_play.Text = "Play";
            this.b_play.UseVisualStyleBackColor = true;
            this.b_play.Click += new System.EventHandler(this.b_play_Click);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(307, 258);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(107, 58);
            this.b_exit.TabIndex = 2;
            this.b_exit.Text = "Exit";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_play;
        private System.Windows.Forms.Button b_exit;
    }
}

