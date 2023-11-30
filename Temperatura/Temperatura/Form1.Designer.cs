namespace Temperatura
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
            Label Label_Title;
            pictureBox1 = new PictureBox();
            btn_transform = new Button();
            btn_reset = new Button();
            btn_exit = new Button();
            label_temperatura = new Label();
            text_temp = new TextBox();
            rad_temp_1 = new RadioButton();
            rad_temp_2 = new RadioButton();
            groupBox1 = new GroupBox();
            label_conv = new Label();
            text_conv = new TextBox();
            label_masura = new Label();
            Label_Title = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Label_Title
            // 
            Label_Title.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Title.Location = new Point(141, 9);
            Label_Title.MaximumSize = new Size(394, 0);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(394, 68);
            Label_Title.TabIndex = 1;
            Label_Title.Text = "Introduce the temperature, introduce the measure, press the \"transform\" button to obtain the equivalent temperature";
            Label_Title.Click += Label_Title_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Temp_A_Sure;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_transform
            // 
            btn_transform.Location = new Point(30, 262);
            btn_transform.Name = "btn_transform";
            btn_transform.Size = new Size(94, 29);
            btn_transform.TabIndex = 2;
            btn_transform.Text = "Transform";
            btn_transform.UseVisualStyleBackColor = true;
            btn_transform.Click += transform_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(187, 262);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(106, 29);
            btn_reset.TabIndex = 3;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(328, 211);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(171, 95);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "alt+f4";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label_temperatura
            // 
            label_temperatura.AutoSize = true;
            label_temperatura.Location = new Point(25, 115);
            label_temperatura.Name = "label_temperatura";
            label_temperatura.Size = new Size(99, 19);
            label_temperatura.TabIndex = 5;
            label_temperatura.Text = "Temperature";
            label_temperatura.Click += label_temperatura_Click;
            // 
            // text_temp
            // 
            text_temp.Location = new Point(12, 137);
            text_temp.Name = "text_temp";
            text_temp.Size = new Size(125, 27);
            text_temp.TabIndex = 6;
            text_temp.TextAlign = HorizontalAlignment.Right;
            text_temp.TextChanged += textBox1_TextChanged;
            // 
            // rad_temp_1
            // 
            rad_temp_1.AutoSize = true;
            rad_temp_1.Location = new Point(19, 36);
            rad_temp_1.Name = "rad_temp_1";
            rad_temp_1.Size = new Size(83, 23);
            rad_temp_1.TabIndex = 7;
            rad_temp_1.TabStop = true;
            rad_temp_1.Text = "Celsius";
            rad_temp_1.UseVisualStyleBackColor = true;
            rad_temp_1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rad_temp_2
            // 
            rad_temp_2.AutoSize = true;
            rad_temp_2.Location = new Point(141, 36);
            rad_temp_2.Name = "rad_temp_2";
            rad_temp_2.Size = new Size(108, 23);
            rad_temp_2.TabIndex = 8;
            rad_temp_2.TabStop = true;
            rad_temp_2.Text = "Fahrenheit";
            rad_temp_2.UseVisualStyleBackColor = true;
            rad_temp_2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rad_temp_1);
            groupBox1.Controls.Add(rad_temp_2);
            groupBox1.Location = new Point(218, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 69);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Measure";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label_conv
            // 
            label_conv.AutoSize = true;
            label_conv.Location = new Point(25, 178);
            label_conv.Name = "label_conv";
            label_conv.Size = new Size(91, 19);
            label_conv.TabIndex = 10;
            label_conv.Text = "Conversion";
            // 
            // text_conv
            // 
            text_conv.Location = new Point(12, 200);
            text_conv.Name = "text_conv";
            text_conv.Size = new Size(125, 27);
            text_conv.TabIndex = 11;
            // 
            // label_masura
            // 
            label_masura.AutoSize = true;
            label_masura.Location = new Point(169, 203);
            label_masura.Name = "label_masura";
            label_masura.Size = new Size(84, 19);
            label_masura.TabIndex = 12;
            label_masura.Text = "(measure)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(542, 335);
            Controls.Add(label_masura);
            Controls.Add(text_conv);
            Controls.Add(label_conv);
            Controls.Add(groupBox1);
            Controls.Add(text_temp);
            Controls.Add(label_temperatura);
            Controls.Add(btn_exit);
            Controls.Add(btn_reset);
            Controls.Add(btn_transform);
            Controls.Add(Label_Title);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "program conversie temperaturalol";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_transform;
        private Button btn_reset;
        private Button btn_exit;
        private Label label_temperatura;
        private TextBox text_temp;
        private RadioButton rad_temp_1;
        private RadioButton rad_temp_2;
        private GroupBox groupBox1;
        private Label label_conv;
        private TextBox text_conv;
        private Label label_masura;
    }
}