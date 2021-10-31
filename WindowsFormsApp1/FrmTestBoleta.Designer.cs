
namespace WindowsFormsApp1
{
    partial class FrmTestBoleta
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
            this.dgvBoleta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidBoleta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoleta
            // 
            this.dgvBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoleta.Location = new System.Drawing.Point(186, 61);
            this.dgvBoleta.Name = "dgvBoleta";
            this.dgvBoleta.Size = new System.Drawing.Size(444, 287);
            this.dgvBoleta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nombre boleta";
            // 
            // txtidBoleta
            // 
            this.txtidBoleta.Location = new System.Drawing.Point(298, 22);
            this.txtidBoleta.Name = "txtidBoleta";
            this.txtidBoleta.Size = new System.Drawing.Size(200, 20);
            this.txtidBoleta.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(581, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmTestBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtidBoleta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBoleta);
            this.Name = "FrmTestBoleta";
            this.Text = "FrmTestBoleta";
            this.Load += new System.EventHandler(this.FrmTestBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoleta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidBoleta;
        private System.Windows.Forms.Button btnBuscar;
    }
}