namespace projetoTecBulk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbFIFO = new System.Windows.Forms.RadioButton();
            this.rbLIFO = new System.Windows.Forms.RadioButton();
            this.rbJIT = new System.Windows.Forms.RadioButton();
            this.rbCapacidade = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDemandas = new System.Windows.Forms.DataGridView();
            this.rbPrioridades = new System.Windows.Forms.RadioButton();
            this.rbAtrasados = new System.Windows.Forms.RadioButton();
            this.tbxPrioridade = new System.Windows.Forms.TextBox();
            this.cadastrarDemandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarDemandaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verDemandasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandas)).BeginInit();
            this.SuspendLayout();
            // 
            // rbFIFO
            // 
            this.rbFIFO.AutoSize = true;
            this.rbFIFO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFIFO.Location = new System.Drawing.Point(64, 37);
            this.rbFIFO.Name = "rbFIFO";
            this.rbFIFO.Size = new System.Drawing.Size(63, 25);
            this.rbFIFO.TabIndex = 0;
            this.rbFIFO.TabStop = true;
            this.rbFIFO.Text = "FIFO";
            this.rbFIFO.UseVisualStyleBackColor = true;
            this.rbFIFO.CheckedChanged += new System.EventHandler(this.rbFIFO_CheckedChanged);
            // 
            // rbLIFO
            // 
            this.rbLIFO.AutoSize = true;
            this.rbLIFO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLIFO.Location = new System.Drawing.Point(230, 37);
            this.rbLIFO.Name = "rbLIFO";
            this.rbLIFO.Size = new System.Drawing.Size(62, 25);
            this.rbLIFO.TabIndex = 1;
            this.rbLIFO.TabStop = true;
            this.rbLIFO.Text = "LIFO";
            this.rbLIFO.UseVisualStyleBackColor = true;
            // 
            // rbJIT
            // 
            this.rbJIT.AutoSize = true;
            this.rbJIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJIT.Location = new System.Drawing.Point(395, 37);
            this.rbJIT.Name = "rbJIT";
            this.rbJIT.Size = new System.Drawing.Size(49, 25);
            this.rbJIT.TabIndex = 2;
            this.rbJIT.TabStop = true;
            this.rbJIT.Text = "JIT";
            this.rbJIT.UseVisualStyleBackColor = true;
            // 
            // rbCapacidade
            // 
            this.rbCapacidade.AutoSize = true;
            this.rbCapacidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCapacidade.Location = new System.Drawing.Point(547, 37);
            this.rbCapacidade.Name = "rbCapacidade";
            this.rbCapacidade.Size = new System.Drawing.Size(140, 25);
            this.rbCapacidade.TabIndex = 3;
            this.rbCapacidade.TabStop = true;
            this.rbCapacidade.Text = "CAPACIDADE";
            this.rbCapacidade.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.cadastrarProdutoToolStripMenuItem,
            this.cadastrarDemandaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem1,
            this.verProdutosToolStripMenuItem});
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cadastrarProdutoToolStripMenuItem.Text = "Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // dgvDemandas
            // 
            this.dgvDemandas.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDemandas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDemandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemandas.EnableHeadersVisualStyles = false;
            this.dgvDemandas.Location = new System.Drawing.Point(55, 145);
            this.dgvDemandas.MultiSelect = false;
            this.dgvDemandas.Name = "dgvDemandas";
            this.dgvDemandas.ReadOnly = true;
            this.dgvDemandas.RowHeadersVisible = false;
            this.dgvDemandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDemandas.Size = new System.Drawing.Size(847, 293);
            this.dgvDemandas.TabIndex = 115;
            // 
            // rbPrioridades
            // 
            this.rbPrioridades.AutoSize = true;
            this.rbPrioridades.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrioridades.Location = new System.Drawing.Point(790, 37);
            this.rbPrioridades.Name = "rbPrioridades";
            this.rbPrioridades.Size = new System.Drawing.Size(112, 25);
            this.rbPrioridades.TabIndex = 116;
            this.rbPrioridades.TabStop = true;
            this.rbPrioridades.Text = "Prioridades";
            this.rbPrioridades.UseVisualStyleBackColor = true;
            this.rbPrioridades.CheckedChanged += new System.EventHandler(this.rbPrioridades_CheckedChanged);
            // 
            // rbAtrasados
            // 
            this.rbAtrasados.AutoSize = true;
            this.rbAtrasados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtrasados.Location = new System.Drawing.Point(436, 96);
            this.rbAtrasados.Name = "rbAtrasados";
            this.rbAtrasados.Size = new System.Drawing.Size(108, 25);
            this.rbAtrasados.TabIndex = 117;
            this.rbAtrasados.TabStop = true;
            this.rbAtrasados.Text = "Atrasados";
            this.rbAtrasados.UseVisualStyleBackColor = true;
            this.rbAtrasados.CheckedChanged += new System.EventHandler(this.rbAtrasados_CheckedChanged);
            // 
            // tbxPrioridade
            // 
            this.tbxPrioridade.Location = new System.Drawing.Point(790, 68);
            this.tbxPrioridade.Name = "tbxPrioridade";
            this.tbxPrioridade.Size = new System.Drawing.Size(100, 20);
            this.tbxPrioridade.TabIndex = 118;
            this.tbxPrioridade.TextChanged += new System.EventHandler(this.tbxPrioridade_TextChanged);
            // 
            // cadastrarDemandaToolStripMenuItem
            // 
            this.cadastrarDemandaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarDemandaToolStripMenuItem1,
            this.verDemandasToolStripMenuItem});
            this.cadastrarDemandaToolStripMenuItem.Name = "cadastrarDemandaToolStripMenuItem";
            this.cadastrarDemandaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cadastrarDemandaToolStripMenuItem.Text = "Demanda";
            // 
            // cadastrarProdutoToolStripMenuItem1
            // 
            this.cadastrarProdutoToolStripMenuItem1.Name = "cadastrarProdutoToolStripMenuItem1";
            this.cadastrarProdutoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cadastrarProdutoToolStripMenuItem1.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem1_Click);
            // 
            // verProdutosToolStripMenuItem
            // 
            this.verProdutosToolStripMenuItem.Name = "verProdutosToolStripMenuItem";
            this.verProdutosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verProdutosToolStripMenuItem.Text = "Ver Produtos";
            this.verProdutosToolStripMenuItem.Click += new System.EventHandler(this.verProdutosToolStripMenuItem_Click);
            // 
            // cadastrarDemandaToolStripMenuItem1
            // 
            this.cadastrarDemandaToolStripMenuItem1.Name = "cadastrarDemandaToolStripMenuItem1";
            this.cadastrarDemandaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cadastrarDemandaToolStripMenuItem1.Text = "Cadastrar Demanda";
            // 
            // verDemandasToolStripMenuItem
            // 
            this.verDemandasToolStripMenuItem.Name = "verDemandasToolStripMenuItem";
            this.verDemandasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verDemandasToolStripMenuItem.Text = "Ver Demandas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.tbxPrioridade);
            this.Controls.Add(this.rbAtrasados);
            this.Controls.Add(this.rbPrioridades);
            this.Controls.Add(this.dgvDemandas);
            this.Controls.Add(this.rbCapacidade);
            this.Controls.Add(this.rbJIT);
            this.Controls.Add(this.rbLIFO);
            this.Controls.Add(this.rbFIFO);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TecBulk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFIFO;
        private System.Windows.Forms.RadioButton rbLIFO;
        private System.Windows.Forms.RadioButton rbJIT;
        private System.Windows.Forms.RadioButton rbCapacidade;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDemandas;
        private System.Windows.Forms.RadioButton rbPrioridades;
        private System.Windows.Forms.RadioButton rbAtrasados;
        private System.Windows.Forms.TextBox tbxPrioridade;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDemandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDemandaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verDemandasToolStripMenuItem;
    }
}

