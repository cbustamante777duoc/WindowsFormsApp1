
namespace WindowsFormsApp1
{
    partial class FrmListarMerma
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
            this.dgvListarMerma = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMerma)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarMerma
            // 
            this.dgvListarMerma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListarMerma.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListarMerma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarMerma.Location = new System.Drawing.Point(67, 54);
            this.dgvListarMerma.Name = "dgvListarMerma";
            this.dgvListarMerma.Size = new System.Drawing.Size(629, 264);
            this.dgvListarMerma.TabIndex = 0;
            // 
            // FrmListarMerma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListarMerma);
            this.Name = "FrmListarMerma";
            this.Text = "FrmListarMerma";
            this.Load += new System.EventHandler(this.FrmListarMerma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarMerma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarMerma;
    }
}