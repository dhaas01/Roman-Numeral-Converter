namespace Roman_Numeral_Converter
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.RomanNumeralTextLabel = new System.Windows.Forms.Label();
            this.romanNumeralLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(274, 58);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(31, 61);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(141, 13);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Enter a number from 1 to 10:";
            // 
            // RomanNumeralTextLabel
            // 
            this.RomanNumeralTextLabel.AutoSize = true;
            this.RomanNumeralTextLabel.Location = new System.Drawing.Point(31, 99);
            this.RomanNumeralTextLabel.Name = "RomanNumeralTextLabel";
            this.RomanNumeralTextLabel.Size = new System.Drawing.Size(216, 13);
            this.RomanNumeralTextLabel.TabIndex = 2;
            this.RomanNumeralTextLabel.Text = "The roman numeral version of the number is:";
            // 
            // romanNumeralLabel
            // 
            this.romanNumeralLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.romanNumeralLabel.Location = new System.Drawing.Point(274, 94);
            this.romanNumeralLabel.Name = "romanNumeralLabel";
            this.romanNumeralLabel.Size = new System.Drawing.Size(100, 23);
            this.romanNumeralLabel.TabIndex = 3;
            this.romanNumeralLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(172, 147);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 47);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert to Roman Numeral";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(253, 147);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(253, 171);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 333);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.romanNumeralLabel);
            this.Controls.Add(this.RomanNumeralTextLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label RomanNumeralTextLabel;
        private System.Windows.Forms.Label romanNumeralLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

