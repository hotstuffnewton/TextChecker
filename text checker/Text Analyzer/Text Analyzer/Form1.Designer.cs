namespace Text_Analyzer
{
    partial class TextAnalysis
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
            this.inputbox = new System.Windows.Forms.TextBox();
            this.Analysisbutton = new System.Windows.Forms.Button();
            this.frequenciesOfIndividualLettersBox = new System.Windows.Forms.ComboBox();
            this.wordcountbox = new System.Windows.Forms.TextBox();
            this.totalchactersbox = new System.Windows.Forms.TextBox();
            this.Sentencecountbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(24, 14);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(498, 20);
            this.inputbox.TabIndex = 0;
            this.inputbox.Text = "Type here";
            this.inputbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Analysisbutton
            // 
            this.Analysisbutton.Location = new System.Drawing.Point(400, 53);
            this.Analysisbutton.Name = "Analysisbutton";
            this.Analysisbutton.Size = new System.Drawing.Size(88, 50);
            this.Analysisbutton.TabIndex = 1;
            this.Analysisbutton.Text = "Analysis";
            this.Analysisbutton.UseVisualStyleBackColor = true;
            this.Analysisbutton.Click += new System.EventHandler(this.Analysisbutton_Click);
            // 
            // frequenciesOfIndividualLettersBox
            // 
            this.frequenciesOfIndividualLettersBox.FormattingEnabled = true;
            this.frequenciesOfIndividualLettersBox.Location = new System.Drawing.Point(24, 56);
            this.frequenciesOfIndividualLettersBox.Name = "frequenciesOfIndividualLettersBox";
            this.frequenciesOfIndividualLettersBox.Size = new System.Drawing.Size(109, 21);
            this.frequenciesOfIndividualLettersBox.TabIndex = 2;
            this.frequenciesOfIndividualLettersBox.Text = "0";
            // 
            // wordcountbox
            // 
            this.wordcountbox.Location = new System.Drawing.Point(24, 109);
            this.wordcountbox.Name = "wordcountbox";
            this.wordcountbox.ReadOnly = true;
            this.wordcountbox.Size = new System.Drawing.Size(108, 20);
            this.wordcountbox.TabIndex = 3;
            this.wordcountbox.Text = "0";
            // 
            // totalchactersbox
            // 
            this.totalchactersbox.Location = new System.Drawing.Point(24, 83);
            this.totalchactersbox.Name = "totalchactersbox";
            this.totalchactersbox.ReadOnly = true;
            this.totalchactersbox.Size = new System.Drawing.Size(108, 20);
            this.totalchactersbox.TabIndex = 4;
            this.totalchactersbox.Text = "0";
            // 
            // Sentencecountbox
            // 
            this.Sentencecountbox.Location = new System.Drawing.Point(24, 135);
            this.Sentencecountbox.Name = "Sentencecountbox";
            this.Sentencecountbox.ReadOnly = true;
            this.Sentencecountbox.Size = new System.Drawing.Size(108, 20);
            this.Sentencecountbox.TabIndex = 5;
            this.Sentencecountbox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frequencies of individual letters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total chacters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Word count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sentence count";
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(400, 109);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(88, 50);
            this.clearbutton.TabIndex = 10;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // TextAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(554, 198);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sentencecountbox);
            this.Controls.Add(this.totalchactersbox);
            this.Controls.Add(this.wordcountbox);
            this.Controls.Add(this.frequenciesOfIndividualLettersBox);
            this.Controls.Add(this.Analysisbutton);
            this.Controls.Add(this.inputbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TextAnalysis";
            this.Text = "Text Analysis c#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button Analysisbutton;
        private System.Windows.Forms.ComboBox frequenciesOfIndividualLettersBox;
        private System.Windows.Forms.TextBox wordcountbox;
        private System.Windows.Forms.TextBox totalchactersbox;
        private System.Windows.Forms.TextBox Sentencecountbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearbutton;
    }
}

