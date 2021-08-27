
namespace WinFormExecs2
{
    partial class Exec03WinForm05
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
            this.DGHistorico = new System.Windows.Forms.DataGridView();
            this.IDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmCaixaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DespesasMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GanhosMesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorLiquidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeLucrouCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtGanhos = new System.Windows.Forms.TextBox();
            this.txtDespesas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // DGHistorico
            // 
            this.DGHistorico.AllowUserToAddRows = false;
            this.DGHistorico.AllowUserToDeleteRows = false;
            this.DGHistorico.AllowUserToOrderColumns = true;
            this.DGHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGHistorico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCol,
            this.ValorEmCaixaCol,
            this.DespesasMesCol,
            this.GanhosMesCol,
            this.ValorLiquidoCol,
            this.SeLucrouCol});
            this.DGHistorico.Location = new System.Drawing.Point(12, 12);
            this.DGHistorico.Name = "DGHistorico";
            this.DGHistorico.ReadOnly = true;
            this.DGHistorico.RowTemplate.Height = 30;
            this.DGHistorico.Size = new System.Drawing.Size(694, 294);
            this.DGHistorico.TabIndex = 0;
            // 
            // IDCol
            // 
            this.IDCol.HeaderText = "ID";
            this.IDCol.Name = "IDCol";
            this.IDCol.ReadOnly = true;
            this.IDCol.Width = 65;
            // 
            // ValorEmCaixaCol
            // 
            this.ValorEmCaixaCol.HeaderText = "ValorEmCaixa";
            this.ValorEmCaixaCol.Name = "ValorEmCaixaCol";
            this.ValorEmCaixaCol.ReadOnly = true;
            this.ValorEmCaixaCol.Width = 130;
            // 
            // DespesasMesCol
            // 
            this.DespesasMesCol.HeaderText = "DespesasMes";
            this.DespesasMesCol.Name = "DespesasMesCol";
            this.DespesasMesCol.ReadOnly = true;
            this.DespesasMesCol.Width = 130;
            // 
            // GanhosMesCol
            // 
            this.GanhosMesCol.HeaderText = "GanhosMes";
            this.GanhosMesCol.Name = "GanhosMesCol";
            this.GanhosMesCol.ReadOnly = true;
            this.GanhosMesCol.Width = 130;
            // 
            // ValorLiquidoCol
            // 
            this.ValorLiquidoCol.HeaderText = "ValorLiquido";
            this.ValorLiquidoCol.Name = "ValorLiquidoCol";
            this.ValorLiquidoCol.ReadOnly = true;
            this.ValorLiquidoCol.Width = 130;
            // 
            // SeLucrouCol
            // 
            this.SeLucrouCol.HeaderText = "SeLucrou";
            this.SeLucrouCol.Name = "SeLucrouCol";
            this.SeLucrouCol.ReadOnly = true;
            this.SeLucrouCol.Width = 66;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(629, 410);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 38);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtGanhos
            // 
            this.txtGanhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGanhos.Location = new System.Drawing.Point(85, 347);
            this.txtGanhos.Name = "txtGanhos";
            this.txtGanhos.Size = new System.Drawing.Size(174, 26);
            this.txtGanhos.TabIndex = 2;
            // 
            // txtDespesas
            // 
            this.txtDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDespesas.Location = new System.Drawing.Point(85, 392);
            this.txtDespesas.Name = "txtDespesas";
            this.txtDespesas.Size = new System.Drawing.Size(174, 26);
            this.txtDespesas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ganhos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "despesas";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(350, 398);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(169, 50);
            this.btnCalcula.TabIndex = 6;
            this.btnCalcula.Text = "CALCULA";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // Exec03WinForm05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 460);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDespesas);
            this.Controls.Add(this.txtGanhos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.DGHistorico);
            this.Name = "Exec03WinForm05";
            this.Text = "Exec03WinForm05";
            this.Load += new System.EventHandler(this.Exec03WinForm05_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGHistorico;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmCaixaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DespesasMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GanhosMesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLiquidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeLucrouCol;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtGanhos;
        private System.Windows.Forms.TextBox txtDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcula;
    }
}