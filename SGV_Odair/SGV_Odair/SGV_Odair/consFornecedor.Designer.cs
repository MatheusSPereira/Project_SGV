namespace SGV_Odair
{
    partial class consFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridConsFornecedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUF = new System.Windows.Forms.ComboBox();
            this.btnTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gridConsFornecedor
            // 
            this.gridConsFornecedor.AllowUserToAddRows = false;
            this.gridConsFornecedor.AllowUserToDeleteRows = false;
            this.gridConsFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "Consulta de Fornecedores";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridConsFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsFornecedor.Location = new System.Drawing.Point(11, 73);
            this.gridConsFornecedor.Name = "gridConsFornecedor";
            this.gridConsFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConsFornecedor.Size = new System.Drawing.Size(564, 196);
            this.gridConsFornecedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro por Estado:";
            // 
            // cbxUF
            // 
            this.cbxUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUF.FormattingEnabled = true;
            this.cbxUF.Location = new System.Drawing.Point(10, 36);
            this.cbxUF.Name = "cbxUF";
            this.cbxUF.Size = new System.Drawing.Size(121, 21);
            this.cbxUF.TabIndex = 2;
            this.cbxUF.SelectedIndexChanged += new System.EventHandler(this.cbxUF_SelectedIndexChanged);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(159, 19);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(109, 38);
            this.btnTodos.TabIndex = 3;
            this.btnTodos.Text = "Todos Registros";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // consFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 291);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.cbxUF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridConsFornecedor);
            this.Name = "consFornecedor";
            this.Text = "consFornecedor";
            this.Load += new System.EventHandler(this.consFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridConsFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUF;
        private System.Windows.Forms.Button btnTodos;
    }
}