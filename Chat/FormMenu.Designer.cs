namespace Chat
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStrip1 = new MenuStrip();
            tIENDASToolStripMenuItem = new ToolStripMenuItem();
            tABLASToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tIENDASToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(811, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tIENDASToolStripMenuItem
            // 
            tIENDASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tABLASToolStripMenuItem });
            tIENDASToolStripMenuItem.Name = "tIENDASToolStripMenuItem";
            tIENDASToolStripMenuItem.Size = new Size(99, 29);
            tIENDASToolStripMenuItem.Text = "TIENDAS";
            // 
            // tABLASToolStripMenuItem
            // 
            tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            tABLASToolStripMenuItem.Size = new Size(270, 34);
            tABLASToolStripMenuItem.Text = "TABLAS";
            tABLASToolStripMenuItem.Click += tABLASToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(288, 136);
            label2.Name = "label2";
            label2.Size = new Size(202, 175);
            label2.TabIndex = 5;
            label2.Text = "                                      \r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(12, 50);
            label3.Name = "label3";
            label3.Size = new Size(769, 65);
            label3.TabIndex = 6;
            label3.Text = "Siempre cerca, siempre contigo";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(811, 320);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tIENDASToolStripMenuItem;
        private ToolStripMenuItem tABLASToolStripMenuItem;
        private Label label2;
        private Label label3;
    }
}