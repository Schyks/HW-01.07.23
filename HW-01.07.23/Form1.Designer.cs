using HW_01._07._23.Properties;
using Microsoft.VisualBasic.ApplicationServices;

namespace HW_01._07._23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackgroundImage = Resources.UKR;
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackgroundImage = Resources.USA;
            button2.ForeColor = Color.SpringGreen;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.BackgroundImage = Resources.GER;
            button3.ForeColor = Color.Snow;
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.BackColor = Color.MediumTurquoise;
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.BackColor = Color.MediumTurquoise;
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.BackColor = Color.MediumTurquoise;
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.BackColor = Color.MediumTurquoise;
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.BackColor = Color.MediumTurquoise;
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            resources.ApplyResources(button9, "button9");
            button9.BackColor = Color.MediumTurquoise;
            button9.Name = "button9";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            resources.ApplyResources(button10, "button10");
            button10.BackColor = Color.MediumTurquoise;
            button10.Name = "button10";
            button10.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.White;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Cyan;
            label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resources.Golf;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private PictureBox pictureBox1;
        private Label label1;
    }
}