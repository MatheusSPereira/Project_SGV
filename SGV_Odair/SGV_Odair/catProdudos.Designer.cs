namespace SGV_Odair
{
    partial class catProdudos
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
            this.txtCatProdut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnUlt = new System.Windows.Forms.Button();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCatProdut
            // 
            this.txtCatProdut.Location = new System.Drawing.Point(33, 53);
            this.txtCatProdut.Name = "txtCatProdut";
            this.txtCatProdut.Size = new System.Drawing.Size(299, 20);
            this.txtCatProdut.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nova Categoria:";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(40, 87);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(67, 23);
            this.btnNovo.TabIndex = 25;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(258, 87);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(69, 23);
            this.btnGravar.TabIndex = 28;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(113, 87);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(67, 23);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(186, 87);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(67, 23);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnUlt
            // 
            this.btnUlt.Location = new System.Drawing.Point(265, 131);
            this.btnUlt.Name = "btnUlt";
            this.btnUlt.Size = new System.Drawing.Size(82, 23);
            this.btnUlt.TabIndex = 32;
            this.btnUlt.Text = ">>";
            this.btnUlt.UseVisualStyleBackColor = true;
            // 
            // btnProx
            // 
            this.btnProx.Location = new System.Drawing.Point(185, 131);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(74, 23);
            this.btnProx.TabIndex = 31;
            this.btnProx.Text = ">";
            this.btnProx.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(20, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(327, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(101, 131);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(78, 23);
            this.btnAnt.TabIndex = 30;
            this.btnAnt.Text = "<";
            this.btnAnt.UseVisualStyleBackColor = true;
            // 
            // btnPrim
            // 
            this.btnPrim.Location = new System.Drawing.Point(20, 131);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(75, 23);
            this.btnPrim.TabIndex = 29;
            this.btnPrim.Text = "<<";
            this.btnPrim.UseVisualStyleBackColor = true;
            // 
            // catProdudos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 198);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnUlt);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatProdut);
            this.Name = "catProdudos";
            this.Text = "Categoria de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCatProdut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnUlt;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnPrim;
    }
}