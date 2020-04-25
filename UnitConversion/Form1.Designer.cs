namespace UnitConversion
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
            this.choice1 = new System.Windows.Forms.Label();
            this.choice2 = new System.Windows.Forms.Label();
            this.choice3 = new System.Windows.Forms.Label();
            this.choice4 = new System.Windows.Forms.Label();
            this.choiceBox = new System.Windows.Forms.TextBox();
            this.choicelabel = new System.Windows.Forms.Label();
            this.conversionBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choice1
            // 
            this.choice1.AutoSize = true;
            this.choice1.Location = new System.Drawing.Point(323, 103);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(121, 13);
            this.choice1.TabIndex = 0;
            this.choice1.Text = "1. Inches to Centimetres";
            // 
            // choice2
            // 
            this.choice2.AutoSize = true;
            this.choice2.Location = new System.Drawing.Point(323, 129);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(110, 13);
            this.choice2.TabIndex = 1;
            this.choice2.Text = "2. Feet to Centimetres";
            // 
            // choice3
            // 
            this.choice3.AutoSize = true;
            this.choice3.Location = new System.Drawing.Point(323, 154);
            this.choice3.Name = "choice3";
            this.choice3.Size = new System.Drawing.Size(93, 13);
            this.choice3.TabIndex = 2;
            this.choice3.Text = "3. Yards to Metres";
            this.choice3.Click += new System.EventHandler(this.label3_Click);
            // 
            // choice4
            // 
            this.choice4.AutoSize = true;
            this.choice4.Location = new System.Drawing.Point(323, 176);
            this.choice4.Name = "choice4";
            this.choice4.Size = new System.Drawing.Size(106, 13);
            this.choice4.TabIndex = 3;
            this.choice4.Text = "4. Miles to Kilometres";
            // 
            // choiceBox
            // 
            this.choiceBox.Location = new System.Drawing.Point(437, 259);
            this.choiceBox.Name = "choiceBox";
            this.choiceBox.Size = new System.Drawing.Size(100, 20);
            this.choiceBox.TabIndex = 4;
            // 
            // choicelabel
            // 
            this.choicelabel.AutoSize = true;
            this.choicelabel.Location = new System.Drawing.Point(274, 262);
            this.choicelabel.Name = "choicelabel";
            this.choicelabel.Size = new System.Drawing.Size(124, 13);
            this.choicelabel.TabIndex = 5;
            this.choicelabel.Text = "Enter Conversion Choice";
            // 
            // conversionBox
            // 
            this.conversionBox.Location = new System.Drawing.Point(437, 294);
            this.conversionBox.Name = "conversionBox";
            this.conversionBox.Size = new System.Drawing.Size(100, 20);
            this.conversionBox.TabIndex = 6;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(274, 301);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(139, 13);
            this.valueLabel.TabIndex = 7;
            this.valueLabel.Text = "Enter value to be converted";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(354, 331);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 8;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // convertLabel
            // 
            this.convertLabel.AutoSize = true;
            this.convertLabel.Location = new System.Drawing.Point(323, 387);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(0, 13);
            this.convertLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.conversionBox);
            this.Controls.Add(this.choicelabel);
            this.Controls.Add(this.choiceBox);
            this.Controls.Add(this.choice4);
            this.Controls.Add(this.choice3);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choice1;
        private System.Windows.Forms.Label choice2;
        private System.Windows.Forms.Label choice3;
        private System.Windows.Forms.Label choice4;
        private System.Windows.Forms.TextBox choiceBox;
        private System.Windows.Forms.Label choicelabel;
        private System.Windows.Forms.TextBox conversionBox;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label convertLabel;
    }
}

