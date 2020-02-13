namespace Kolekcje
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
            this.Display_question = new System.Windows.Forms.TextBox();
            this.Ans_0 = new System.Windows.Forms.TextBox();
            this.Ans_1 = new System.Windows.Forms.TextBox();
            this.Ans_2 = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.SpeakButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Display_question
            // 
            this.Display_question.Enabled = false;
            this.Display_question.Location = new System.Drawing.Point(13, 13);
            this.Display_question.Name = "Display_question";
            this.Display_question.Size = new System.Drawing.Size(329, 20);
            this.Display_question.TabIndex = 0;
            // 
            // Ans_0
            // 
            this.Ans_0.Location = new System.Drawing.Point(189, 39);
            this.Ans_0.Name = "Ans_0";
            this.Ans_0.Size = new System.Drawing.Size(153, 20);
            this.Ans_0.TabIndex = 1;
            // 
            // Ans_1
            // 
            this.Ans_1.Location = new System.Drawing.Point(189, 66);
            this.Ans_1.Name = "Ans_1";
            this.Ans_1.Size = new System.Drawing.Size(153, 20);
            this.Ans_1.TabIndex = 2;
            // 
            // Ans_2
            // 
            this.Ans_2.Location = new System.Drawing.Point(189, 92);
            this.Ans_2.Name = "Ans_2";
            this.Ans_2.Size = new System.Drawing.Size(153, 20);
            this.Ans_2.TabIndex = 3;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(12, 40);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(77, 46);
            this.CheckButton.TabIndex = 4;
            this.CheckButton.Text = "Sprawdź";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(12, 92);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(171, 46);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Następne Pytanie";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SpeakButton
            // 
            this.SpeakButton.Location = new System.Drawing.Point(106, 40);
            this.SpeakButton.Name = "SpeakButton";
            this.SpeakButton.Size = new System.Drawing.Size(77, 46);
            this.SpeakButton.TabIndex = 6;
            this.SpeakButton.Text = "Czytaj";
            this.SpeakButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zdobyte Punkty :";
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(170, 145);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(13, 13);
            this.Points.TabIndex = 9;
            this.Points.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 162);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeakButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.Ans_2);
            this.Controls.Add(this.Ans_1);
            this.Controls.Add(this.Ans_0);
            this.Controls.Add(this.Display_question);
            this.Name = "Form1";
            this.Text = "Familiada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display_question;
        private System.Windows.Forms.TextBox Ans_0;
        private System.Windows.Forms.TextBox Ans_1;
        private System.Windows.Forms.TextBox Ans_2;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button SpeakButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Points;
    }
}

