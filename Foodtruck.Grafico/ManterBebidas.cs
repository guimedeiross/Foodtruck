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
    public partial class ManterBebidas : Form
    {
        public Bebida BebidaSelecionada { get; set; }

        public ManterBebidas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Bebida Bebida = new Bebida();
            long value = 0;
            if (Int64.TryParse(tbId.Text, out value))
            {
                Bebida.Id = value;
            }
            else
            {
                Bebida.Id = -1;
                //passa indentificador com valor negativo se não conseguir converter
            }
            Bebida.Id = Convert.ToInt64(tbId.Text);
            Bebida.Nome = tbNome.Text;
            Bebida.Valor = Convert.ToDecimal(tbValor.Text);
            Bebida.Tamanho = Convert.ToSingle(tbTamanho.Text);
            Validacao validacao;
            if (BebidaSelecionada == null)
            {
                validacao = Program.Gerenciador.CadastraBebida(Bebida);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarBebida(Bebida);
            }
            
            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach(var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Bebida salva com sucesso");
            }
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterBebidas_Shown(object sender, EventArgs e)
        {
            if(BebidaSelecionada != null)
            {
                this.tbId.Text = BebidaSelecionada.Id.ToString();
                this.tbNome.Text = BebidaSelecionada.Nome;
                this.tbTamanho.Text = BebidaSelecionada.Tamanho.ToString();
                this.tbValor.Text = BebidaSelecionada.Valor.ToString();
            }
        }
    }
}
