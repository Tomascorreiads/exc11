namespace exc11
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
            forrmatarToolStripMenuItem = new ToolStripMenuItem();
            letraToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { forrmatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // forrmatarToolStripMenuItem
            // 
            forrmatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { letraToolStripMenuItem });
            forrmatarToolStripMenuItem.Name = "forrmatarToolStripMenuItem";
            forrmatarToolStripMenuItem.Size = new Size(74, 20);
            forrmatarToolStripMenuItem.Text = "Forrmatar ";
            forrmatarToolStripMenuItem.Click += forrmatarToolStripMenuItem_Click;
            // 
            // letraToolStripMenuItem
            // 
            letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            letraToolStripMenuItem.Size = new Size(180, 22);
            letraToolStripMenuItem.Text = "Cor e tipo de letra";
            letraToolStripMenuItem.Click += letraToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 114);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "POO em C#";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem forrmatarToolStripMenuItem;
        private ToolStripMenuItem letraToolStripMenuItem;
        private Label label1;
    }
}