namespace dynamic_test
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
            this.b_gen = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.TextBox();
            this.b_prev = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_gen
            // 
            this.b_gen.Location = new System.Drawing.Point(324, 282);
            this.b_gen.Name = "b_gen";
            this.b_gen.Size = new System.Drawing.Size(75, 40);
            this.b_gen.TabIndex = 0;
            this.b_gen.Text = "generare";
            this.b_gen.UseVisualStyleBackColor = true;
            this.b_gen.Click += new System.EventHandler(this.b_gen_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(343, 46);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(96, 22);
            this.text.TabIndex = 1;
            // 
            // b_prev
            // 
            this.b_prev.Location = new System.Drawing.Point(107, 282);
            this.b_prev.Name = "b_prev";
            this.b_prev.Size = new System.Drawing.Size(124, 35);
            this.b_prev.TabIndex = 2;
            this.b_prev.Text = "previous";
            this.b_prev.UseVisualStyleBackColor = true;
            this.b_prev.Click += new System.EventHandler(this.b_prev_Click);
            // 
            // b_next
            // 
            this.b_next.Location = new System.Drawing.Point(464, 289);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(183, 32);
            this.b_next.TabIndex = 3;
            this.b_next.Text = "next";
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.b_prev);
            this.Controls.Add(this.text);
            this.Controls.Add(this.b_gen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_gen;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button b_prev;
        private System.Windows.Forms.Button b_next;
    }
}

