namespace ToolStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslbl = new System.Windows.Forms.ToolStripLabel();
            this.tsTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsPlus = new System.Windows.Forms.ToolStripButton();
            this.tsMinas = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Salmon;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbl,
            this.tsTextBox,
            this.tsPlus,
            this.tsMinas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(460, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslbl
            // 
            this.tslbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tslbl.Name = "tslbl";
            this.tslbl.Size = new System.Drawing.Size(112, 22);
            this.tslbl.Text = "tape Your Text Here:";
            // 
            // tsTextBox
            // 
            this.tsTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.tsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTextBox.Name = "tsTextBox";
            this.tsTextBox.Size = new System.Drawing.Size(100, 25);
            this.tsTextBox.Click += new System.EventHandler(this.tsTextBox_Click);
            this.tsTextBox.TextChanged += new System.EventHandler(this.tsTextBox_TextChanged);
            // 
            // tsPlus
            // 
            this.tsPlus.BackColor = System.Drawing.Color.Snow;
            this.tsPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPlus.Image = ((System.Drawing.Image)(resources.GetObject("tsPlus.Image")));
            this.tsPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPlus.Name = "tsPlus";
            this.tsPlus.Size = new System.Drawing.Size(23, 22);
            this.tsPlus.Text = "toolStripButton1";
            this.tsPlus.Click += new System.EventHandler(this.tsPlus_Click);
            // 
            // tsMinas
            // 
            this.tsMinas.BackColor = System.Drawing.Color.White;
            this.tsMinas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsMinas.Image = ((System.Drawing.Image)(resources.GetObject("tsMinas.Image")));
            this.tsMinas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMinas.Name = "tsMinas";
            this.tsMinas.Size = new System.Drawing.Size(23, 22);
            this.tsMinas.Text = "toolStripButton2";
            this.tsMinas.Click += new System.EventHandler(this.tsMinas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(184, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(460, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslbl;
        private System.Windows.Forms.ToolStripTextBox tsTextBox;
        private System.Windows.Forms.ToolStripButton tsPlus;
        private System.Windows.Forms.ToolStripButton tsMinas;
        private System.Windows.Forms.Label label1;
    }
}

