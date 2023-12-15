namespace Display.Windows
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
            menuStrip1 = new MenuStrip();
            pluginsToolStripMenuItem = new ToolStripMenuItem();
            addPluginToolStripMenuItem = new ToolStripMenuItem();
            loadadPluginsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            numericUpDownWidth = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownX = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            buttonColor = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pluginsToolStripMenuItem, loadadPluginsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(543, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pluginsToolStripMenuItem
            // 
            pluginsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPluginToolStripMenuItem });
            pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            pluginsToolStripMenuItem.Size = new Size(58, 20);
            pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // addPluginToolStripMenuItem
            // 
            addPluginToolStripMenuItem.Name = "addPluginToolStripMenuItem";
            addPluginToolStripMenuItem.Size = new Size(132, 22);
            addPluginToolStripMenuItem.Text = "Plugin Ekle";
            addPluginToolStripMenuItem.Click += addPluginToolStripMenuItem_Click;
            // 
            // loadadPluginsToolStripMenuItem
            // 
            loadadPluginsToolStripMenuItem.Name = "loadadPluginsToolStripMenuItem";
            loadadPluginsToolStripMenuItem.Size = new Size(100, 20);
            loadadPluginsToolStripMenuItem.Text = "Loaded Plugins";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(38, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 324);
            panel1.TabIndex = 1;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(38, 71);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(56, 23);
            numericUpDownWidth.TabIndex = 2;
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(100, 71);
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(56, 23);
            numericUpDownHeight.TabIndex = 3;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(162, 71);
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(56, 23);
            numericUpDownX.TabIndex = 4;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Location = new Point(236, 71);
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(56, 23);
            numericUpDownY.TabIndex = 5;
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(311, 71);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(75, 23);
            buttonColor.TabIndex = 6;
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 468);
            Controls.Add(buttonColor);
            Controls.Add(numericUpDownY);
            Controls.Add(numericUpDownX);
            Controls.Add(numericUpDownHeight);
            Controls.Add(numericUpDownWidth);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pluginsToolStripMenuItem;
        private ToolStripMenuItem addPluginToolStripMenuItem;
        private ToolStripMenuItem loadadPluginsToolStripMenuItem;
        private Panel panel1;
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownHeight;
        private NumericUpDown numericUpDownX;
        private NumericUpDown numericUpDownY;
        private Button buttonColor;
    }
}