using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTecBulk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbxPrioridade.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxPrioridade.Enabled = false;
            string sql = "SELECT demanda as 'Demanda', data_inicio as 'Data Início', data_entrega as 'Data Entrega', " +
                "producao_planejada as 'Produção planejada', producao_acumulada as 'Produção Acumulada', " +
                "quant_produzida as 'Quantidade Produzida', maquina as 'Máquina', prioridade as 'Prioridade' from demandas";

            dgvDemandas.DataSource = Banco.consulta(sql);
            dgvDemandas.Columns[0].Width = 100;
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rbAtrasados_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFIFO_CheckedChanged(object sender, EventArgs e)
        {
            this.Form1_Load(sender, e);
        }

        private void rbPrioridades_CheckedChanged(object sender, EventArgs e)
        {
            tbxPrioridade.Enabled = true;
            string sql;
            try
            {
                if (tbxPrioridade.Text == "")
                {
                    sql = "SELECT demanda as 'Demanda', data_inicio as 'Data Início', data_entrega as 'Data Entrega', " +
                    "producao_planejada as 'Produção planejada', producao_acumulada as 'Produção Acumulada', " +
                    "quant_produzida as 'Quantidade Produzida', maquina as 'Máquina', prioridade as 'Prioridade' from demandas ORDER BY CAST(prioridade as INTEGER) DESC";
                    dgvDemandas.DataSource = Banco.consulta(sql);
                }
                else
                {
                    sql = "SELECT demanda as 'Demanda', data_inicio as 'Data Início', data_entrega as 'Data Entrega', " +
                    "producao_planejada as 'Produção planejada', producao_acumulada as 'Produção Acumulada', " +
                    $"quant_produzida as 'Quantidade Produzida', maquina as 'Máquina', prioridade as 'Prioridade' from demandas WHERE CAST(prioridade AS INTEGER) >= {tbxPrioridade.Text} ORDER BY CAST(prioridade as INTEGER) DESC";
                    dgvDemandas.DataSource = Banco.consulta(sql);
                }
            }
            catch
            {
                sql = "SELECT demanda as 'Demanda', data_inicio as 'Data Início', data_entrega as 'Data Entrega', " +
                    "producao_planejada as 'Produção planejada', producao_acumulada as 'Produção Acumulada', " +
                    "quant_produzida as 'Quantidade Produzida', maquina as 'Máquina', prioridade as 'Prioridade' from demandas ORDER BY CAST(prioridade as INTEGER) DESC";
                dgvDemandas.DataSource = Banco.consulta(sql);
            }


            dgvDemandas.Columns[0].Width = 100;
        }

        private void tbxPrioridade_TextChanged(object sender, EventArgs e)
        {
            this.rbPrioridades_CheckedChanged(sender, e);
        }

        private void verProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastrarProduto cd = new cadastrarProduto();
            cd.ShowDialog();
        }
    }
}
