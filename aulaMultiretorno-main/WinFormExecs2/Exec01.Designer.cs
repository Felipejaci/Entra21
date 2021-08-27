
namespace WinFormExecs2
{
    partial class Exec01
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
            this.cbNomes = new System.Windows.Forms.ComboBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dgPessoa = new System.Windows.Forms.DataGridView();
            this.idPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdadePessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNomes
            // 
            this.cbNomes.FormattingEnabled = true;
            this.cbNomes.Location = new System.Drawing.Point(79, 129);
            this.cbNomes.Name = "cbNomes";
            this.cbNomes.Size = new System.Drawing.Size(247, 21);
            this.cbNomes.TabIndex = 0;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(121, 193);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(173, 68);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.Text = "BUSCA";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // dgPessoa
            // 
            this.dgPessoa.AllowUserToAddRows = false;
            this.dgPessoa.AllowUserToDeleteRows = false;
            this.dgPessoa.AllowUserToOrderColumns = true;
            this.dgPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoa,
            this.NomePessoa,
            this.CpfPessoa,
            this.IdadePessoa});
            this.dgPessoa.Location = new System.Drawing.Point(12, 12);
            this.dgPessoa.Name = "dgPessoa";
            this.dgPessoa.ReadOnly = true;
            this.dgPessoa.Size = new System.Drawing.Size(386, 53);
            this.dgPessoa.TabIndex = 2;
            // 
            // idPessoa
            // 
            this.idPessoa.HeaderText = "ID";
            this.idPessoa.Name = "idPessoa";
            this.idPessoa.ReadOnly = true;
            this.idPessoa.Width = 28;
            // 
            // NomePessoa
            // 
            this.NomePessoa.HeaderText = "Nome";
            this.NomePessoa.Name = "NomePessoa";
            this.NomePessoa.ReadOnly = true;
            this.NomePessoa.Width = 120;
            // 
            // CpfPessoa
            // 
            this.CpfPessoa.HeaderText = "CPF";
            this.CpfPessoa.Name = "CpfPessoa";
            this.CpfPessoa.ReadOnly = true;
            // 
            // IdadePessoa
            // 
            this.IdadePessoa.HeaderText = "Idade";
            this.IdadePessoa.Name = "IdadePessoa";
            this.IdadePessoa.ReadOnly = true;
            this.IdadePessoa.Width = 95;
            // 
            // Exec01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 277);
            this.Controls.Add(this.dgPessoa);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.cbNomes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exec01";
            this.ShowIcon = false;
            this.Text = "Exec01";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exec01_FormClosed);
            this.Load += new System.EventHandler(this.Exec01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNomes;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DataGridView dgPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdadePessoa;
    }
}