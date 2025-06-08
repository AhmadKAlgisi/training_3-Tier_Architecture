namespace desktop_app_3_tier_in_containt
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
            this.components = new System.ComponentModel.Container();
            this.DGVLIST_CONTANT = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_add_countant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLIST_CONTANT)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVLIST_CONTANT
            // 
            this.DGVLIST_CONTANT.AllowUserToAddRows = false;
            this.DGVLIST_CONTANT.AllowUserToDeleteRows = false;
            this.DGVLIST_CONTANT.AllowUserToOrderColumns = true;
            this.DGVLIST_CONTANT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLIST_CONTANT.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVLIST_CONTANT.Location = new System.Drawing.Point(79, 112);
            this.DGVLIST_CONTANT.Name = "DGVLIST_CONTANT";
            this.DGVLIST_CONTANT.ReadOnly = true;
            this.DGVLIST_CONTANT.RowHeadersWidth = 62;
            this.DGVLIST_CONTANT.RowTemplate.Height = 28;
            this.DGVLIST_CONTANT.Size = new System.Drawing.Size(1522, 438);
            this.DGVLIST_CONTANT.TabIndex = 0;
          //  this.DGVLIST_CONTANT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLIST_CONTANT_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 68);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(141, 32);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.eDITToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(141, 32);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.dELETEToolStripMenuItem_Click);
            // 
            // button_add_countant
            // 
            this.button_add_countant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_countant.Location = new System.Drawing.Point(1134, 44);
            this.button_add_countant.Name = "button_add_countant";
            this.button_add_countant.Size = new System.Drawing.Size(313, 62);
            this.button_add_countant.TabIndex = 2;
            this.button_add_countant.Text = "ADD_COUNTINT";
            this.button_add_countant.UseVisualStyleBackColor = true;
            this.button_add_countant.Click += new System.EventHandler(this.button_add_countant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 640);
            this.Controls.Add(this.button_add_countant);
            this.Controls.Add(this.DGVLIST_CONTANT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLIST_CONTANT)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVLIST_CONTANT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.Button button_add_countant;
    }
}

