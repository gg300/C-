namespace messenger
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
            this.button_maria = new System.Windows.Forms.Button();
            this.button_ionel = new System.Windows.Forms.Button();
            this.button_salvare = new System.Windows.Forms.Button();
            this.text_scrie = new System.Windows.Forms.RichTextBox();
            this.button_sterge = new System.Windows.Forms.Button();
            this.button_incarcare = new System.Windows.Forms.Button();
            this.text_citeste = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_maria
            // 
            this.button_maria.Location = new System.Drawing.Point(47, 293);
            this.button_maria.Name = "button_maria";
            this.button_maria.Size = new System.Drawing.Size(75, 33);
            this.button_maria.TabIndex = 0;
            this.button_maria.Text = "Maria";
            this.button_maria.UseVisualStyleBackColor = true;
            this.button_maria.Click += new System.EventHandler(this.button_maria_Click);
            // 
            // button_ionel
            // 
            this.button_ionel.Location = new System.Drawing.Point(618, 293);
            this.button_ionel.Name = "button_ionel";
            this.button_ionel.Size = new System.Drawing.Size(75, 33);
            this.button_ionel.TabIndex = 2;
            this.button_ionel.Text = "Ionel";
            this.button_ionel.UseVisualStyleBackColor = true;
            this.button_ionel.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_salvare
            // 
            this.button_salvare.Location = new System.Drawing.Point(23, 363);
            this.button_salvare.Name = "button_salvare";
            this.button_salvare.Size = new System.Drawing.Size(117, 32);
            this.button_salvare.TabIndex = 3;
            this.button_salvare.Text = "Salvare mesaje";
            this.button_salvare.UseVisualStyleBackColor = true;
            this.button_salvare.Click += new System.EventHandler(this.button_salvare_Click);
            // 
            // text_scrie
            // 
            this.text_scrie.Location = new System.Drawing.Point(163, 293);
            this.text_scrie.Name = "text_scrie";
            this.text_scrie.Size = new System.Drawing.Size(419, 33);
            this.text_scrie.TabIndex = 4;
            this.text_scrie.Text = "";
            // 
            // button_sterge
            // 
            this.button_sterge.Location = new System.Drawing.Point(216, 363);
            this.button_sterge.Name = "button_sterge";
            this.button_sterge.Size = new System.Drawing.Size(259, 31);
            this.button_sterge.TabIndex = 5;
            this.button_sterge.Text = "Sterge fereastra mesaje";
            this.button_sterge.UseVisualStyleBackColor = true;
            this.button_sterge.Click += new System.EventHandler(this.button_sterge_Click);
            // 
            // button_incarcare
            // 
            this.button_incarcare.Location = new System.Drawing.Point(551, 363);
            this.button_incarcare.Name = "button_incarcare";
            this.button_incarcare.Size = new System.Drawing.Size(175, 32);
            this.button_incarcare.TabIndex = 6;
            this.button_incarcare.Text = "Incarcare mesaje";
            this.button_incarcare.UseVisualStyleBackColor = true;
            this.button_incarcare.Click += new System.EventHandler(this.button_incarcare_Click);
            // 
            // text_citeste
            // 
            this.text_citeste.BackColor = System.Drawing.SystemColors.Control;
            this.text_citeste.Location = new System.Drawing.Point(47, 33);
            this.text_citeste.Name = "text_citeste";
            this.text_citeste.ReadOnly = true;
            this.text_citeste.Size = new System.Drawing.Size(679, 240);
            this.text_citeste.TabIndex = 7;
            this.text_citeste.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_citeste);
            this.Controls.Add(this.button_incarcare);
            this.Controls.Add(this.button_sterge);
            this.Controls.Add(this.text_scrie);
            this.Controls.Add(this.button_salvare);
            this.Controls.Add(this.button_ionel);
            this.Controls.Add(this.button_maria);
            this.Name = "Form1";
            this.Text = "M E S S E N G E R";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_maria;
        private System.Windows.Forms.Button button_ionel;
        private System.Windows.Forms.Button button_salvare;
        private System.Windows.Forms.RichTextBox text_scrie;
        private System.Windows.Forms.Button button_sterge;
        private System.Windows.Forms.Button button_incarcare;
        private System.Windows.Forms.RichTextBox text_citeste;
    }
}

