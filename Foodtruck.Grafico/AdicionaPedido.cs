using Foodtruck.Negocio;
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
    public partial class AdicionaPedido : Form
    {
        Pedido pedido = new Pedido();
        public Pedido PedidoSelecionado { get; set; }

        public AdicionaPedido()
        {
            InitializeComponent();
        }

        private void AdicionaPedido_Load(object sender, EventArgs e)
        {
            CarregaComboBoxes();
            CarregaDatagrids();
            CarregaTotal();
        }

        private void CarregaTotal()
        {
            if(PedidoSelecionado != null)
            {
                lbTotal.Text = PedidoSelecionado.ValorTotal().ToString();
            }
            else
            {
                lbTotal.Text = pedido.ValorTotal().ToString();
            }
            
        }

        private void CarregaComboBoxes()
        {
            cbClientes.DisplayMember = "Descricao";
            cbClientes.ValueMember = "Id";
            cbClientes.DataSource = Program.Gerenciador.TodosOsClientes();

            cbLanches.DisplayMember = "Nome";
            cbLanches.ValueMember = "Id";
            cbLanches.DataSource = Program.Gerenciador.TodosOsLanches();

            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
            cbBebidas.DataSource = Program.Gerenciador.TodasAsBebidas();
        }

        private void CarregaDatagrids()
        {
            if(PedidoSelecionado != null)
            {
                dgBebidas.AutoGenerateColumns = false;
                dgBebidas.DataSource = PedidoSelecionado.Bebidas.ToList();

                dgLanches.AutoGenerateColumns = false;
                dgLanches.DataSource = PedidoSelecionado.Lanches.ToList();
            }
            else
            {
                dgBebidas.AutoGenerateColumns = false;
                dgBebidas.DataSource = pedido.Bebidas.ToList();

                dgLanches.AutoGenerateColumns = false;
                dgLanches.DataSource = pedido.Lanches.ToList();
            }


            CarregaTotal();
        }

        private void btAdicionaBebida_Click(object sender, EventArgs e)
        {
            if(PedidoSelecionado != null)
            {
                Bebida bebidaSelecionadas = (Bebida)cbBebidas.SelectedItem;
                PedidoSelecionado.Bebidas.Add(bebidaSelecionadas);
            }
            else
            {
                Bebida bebidaSelecionada = (Bebida)cbBebidas.SelectedItem;
                pedido.Bebidas.Add(bebidaSelecionada);
            }
            CarregaDatagrids();
        }

        private void btAdicionaLanche_Click(object sender, EventArgs e)
        {
            if(PedidoSelecionado != null)
            {
                Lanche lancheSelecionados = cbLanches.SelectedItem as Lanche;
                PedidoSelecionado.Lanches.Add(lancheSelecionados);
            }
            else
            {
                Lanche lancheSelecionado = cbLanches.SelectedItem as Lanche;
                pedido.Lanches.Add(lancheSelecionado);
            }
            
            CarregaDatagrids();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pedido.Cliente = cbClientes.SelectedItem as Cliente;
                pedido.DataCompra = DateTime.Now;
                Validacao validacao;
                if (PedidoSelecionado != null)
                {
                     validacao = Program.Gerenciador.AlterarPedido(PedidoSelecionado);
                }
                else
                {
                    validacao = Program.Gerenciador.CadastraPedido(pedido);
                }
                
                if (validacao.Valido)
                {
                    MessageBox.Show("Pedido cadastrado com sucesso!");
                    this.Close();
                }
                else
                {
                    String msg = "";
                    foreach (var mensagem in validacao.Mensagens)
                    {
                        msg += mensagem + Environment.NewLine;
                    }
                    MessageBox.Show(msg, "Erro");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro grave, fale com o administrador");
            }
            
        }

        private void AdicionaPedido_Shown(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
