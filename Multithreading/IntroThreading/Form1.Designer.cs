namespace IntroThreading
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
            buttonSay = new Button();
            labelCounter = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonSay
            // 
            buttonSay.Location = new Point(172, 93);
            buttonSay.Name = "buttonSay";
            buttonSay.Size = new Size(75, 23);
            buttonSay.TabIndex = 0;
            buttonSay.Text = "Say";
            buttonSay.UseVisualStyleBackColor = true;
            buttonSay.Click += buttonSay_Click;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(198, 138);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(16, 15);
            labelCounter.TabIndex = 1;
            labelCounter.Text = "...";
            // 
            // button1
            // 
            button1.Location = new Point(305, 226);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 275);
            Controls.Add(button1);
            Controls.Add(labelCounter);
            Controls.Add(buttonSay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSay;
        private Label labelCounter;
        private Button button1;
    }
}