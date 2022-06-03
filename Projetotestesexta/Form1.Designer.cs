namespace Projetotestesexta
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
            this.salvar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.tbmodelocarro = new System.Windows.Forms.TextBox();
            this.labelModeloCarro = new System.Windows.Forms.Label();
            this.labelfabricante = new System.Windows.Forms.Label();
            this.tbFabricante = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblopcionais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(493, 293);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(118, 41);
            this.salvar.TabIndex = 0;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(617, 294);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(118, 40);
            this.limpar.TabIndex = 1;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            // 
            // tbmodelocarro
            // 
            this.tbmodelocarro.Location = new System.Drawing.Point(148, 21);
            this.tbmodelocarro.Name = "tbmodelocarro";
            this.tbmodelocarro.Size = new System.Drawing.Size(234, 20);
            this.tbmodelocarro.TabIndex = 2;
            // 
            // labelModeloCarro
            // 
            this.labelModeloCarro.AutoSize = true;
            this.labelModeloCarro.Location = new System.Drawing.Point(57, 24);
            this.labelModeloCarro.Name = "labelModeloCarro";
            this.labelModeloCarro.Size = new System.Drawing.Size(85, 13);
            this.labelModeloCarro.TabIndex = 3;
            this.labelModeloCarro.Text = "Modelo do Carro";
            // 
            // labelfabricante
            // 
            this.labelfabricante.AutoSize = true;
            this.labelfabricante.Location = new System.Drawing.Point(42, 59);
            this.labelfabricante.Name = "labelfabricante";
            this.labelfabricante.Size = new System.Drawing.Size(100, 13);
            this.labelfabricante.TabIndex = 4;
            this.labelfabricante.Text = "Fabricante do Carro";
            // 
            // tbFabricante
            // 
            this.tbFabricante.Location = new System.Drawing.Point(148, 56);
            this.tbFabricante.Name = "tbFabricante";
            this.tbFabricante.Size = new System.Drawing.Size(234, 20);
            this.tbFabricante.TabIndex = 5;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(148, 96);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 6;
            // 
            // lblopcionais
            // 
            this.lblopcionais.AutoSize = true;
            this.lblopcionais.Location = new System.Drawing.Point(88, 141);
            this.lblopcionais.Name = "lblopcionais";
            this.lblopcionais.Size = new System.Drawing.Size(54, 13);
            this.lblopcionais.TabIndex = 7;
            this.lblopcionais.Text = "Opcionais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblopcionais);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tbFabricante);
            this.Controls.Add(this.labelfabricante);
            this.Controls.Add(this.labelModeloCarro);
            this.Controls.Add(this.tbmodelocarro);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.salvar);
            this.Name = "Form1";
            this.Text = "Sistema de Estacionamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.TextBox tbmodelocarro;
        private System.Windows.Forms.Label labelModeloCarro;
        private System.Windows.Forms.Label labelfabricante;
        private System.Windows.Forms.TextBox tbFabricante;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblopcionais;
    }
}

