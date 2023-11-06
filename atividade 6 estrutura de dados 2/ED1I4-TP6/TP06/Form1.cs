using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP06
{
	public partial class Form1 : Form
	{
		private Senhas senhas;
		private Guiches guiches;
		int qtdGuiches = 0;

		public Form1()
		{
			InitializeComponent();
			this.senhas = new Senhas();
			this.guiches = new Guiches();
			this.dataGridView1.Columns.Add("senha", "Senha");
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.Columns.Add("senha", "Senha");
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Configuração visual da janela
            this.BackColor = Color.LightGray;
            this.StartPosition = FormStartPosition.CenterScreen; // Centraliza a janela

            // Configuração visual para os botões
            button1.BackColor = Color.FromArgb(46, 169, 223); // Azul claro
            button1.ForeColor = Color.White;
            button1.Font = new Font("Arial", 12, FontStyle.Bold);
            button1.FlatStyle = FlatStyle.Flat; // Estilo plano para o botão

            button2.BackColor = Color.FromArgb(46, 169, 223);
            button2.ForeColor = Color.White;
            button2.Font = new Font("Arial", 12, FontStyle.Bold);
            button2.FlatStyle = FlatStyle.Flat;

            button3.BackColor = Color.FromArgb(46, 169, 223);
            button3.ForeColor = Color.White;
            button3.Font = new Font("Arial", 12, FontStyle.Bold);
            button3.FlatStyle = FlatStyle.Flat;

            button4.BackColor = Color.FromArgb(46, 169, 223);
            button4.ForeColor = Color.White;
            button4.Font = new Font("Arial", 12, FontStyle.Bold);
            button4.FlatStyle = FlatStyle.Flat;

            button5.BackColor = Color.FromArgb(46, 169, 223);
            button5.ForeColor = Color.White;
            button5.Font = new Font("Arial", 12, FontStyle.Bold);
            button5.FlatStyle = FlatStyle.Flat;
        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.senhas.gerar();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.dataGridView1.Rows.Clear();

			foreach (Senha senha in this.senhas.FilaSenhas)
			{
				this.dataGridView1.Rows.Add(senha.dadosParciais());
			}

		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.guiches.adicionar(new Guiche(this.qtdGuiches));
			this.qtdGuiches++;
			label2.Text = qtdGuiches.ToString();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(textBox1.Text);
			Guiche guiche = this.guiches.buscar(id);
			if (guiche != null)
			{
				guiche.chamar(this.senhas.FilaSenhas);
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.dataGridView2.Rows.Clear();
			foreach (Guiche guiche in this.guiches.ListaGuiches)
			{
				foreach (Senha senha in guiche.Atendimentos)
				{
					this.dataGridView2.Rows.Add(senha.dadosCompletos());
				}
			}
		}
	}
}
