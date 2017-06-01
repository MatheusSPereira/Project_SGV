namespace SGV_Odair
{
    partial class pedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodPed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDescProdut = new System.Windows.Forms.ComboBox();
            this.cbxTipMov = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdMov = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataPed = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnUlt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo do Pedido:";
            // 
            // txtCodPed
            // 
            this.txtCodPed.Location = new System.Drawing.Point(20, 63);
            this.txtCodPed.Name = "txtCodPed";
            this.txtCodPed.Size = new System.Drawing.Size(114, 20);
            this.txtCodPed.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data do Pedido:";
            // 
            // cbxDescProdut
            // 
            this.cbxDescProdut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDescProdut.FormattingEnabled = true;
            this.cbxDescProdut.Location = new System.Drawing.Point(19, 112);
            this.cbxDescProdut.Name = "cbxDescProdut";
            this.cbxDescProdut.Size = new System.Drawing.Size(289, 21);
            this.cbxDescProdut.TabIndex = 4;
            // 
            // cbxTipMov
            // 
            this.cbxTipMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipMov.FormattingEnabled = true;
            this.cbxTipMov.Location = new System.Drawing.Point(20, 161);
            this.cbxTipMov.Name = "cbxTipMov";
            this.cbxTipMov.Size = new System.Drawing.Size(121, 21);
            this.cbxTipMov.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Movimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Qtdade Movimento:";
            // 
            // txtQtdMov
            // 
            this.txtQtdMov.Location = new System.Drawing.Point(191, 159);
            this.txtQtdMov.Name = "txtQtdMov";
            this.txtQtdMov.Size = new System.Drawing.Size(117, 20);
            this.txtQtdMov.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataPed);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtQtdMov);
            this.groupBox1.Controls.Add(this.btnGravar);
            this.groupBox1.Controls.Add(this.txtCodPed);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxDescProdut);
            this.groupBox1.Controls.Add(this.cbxTipMov);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 227);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Movimentação";
            // 
            // txtDataPed
            // 
            this.txtDataPed.Location = new System.Drawing.Point(189, 63);
            this.txtDataPed.Name = "txtDataPed";
            this.txtDataPed.Size = new System.Drawing.Size(100, 20);
            this.txtDataPed.TabIndex = 22;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(242, 13);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(20, 194);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(67, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(238, 194);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(69, 23);
            this.btnGravar.TabIndex = 19;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(93, 194);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(166, 194);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(67, 23);
            this.btnAlterar.TabIndex = 18;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 267);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(327, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(12, 238);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(75, 23);
            this.btnPrim.TabIndex = 20;
            this.btnPrim.Text = "<<";
            this.btnPrim.UseVisualStyleBackColor = true;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(93, 238);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(78, 23);
            this.btnAnt.TabIndex = 21;
            this.btnAnt.Text = "<";
            this.btnAnt.UseVisualStyleBackColor = true;
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(177, 238);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(74, 23);
            this.btnProx.TabIndex = 22;
            this.btnProx.Text = ">";
            this.btnProx.UseVisualStyleBackColor = true;
            // 
            // btnUlt
            // 
            this.btnUlt.Location = new System.Drawing.Point(257, 238);
            this.btnUlt.Name = "btnUlt";
            this.btnUlt.Size = new System.Drawing.Size(82, 23);
            this.btnUlt.TabIndex = 23;
            this.btnUlt.Text = ">>";
            this.btnUlt.UseVisualStyleBackColor = true;
            this.btnUlt.Click += new System.EventHandler(this.btnUlt_Click);
            // 
            // pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUlt);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnPrim);
            this.Name = "pedido";
            this.Text = "Movimentação Estoque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodPed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDescProdut;
        private System.Windows.Forms.ComboBox cbxTipMov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtdMov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnUlt;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtDataPed;
    }
}