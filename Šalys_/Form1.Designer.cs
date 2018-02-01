namespace Šalys_
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.failasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.skaciavimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baigtiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.latvijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lietuvaEuropaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuskaitytiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.latvijaToolStripMenuItem,
            this.lietuvaEuropaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem1,
            this.skaciavimaiToolStripMenuItem,
            this.baigtiToolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(357, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // failasToolStripMenuItem1
            // 
            this.failasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuskaitytiToolStripMenuItem});
            this.failasToolStripMenuItem1.Name = "failasToolStripMenuItem1";
            this.failasToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.failasToolStripMenuItem1.Text = "Failas";
            // 
            // skaciavimaiToolStripMenuItem
            // 
            this.skaciavimaiToolStripMenuItem.Name = "skaciavimaiToolStripMenuItem";
            this.skaciavimaiToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.skaciavimaiToolStripMenuItem.Text = "Skaciavimai";
            // 
            // baigtiToolStripMenuItem2
            // 
            this.baigtiToolStripMenuItem2.Name = "baigtiToolStripMenuItem2";
            this.baigtiToolStripMenuItem2.Size = new System.Drawing.Size(49, 20);
            this.baigtiToolStripMenuItem2.Text = "Baigti";
            this.baigtiToolStripMenuItem2.Click += new System.EventHandler(this.baigtiToolStripMenuItem2_Click);
            // 
            // latvijaToolStripMenuItem
            // 
            this.latvijaToolStripMenuItem.Name = "latvijaToolStripMenuItem";
            this.latvijaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.latvijaToolStripMenuItem.Text = "Latvija (Europa)";
            this.latvijaToolStripMenuItem.Click += new System.EventHandler(this.latvijaToolStripMenuItem_Click);
            // 
            // lietuvaEuropaToolStripMenuItem
            // 
            this.lietuvaEuropaToolStripMenuItem.Name = "lietuvaEuropaToolStripMenuItem";
            this.lietuvaEuropaToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.lietuvaEuropaToolStripMenuItem.Text = "Lietuva (Europa)";
            // 
            // nuskaitytiToolStripMenuItem
            // 
            this.nuskaitytiToolStripMenuItem.Name = "nuskaitytiToolStripMenuItem";
            this.nuskaitytiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuskaitytiToolStripMenuItem.Text = "Nuskaityti";
            this.nuskaitytiToolStripMenuItem.Click += new System.EventHandler(this.nuskaitytiToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 230);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem latvijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lietuvaEuropaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem skaciavimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baigtiToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nuskaitytiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

