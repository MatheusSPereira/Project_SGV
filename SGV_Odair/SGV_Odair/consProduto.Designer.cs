namespace SGV_Odair
{
    partial class consProduto
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
            this.gridConsProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConsProduto
            // 
            this.gridConsProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsProduto.Location = new System.Drawing.Point(12, 44);
            this.gridConsProduto.Name = "gridConsProduto";
            this.gridConsProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConsProduto.Size = new System.Drawing.Size(536, 224);
            this.gridConsProduto.TabIndex = 0;
            this.gridConsProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridConsProduto_CellFormatting);
            // 
            // consProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 280);
            this.Controls.Add(this.gridConsProduto);
            this.Name = "consProduto";
            this.Text = "consProduto";
            this.Load += new System.EventHandler(this.consProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridConsProduto;
    }
}