namespace TestLinkXMlConverter
{
    partial class TestLinkXMLConverterForm
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
            this.FileName_tb = new System.Windows.Forms.TextBox();
            this.FileLabel = new System.Windows.Forms.Label();
            this.Open_button = new System.Windows.Forms.Button();
            this.Convert_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileName_tb
            // 
            this.FileName_tb.Location = new System.Drawing.Point(69, 28);
            this.FileName_tb.Name = "FileName_tb";
            this.FileName_tb.Size = new System.Drawing.Size(319, 20);
            this.FileName_tb.TabIndex = 0;
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(12, 31);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(51, 13);
            this.FileLabel.TabIndex = 1;
            this.FileLabel.Text = "XML File:";
            // 
            // Open_button
            // 
            this.Open_button.Location = new System.Drawing.Point(402, 24);
            this.Open_button.Name = "Open_button";
            this.Open_button.Size = new System.Drawing.Size(75, 23);
            this.Open_button.TabIndex = 2;
            this.Open_button.Text = "Open...";
            this.Open_button.UseVisualStyleBackColor = true;
            this.Open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // Convert_button
            // 
            this.Convert_button.Location = new System.Drawing.Point(402, 55);
            this.Convert_button.Name = "Convert_button";
            this.Convert_button.Size = new System.Drawing.Size(75, 40);
            this.Convert_button.TabIndex = 3;
            this.Convert_button.Text = "Convert and Save";
            this.Convert_button.UseVisualStyleBackColor = true;
            this.Convert_button.Click += new System.EventHandler(this.Convert_button_Click);
            // 
            // TestLinkXMLConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 107);
            this.Controls.Add(this.Convert_button);
            this.Controls.Add(this.Open_button);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.FileName_tb);
            this.Name = "TestLinkXMLConverterForm";
            this.Text = "TestLink XML Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileName_tb;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Button Open_button;
        private System.Windows.Forms.Button Convert_button;
    }
}

