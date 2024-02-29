namespace Poc.Crud.Views
{
    partial class FormPrincipal
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
            this.cmbxTipoMaquina = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.DataGVMaquina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirMaq = new System.Windows.Forms.Button();
            this.btnEditarMaq = new System.Windows.Forms.Button();
            this.btnNovaMaq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVMaquina)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxTipoMaquina
            // 
            this.cmbxTipoMaquina.FormattingEnabled = true;
            this.cmbxTipoMaquina.Location = new System.Drawing.Point(50, 64);
            this.cmbxTipoMaquina.Name = "cmbxTipoMaquina";
            this.cmbxTipoMaquina.Size = new System.Drawing.Size(193, 21);
            this.cmbxTipoMaquina.TabIndex = 0;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(249, 64);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(330, 64);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(411, 64);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // DataGVMaquina
            // 
            this.DataGVMaquina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVMaquina.Location = new System.Drawing.Point(50, 163);
            this.DataGVMaquina.Name = "DataGVMaquina";
            this.DataGVMaquina.Size = new System.Drawing.Size(682, 263);
            this.DataGVMaquina.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo máquina";
            // 
            // btnExcluirMaq
            // 
            this.btnExcluirMaq.Location = new System.Drawing.Point(657, 134);
            this.btnExcluirMaq.Name = "btnExcluirMaq";
            this.btnExcluirMaq.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirMaq.TabIndex = 8;
            this.btnExcluirMaq.Text = "Excluir";
            this.btnExcluirMaq.UseVisualStyleBackColor = true;
            this.btnExcluirMaq.Click += new System.EventHandler(this.btnExcluirMaq_Click);
            // 
            // btnEditarMaq
            // 
            this.btnEditarMaq.Location = new System.Drawing.Point(576, 134);
            this.btnEditarMaq.Name = "btnEditarMaq";
            this.btnEditarMaq.Size = new System.Drawing.Size(75, 23);
            this.btnEditarMaq.TabIndex = 7;
            this.btnEditarMaq.Text = "Editar";
            this.btnEditarMaq.UseVisualStyleBackColor = true;
            this.btnEditarMaq.Click += new System.EventHandler(this.btnEditarMaq_Click);
            // 
            // btnNovaMaq
            // 
            this.btnNovaMaq.Location = new System.Drawing.Point(495, 134);
            this.btnNovaMaq.Name = "btnNovaMaq";
            this.btnNovaMaq.Size = new System.Drawing.Size(75, 23);
            this.btnNovaMaq.TabIndex = 6;
            this.btnNovaMaq.Text = "Novo";
            this.btnNovaMaq.UseVisualStyleBackColor = true;
            this.btnNovaMaq.Click += new System.EventHandler(this.btnNovaMaq_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluirMaq);
            this.Controls.Add(this.btnEditarMaq);
            this.Controls.Add(this.btnNovaMaq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGVMaquina);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cmbxTipoMaquina);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.DataGVMaquina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView DataGVMaquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirMaq;
        private System.Windows.Forms.Button btnEditarMaq;
        private System.Windows.Forms.Button btnNovaMaq;
        public System.Windows.Forms.ComboBox cmbxTipoMaquina;
    }
}