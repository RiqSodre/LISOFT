namespace PrjManut
{
    partial class frmTeste
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
            this.txtRAC = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtRAP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RA";
            // 
            // txtRAC
            // 
            this.txtRAC.Location = new System.Drawing.Point(67, 20);
            this.txtRAC.Name = "txtRAC";
            this.txtRAC.Size = new System.Drawing.Size(100, 20);
            this.txtRAC.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(67, 55);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(67, 187);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "cadastrar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtRAP
            // 
            this.txtRAP.Location = new System.Drawing.Point(67, 152);
            this.txtRAP.Name = "txtRAP";
            this.txtRAP.Size = new System.Drawing.Size(100, 20);
            this.txtRAP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RA";
            // 
            // frmTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 317);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtRAP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtRAC);
            this.Controls.Add(this.label1);
            this.Name = "frmTeste";
            this.Text = "frmTeste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRAC;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtRAP;
        private System.Windows.Forms.Label label2;
    }
}