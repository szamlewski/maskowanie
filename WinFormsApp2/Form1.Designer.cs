namespace WinFormsApp2
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
            button1 = new Button();
            inputBox = new RichTextBox();
            outputBox = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 169);
            button1.Name = "button1";
            button1.Size = new Size(776, 100);
            button1.TabIndex = 1;
            button1.Text = "MASKUJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inputBox
            // 
            inputBox.Location = new Point(12, 12);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(776, 151);
            inputBox.TabIndex = 2;
            inputBox.Text = "";
            // 
            // outputBox
            // 
            outputBox.Location = new Point(12, 275);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(776, 163);
            outputBox.TabIndex = 3;
            outputBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputBox);
            Controls.Add(inputBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox inputBox;
        private RichTextBox outputBox;
    }
}