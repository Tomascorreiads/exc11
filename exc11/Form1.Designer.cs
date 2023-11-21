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
            azulToolStripMenuItem = new ToolStripMenuItem();
            vermelhoToolStripMenuItem = new ToolStripMenuItem();
            aumentarALetraToolStripMenuItem = new ToolStripMenuItem();
            diminuirALetraToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { forrmatarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(799, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // forrmatarToolStripMenuItem
            // 
            forrmatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { letraToolStripMenuItem, menuToolStripMenuItem });
            forrmatarToolStripMenuItem.Name = "forrmatarToolStripMenuItem";
            forrmatarToolStripMenuItem.Size = new Size(74, 20);
            forrmatarToolStripMenuItem.Text = "Forrmatar ";
            forrmatarToolStripMenuItem.Click += forrmatarToolStripMenuItem_Click;
            // 
            // letraToolStripMenuItem
            // 
            letraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { azulToolStripMenuItem, vermelhoToolStripMenuItem, aumentarALetraToolStripMenuItem, diminuirALetraToolStripMenuItem });
            letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            letraToolStripMenuItem.Size = new Size(180, 22);
            letraToolStripMenuItem.Text = "Cor e tipo de letra";
            letraToolStripMenuItem.Click += letraToolStripMenuItem_Click;
            // 
            // azulToolStripMenuItem
            // 
            azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            azulToolStripMenuItem.Size = new Size(165, 22);
            azulToolStripMenuItem.Text = "Azul";
            azulToolStripMenuItem.Click += azulToolStripMenuItem_Click;
            // 
            // vermelhoToolStripMenuItem
            // 
            vermelhoToolStripMenuItem.Name = "vermelhoToolStripMenuItem";
            vermelhoToolStripMenuItem.Size = new Size(165, 22);
            vermelhoToolStripMenuItem.Text = "Vermelho ";
            vermelhoToolStripMenuItem.Click += vermelhoToolStripMenuItem_Click;
            // 
            // aumentarALetraToolStripMenuItem
            // 
            aumentarALetraToolStripMenuItem.Name = "aumentarALetraToolStripMenuItem";
            aumentarALetraToolStripMenuItem.Size = new Size(165, 22);
            aumentarALetraToolStripMenuItem.Text = "Aumentar a letra ";
            aumentarALetraToolStripMenuItem.Click += aumentarALetraToolStripMenuItem_Click;
            // 
            // diminuirALetraToolStripMenuItem
            // 
            diminuirALetraToolStripMenuItem.Name = "diminuirALetraToolStripMenuItem";
            diminuirALetraToolStripMenuItem.Size = new Size(165, 22);
            diminuirALetraToolStripMenuItem.Text = "Diminuir a letra";
            diminuirALetraToolStripMenuItem.Click += diminuirALetraToolStripMenuItem_Click;
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
            // button1
            // 
            button1.Location = new Point(564, 367);
            button1.Name = "button1";
            button1.Size = new Size(123, 23);
            button1.TabIndex = 2;
            button1.Text = "Pagina 2 -->";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(180, 22);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 450);
            Controls.Add(button1);
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
        private ToolStripMenuItem azulToolStripMenuItem;
        private ToolStripMenuItem vermelhoToolStripMenuItem;
        private ToolStripMenuItem aumentarALetraToolStripMenuItem;
        private ToolStripMenuItem diminuirALetraToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem menuToolStripMenuItem;
    }
}