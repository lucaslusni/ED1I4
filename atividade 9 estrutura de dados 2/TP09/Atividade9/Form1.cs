using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade9
{
    public partial class Form1 : Form
    {
        private Embarque embarque;
        
        private System.Timers.Timer _timer;
        private const int INTERVALO_VIAGEM_AUTOMATICA = 30 * 60 * 1000;
        public Form1()
        {
            InitializeComponent();

            embarque = new Embarque();


            listVeiculos.View = View.List;
            listVisitantes.View = View.List;

            agendarViagens();
        }

        private void agendarViagens()
        {
            _timer = new System.Timers.Timer();
            _timer.AutoReset = false;
            _timer.Interval = INTERVALO_VIAGEM_AUTOMATICA; // Intervalo em milésimos
            _timer.Elapsed += new System.Timers.ElapsedEventHandler(executarTarefa);
            _timer.Enabled = true;
        }

        private void executarTarefa(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timer.Enabled = false;
            realizarViagem();
            _timer.Enabled = true;
        }

        #region Veiculos
        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("Preencha o campo Placa");
                return;
            }

            if (string.IsNullOrEmpty(txtNomeMotorista.Text))
            {
                MessageBox.Show("Preencha o campo Nome Motorista");
                return;
            }

            if (string.IsNullOrEmpty(txtQtdLotacaoVeiculo.Text))
            {
                MessageBox.Show("Preencha o campo Qtde. Lotação veículo");
                return;
            }

            var veiculo = new Veiculo(
                txtPlaca.Text,
                txtNomeMotorista.Text,
                int.Parse(txtQtdLotacaoVeiculo.Text)
            );

            embarque.adicionarVeiculo(veiculo);
            atualizarListaVeiculos();
            limparCamposVeiculo();

            if (embarque.prontoParaViagem())
                realizarViagem();
        }

        private void atualizarListaVeiculos()
        {
            listVeiculos.Items.Clear();

            foreach (var veiculo in embarque.Veiculos)
            {
                listVeiculos.Items.Add(new ListViewItem(new string[] { veiculo.ToString() }));
            }
        }
        private void limparCamposVeiculo()
        {
            txtPlaca.Text = "";
            txtNomeMotorista.Text = "";
            txtQtdLotacaoVeiculo.Text = "";
        }

        #endregion

        #region Visitantes
        private void btnAdicionarVisitante_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInscricao.Text))
            {
                MessageBox.Show("Preencha o campo Nr. Inscrição");
                return;
            }

            if (string.IsNullOrEmpty(txtNomeVisitante.Text))
            {
                MessageBox.Show("Preencha o campo Nome Visitante");
                return;
            }

            var visitante = new Visitante(
                txtInscricao.Text,
                txtNomeVisitante.Text
            );

            embarque.checkInVisitante(visitante);
            atualizarListaVisitantes();
            limparCamposVisitante();

            if (embarque.prontoParaViagem())
                realizarViagem();
        }
        private void atualizarListaVisitantes()
        {
            listVisitantes.Items.Clear();

            foreach (var visitante in embarque.Visitantes)
            {
                listVisitantes.Items.Add(new ListViewItem(new string[] { visitante.ToString() }));
            }
        }
        private void limparCamposVisitante()
        {
            txtInscricao.Text = "";
            txtNomeVisitante.Text = "";
        }

        #endregion

        #region Viagem
        private void realizarViagem()
        {
            MessageBox.Show("Quantidade de visitantes suficiente para compor a lotação do veículo");

            embarque.realizarViagem();
            atualizarListaVeiculos();
            atualizarListaVisitantes();
        }
        #endregion

        private void btnHistoricoViagens_Click(object sender, EventArgs e)
        {
            var newForm = new HistoricoViagens(embarque);
            newForm.Show();
        }

        private void btnRemueracao_Click(object sender, EventArgs e)
        {
            if (listVeiculos.SelectedItems.Count > 0)
            {
                var indexSelected = listVeiculos.SelectedItems[0].Index;

                if (indexSelected >= 0)
                {
                    var veiculo = embarque.Veiculos.ToList().ElementAt(indexSelected);

                    var remuneracaoVeiculo = embarque.remuneracaoVeiculo(veiculo);

                    MessageBox.Show($"O veículo com a placa {veiculo.Placa} deve receber {remuneracaoVeiculo:C} por suas viagens");
                    return;
                }
            }

            MessageBox.Show("Selecione o veículo que deseja ver a remuneração");
        }
    }
}
