﻿namespace Foodtruck.Grafico
{
    partial class TelaListaBebidas
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
            this.btAlterar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(191, 11);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(72, 34);
            this.btAlterar.TabIndex = 5;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(104, 11);
            this.btRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(84, 34);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(20, 11);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(80, 34);
            this.btAdicionar.TabIndex = 3;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // dgBebidas
            // 
            this.dgBebidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Valor,
            this.Tamanho});
            this.dgBebidas.Location = new System.Drawing.Point(5, 50);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.Size = new System.Drawing.Size(553, 332);
            this.dgBebidas.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Tamanho
            // 
            this.Tamanho.DataPropertyName = "Tamanho";
            this.Tamanho.HeaderText = "Tamanho(ml)";
            this.Tamanho.Name = "Tamanho";
            // 
            // TelaListaBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 383);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Name = "TelaListaBebidas";
            this.Text = "TelaListaBebidas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaListaBebidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamanho;
    }
}