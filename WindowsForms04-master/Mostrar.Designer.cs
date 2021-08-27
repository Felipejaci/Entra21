
namespace WindowsForms04
{
    partial class Mostrar
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
            this.lstMostra = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstMostra
            // 
            this.lstMostra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMostra.FormattingEnabled = true;
            this.lstMostra.ItemHeight = 16;
            this.lstMostra.Location = new System.Drawing.Point(0, 1);
            this.lstMostra.Name = "lstMostra";
            this.lstMostra.Size = new System.Drawing.Size(281, 436);
            this.lstMostra.TabIndex = 0;
            this.lstMostra.SelectedIndexChanged += new System.EventHandler(this.lstMostra_SelectedIndexChanged);
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 450);
            this.Controls.Add(this.lstMostra);
            this.Name = "Mostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Mostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMostra;
    }
}