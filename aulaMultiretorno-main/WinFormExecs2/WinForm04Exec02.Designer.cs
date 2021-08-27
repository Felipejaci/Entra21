
namespace WinFormExecs2
{
    partial class WinForm04Exec02
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
            this.cbVagasLivres = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.rbSair = new System.Windows.Forms.RadioButton();
            this.rbEntrar = new System.Windows.Forms.RadioButton();
            this.cbPlacas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbVagasLivres
            // 
            this.cbVagasLivres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVagasLivres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVagasLivres.FormattingEnabled = true;
            this.cbVagasLivres.Location = new System.Drawing.Point(59, 126);
            this.cbVagasLivres.Name = "cbVagasLivres";
            this.cbVagasLivres.Size = new System.Drawing.Size(261, 24);
            this.cbVagasLivres.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(128, 211);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(132, 30);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(331, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 20);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(138, 82);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(182, 23);
            this.txtPlaca.TabIndex = 3;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(83, 83);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(49, 18);
            this.lblPlaca.TabIndex = 4;
            this.lblPlaca.Text = "Placa:";
            // 
            // rbSair
            // 
            this.rbSair.AutoSize = true;
            this.rbSair.Location = new System.Drawing.Point(217, 175);
            this.rbSair.Name = "rbSair";
            this.rbSair.Size = new System.Drawing.Size(43, 17);
            this.rbSair.TabIndex = 5;
            this.rbSair.TabStop = true;
            this.rbSair.Text = "Sair";
            this.rbSair.UseVisualStyleBackColor = true;
            this.rbSair.CheckedChanged += new System.EventHandler(this.rbSair_CheckedChanged);
            // 
            // rbEntrar
            // 
            this.rbEntrar.AutoSize = true;
            this.rbEntrar.Location = new System.Drawing.Point(126, 175);
            this.rbEntrar.Name = "rbEntrar";
            this.rbEntrar.Size = new System.Drawing.Size(53, 17);
            this.rbEntrar.TabIndex = 6;
            this.rbEntrar.TabStop = true;
            this.rbEntrar.Text = "Entrar";
            this.rbEntrar.UseVisualStyleBackColor = true;
            this.rbEntrar.CheckedChanged += new System.EventHandler(this.rbEntrar_CheckedChanged);
            // 
            // cbPlacas
            // 
            this.cbPlacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlacas.FormattingEnabled = true;
            this.cbPlacas.Location = new System.Drawing.Point(59, 126);
            this.cbPlacas.Name = "cbPlacas";
            this.cbPlacas.Size = new System.Drawing.Size(261, 24);
            this.cbPlacas.TabIndex = 7;
            // 
            // WinForm04Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 288);
            this.Controls.Add(this.cbVagasLivres);
            this.Controls.Add(this.cbPlacas);
            this.Controls.Add(this.rbEntrar);
            this.Controls.Add(this.rbSair);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinForm04Exec02";
            this.ShowIcon = false;
            this.Text = "Estacionamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinForm04Exec02_FormClosed);
            this.Load += new System.EventHandler(this.WinForm04Exec02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVagasLivres;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.RadioButton rbSair;
        private System.Windows.Forms.RadioButton rbEntrar;
        private System.Windows.Forms.ComboBox cbPlacas;
    }
}