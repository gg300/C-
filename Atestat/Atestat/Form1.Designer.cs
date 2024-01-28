namespace Atestat
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
            this.b_start = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(206, 146);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(164, 36);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(206, 325);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(164, 46);
            this.b_exit.TabIndex = 1;
            this.b_exit.Text = "exit";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 579);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_start);
            this.Name = "Form1";
            this.Text = "Meniu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_exit;
    }
}

