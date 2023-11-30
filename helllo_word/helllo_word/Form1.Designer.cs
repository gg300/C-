namespace helllo_word
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
            this.link_l_foldersifisier = new System.Windows.Forms.LinkLabel();
            this.link_minister = new System.Windows.Forms.LinkLabel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // link_l_foldersifisier
            // 
            this.link_l_foldersifisier.AutoSize = true;
            this.link_l_foldersifisier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_l_foldersifisier.Location = new System.Drawing.Point(76, 83);
            this.link_l_foldersifisier.Name = "link_l_foldersifisier";
            this.link_l_foldersifisier.Size = new System.Drawing.Size(163, 29);
            this.link_l_foldersifisier.TabIndex = 0;
            this.link_l_foldersifisier.TabStop = true;
            this.link_l_foldersifisier.Text = "Find your files";
            this.link_l_foldersifisier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_l_foldersifisier_LinkClicked);
            // 
            // link_minister
            // 
            this.link_minister.AutoSize = true;
            this.link_minister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_minister.Location = new System.Drawing.Point(76, 135);
            this.link_minister.Name = "link_minister";
            this.link_minister.Size = new System.Drawing.Size(244, 29);
            this.link_minister.TabIndex = 1;
            this.link_minister.TabStop = true;
            this.link_minister.Text = "MINIsteru eDucaTziei";
            this.link_minister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_minister_LinkClicked);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Engleza",
            "Poloneza",
            "Franceza",
            "Finlandeza",
            "Japoneza",
            "Vietnameza",
            "Spaniola",
            "Germana",
            "Suedeza",
            "Olandeza",
            "Coreeana",
            "Chineza",
            "Irlandeza",
            "Rusa"});
            this.checkedListBox1.Location = new System.Drawing.Point(110, 200);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(129, 208);
            this.checkedListBox1.TabIndex = 2;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(528, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(124, 100);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sterge";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.link_minister);
            this.Controls.Add(this.link_l_foldersifisier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_l_foldersifisier;
        private System.Windows.Forms.LinkLabel link_minister;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}

