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
    public partial class HistoricoViagens : Form
    {
        private Embarque embarque;

        public HistoricoViagens(Embarque embarque)
        {
            InitializeComponent();

            this.embarque = embarque;

            listPassageiros.View = View.List;
            listVeiculosViagem.View = View.List;

            carregarVeiculosViagem();
        }

        private void listVeiculosViagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVeiculosViagem.SelectedItems.Count > 0)
            {
                var indexSelected = listVeiculosViagem.SelectedItems[0].Index;

                if (indexSelected >= 0)
                {
                    var viagem = embarque.Viagens[indexSelected];

                    carregarPassageiros(viagem.Passageiros);
                }
            }
        }

        private void carregarVeiculosViagem()
        {
            listVeiculosViagem.Items.Clear();

            foreach (var viagem in embarque.Viagens)
            {
                listVeiculosViagem.Items.Add(new ListViewItem(new string[] { $"{viagem.ToString()}" }));
            }
        }
        private void carregarPassageiros(Queue<Visitante> passageiros)
        {
            listPassageiros.Items.Clear();

            foreach (var passageiro in passageiros)
            {
                listPassageiros.Items.Add(new ListViewItem(new string[] { $"{passageiro.ToString()}" }));
            }
        }
    }
}
