using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaListaLanche : Form
    {
        public TelaListaLanche()
        {
            InitializeComponent();
        }

        private void AbreTelaInclusaoAlteracaoLanche(Lanche lancheSelecionado)
        {
            ManterLanche telaLanche = new ManterLanche();
            telaLanche.MdiParent = this.MdiParent;
            telaLanche.LancheSelecionado = lancheSelecionado;
            telaLanche.FormClosed += TelaLanche_FormClosed;
            telaLanche.Show();
        }

        private void TelaLanche_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarLanches();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracaoLanche(null);
        }


        private void CarregarLanches()
        {
            dgLanches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgLanches.MultiSelect = false;
            dgLanches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgLanches.AutoGenerateColumns = false;
            List<Lanche> lanches = Program.Gerenciador.TodosOsLanches();
            dgLanches.DataSource = lanches;
        }

        private void TelaListaLanche_Load(object sender, EventArgs e)
        {
            CarregarLanches();
        }

        private void btRemover_Click_1(object sender, EventArgs e)
        {
            if (dgLanches.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverLanche(lancheSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Lanche removido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o lanche");
                    }
                    CarregarLanches();
                }
            }
        }

        private void btAlterar_Click_1(object sender, EventArgs e)
        {
            if (dgLanches.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }
            else
            {
                Lanche lancheSelecionado = (Lanche)dgLanches.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracaoLanche(lancheSelecionado);
            }
        }

        private void dgLanches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
