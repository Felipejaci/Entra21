
namespace WinFormExecs2
{
    partial class Exec03
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
            this.dgMercado = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCarrinho = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMercado = new System.Windows.Forms.Label();
            this.lblCarrinho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMercado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMercado
            // 
            this.dgMercado.AllowUserToAddRows = false;
            this.dgMercado.AllowUserToDeleteRows = false;
            this.dgMercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMercado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.NomeProd,
            this.precoProd,
            this.fornecedorProd});
            this.dgMercado.Location = new System.Drawing.Point(14, 172);
            this.dgMercado.Name = "dgMercado";
            this.dgMercado.ReadOnly = true;
            this.dgMercado.Size = new System.Drawing.Size(322, 293);
            this.dgMercado.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(112, 124);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 41);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(455, 124);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(133, 41);
            this.btnResultado.TabIndex = 3;
            this.btnResultado.Text = "Resultado";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(15, 55);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(52, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 30);
            this.txtID.TabIndex = 5;
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "ID";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Width = 30;
            // 
            // NomeProd
            // 
            this.NomeProd.HeaderText = "Nome";
            this.NomeProd.Name = "NomeProd";
            this.NomeProd.ReadOnly = true;
            // 
            // precoProd
            // 
            this.precoProd.HeaderText = "Preco";
            this.precoProd.Name = "precoProd";
            this.precoProd.ReadOnly = true;
            this.precoProd.Width = 90;
            // 
            // fornecedorProd
            // 
            this.fornecedorProd.HeaderText = "Fornecedor";
            this.fornecedorProd.Name = "fornecedorProd";
            this.fornecedorProd.ReadOnly = true;
            this.fornecedorProd.Width = 90;
            // 
            // dgCarrinho
            // 
            this.dgCarrinho.AllowUserToAddRows = false;
            this.dgCarrinho.AllowUserToDeleteRows = false;
            this.dgCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgCarrinho.Location = new System.Drawing.Point(353, 171);
            this.dgCarrinho.Name = "dgCarrinho";
            this.dgCarrinho.ReadOnly = true;
            this.dgCarrinho.Size = new System.Drawing.Size(322, 293);
            this.dgCarrinho.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 124;
            // 
            // lblMercado
            // 
            this.lblMercado.AutoSize = true;
            this.lblMercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMercado.Location = new System.Drawing.Point(10, 149);
            this.lblMercado.Name = "lblMercado";
            this.lblMercado.Size = new System.Drawing.Size(75, 20);
            this.lblMercado.TabIndex = 7;
            this.lblMercado.Text = "Mercado:";
            // 
            // lblCarrinho
            // 
            this.lblCarrinho.AutoSize = true;
            this.lblCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrinho.Location = new System.Drawing.Point(349, 149);
            this.lblCarrinho.Name = "lblCarrinho";
            this.lblCarrinho.Size = new System.Drawing.Size(73, 20);
            this.lblCarrinho.TabIndex = 8;
            this.lblCarrinho.Text = "Carrinho:";
            // 
            // Exec03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 476);
            this.Controls.Add(this.lblCarrinho);
            this.Controls.Add(this.lblMercado);
            this.Controls.Add(this.dgCarrinho);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgMercado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exec03";
            this.ShowIcon = false;
            this.Text = "Exec03";
            this.Load += new System.EventHandler(this.Exec03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMercado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMercado;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorProd;
        private System.Windows.Forms.DataGridView dgCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblMercado;
        private System.Windows.Forms.Label lblCarrinho;
    }
}