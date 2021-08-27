
namespace WindowsForms04
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAumento = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(181, 283);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(94, 39);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAumento
            // 
            this.btnAumento.Location = new System.Drawing.Point(116, 362);
            this.btnAumento.Name = "btnAumento";
            this.btnAumento.Size = new System.Drawing.Size(94, 39);
            this.btnAumento.TabIndex = 2;
            this.btnAumento.Text = "AUMENTO SALARIO";
            this.btnAumento.UseVisualStyleBackColor = true;
            this.btnAumento.Click += new System.EventHandler(this.btnAumento_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(134, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(134, 132);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(141, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(134, 190);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(141, 20);
            this.txtSalario.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(76, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(42, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "NOME:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(88, 135);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 7;
            this.lblCPF.Text = "CPF:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(62, 193);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(56, 13);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "SALARIO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnAumento);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnMostrar);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAumento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSalario;
    }
}

