
namespace WindowsForms04
{
    partial class Almento
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
            this.btnAtualizarSalario = new System.Windows.Forms.Button();
            this.txtNewSalario = new System.Windows.Forms.TextBox();
            this.txtFuncioProcu = new System.Windows.Forms.TextBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblNewSalario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAtualizarSalario
            // 
            this.btnAtualizarSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarSalario.Location = new System.Drawing.Point(104, 260);
            this.btnAtualizarSalario.Name = "btnAtualizarSalario";
            this.btnAtualizarSalario.Size = new System.Drawing.Size(90, 40);
            this.btnAtualizarSalario.TabIndex = 0;
            this.btnAtualizarSalario.Text = "Atualizar";
            this.btnAtualizarSalario.UseVisualStyleBackColor = true;
            this.btnAtualizarSalario.Click += new System.EventHandler(this.btnAtualizarSalario_Click);
            // 
            // txtNewSalario
            // 
            this.txtNewSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewSalario.Location = new System.Drawing.Point(161, 154);
            this.txtNewSalario.Name = "txtNewSalario";
            this.txtNewSalario.Size = new System.Drawing.Size(122, 23);
            this.txtNewSalario.TabIndex = 1;
            // 
            // txtFuncioProcu
            // 
            this.txtFuncioProcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncioProcu.Location = new System.Drawing.Point(161, 113);
            this.txtFuncioProcu.Name = "txtFuncioProcu";
            this.txtFuncioProcu.Size = new System.Drawing.Size(122, 23);
            this.txtFuncioProcu.TabIndex = 2;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(12, 116);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(143, 17);
            this.lblFuncionario.TabIndex = 3;
            this.lblFuncionario.Text = "Nome do Funcionario";
            // 
            // lblNewSalario
            // 
            this.lblNewSalario.AutoSize = true;
            this.lblNewSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSalario.Location = new System.Drawing.Point(66, 154);
            this.lblNewSalario.Name = "lblNewSalario";
            this.lblNewSalario.Size = new System.Drawing.Size(89, 17);
            this.lblNewSalario.TabIndex = 4;
            this.lblNewSalario.Text = "Novo Salario";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(244, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 22);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Almento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 366);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblNewSalario);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtFuncioProcu);
            this.Controls.Add(this.txtNewSalario);
            this.Controls.Add(this.btnAtualizarSalario);
            this.Name = "Almento";
            this.Text = "Almento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarSalario;
        private System.Windows.Forms.TextBox txtNewSalario;
        private System.Windows.Forms.TextBox txtFuncioProcu;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblNewSalario;
        private System.Windows.Forms.Button btnSair;
    }
}