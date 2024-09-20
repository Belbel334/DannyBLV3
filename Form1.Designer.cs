namespace DannyBLV3
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
            AgeUp = new Button();
            AgeBox = new TextBox();
            NameBox = new TextBox();
            SuspendLayout();
            // 
            // AgeUp
            // 
            AgeUp.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AgeUp.ForeColor = SystemColors.ActiveCaptionText;
            AgeUp.Location = new Point(12, 410);
            AgeUp.Name = "AgeUp";
            AgeUp.Size = new Size(371, 105);
            AgeUp.TabIndex = 0;
            AgeUp.Text = "Age up";
            AgeUp.UseVisualStyleBackColor = true;
            AgeUp.Click += AgeUp_Click;
            // 
            // AgeBox
            // 
            AgeBox.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeBox.Location = new Point(2, 12);
            AgeBox.Multiline = true;
            AgeBox.Name = "AgeBox";
            AgeBox.ReadOnly = true;
            AgeBox.Size = new Size(381, 35);
            AgeBox.TabIndex = 1;
            AgeBox.Text = "Age: 75";
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameBox.Location = new Point(567, 12);
            NameBox.Multiline = true;
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(381, 35);
            NameBox.TabIndex = 2;
            NameBox.Text = "Name: Mark";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 527);
            Controls.Add(NameBox);
            Controls.Add(AgeBox);
            Controls.Add(AgeUp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AgeUp;
        private TextBox AgeBox;
        private TextBox NameBox;
    }
}
