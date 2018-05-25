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
    public partial class TelaListaPedidos : Form
    {
        Pedido pedido = new Pedido();

        public TelaListaPedidos()
        {
            InitializeComponent();
        }

        private void TelaListaPedidos_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);        }

        private void AddPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarPedidos();
        }

        private void CarregarPedidos()
        {
            dgPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPedidos.MultiSelect = false;
            dgPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPedidos.AutoGenerateColumns = false;
            List<Pedido> pedidos = Program.Gerenciador.TodosOsPedidos();
            dgPedidos.DataSource = pedidos;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }
            else
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.OKCancel);
                if (resultado == DialogResult.OK)
                {
                    Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverPedido(pedidoSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Pedido Removido com Sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um problema ao remover o pedido");
                    }
                    CarregarPedidos();
                }
            }
        }
        private void CarregarTotal()
        {
            String tot = pedido.ValorTotal().ToString();
        }
        private void AbreTelaInclusaoAlteracao(Pedido pedidoSelecionado)
        {
            AdicionaPedido addPedido = new AdicionaPedido();
            addPedido.PedidoSelecionado = pedidoSelecionado;
            addPedido.FormClosed += AddPedido_FormClosed;
            addPedido.Show();
        }
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgPedidos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }
            else
            {
                Pedido pedidoSelecionado = (Pedido)dgPedidos.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(pedidoSelecionado);
            }
        }
    }
}
