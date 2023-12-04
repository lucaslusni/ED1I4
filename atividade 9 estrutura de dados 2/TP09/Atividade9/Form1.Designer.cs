namespace Atividade9
{
    partial class Form1
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
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblNomeMotorista = new System.Windows.Forms.Label();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.lblQtdLotacao = new System.Windows.Forms.Label();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.listVeiculos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdLotacaoVeiculo = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionarVisitante = new System.Windows.Forms.Button();
            this.lblNomeVisitante = new System.Windows.Forms.Label();
            this.txtNomeVisitante = new System.Windows.Forms.TextBox();
            this.lblNrInscricao = new System.Windows.Forms.Label();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listVisitantes = new System.Windows.Forms.ListView();
            this.btnHistoricoViagens = new System.Windows.Forms.Button();
            this.btnRemueracao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdLotacaoVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.Location = new System.Drawing.Point(138, 28);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(112, 21);
            this.txtPlaca.TabIndex = 0;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(27, 31);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(93, 16);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa Veículo:";
            // 
            // lblNomeMotorista
            // 
            this.lblNomeMotorista.AutoSize = true;
            this.lblNomeMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMotorista.Location = new System.Drawing.Point(27, 67);
            this.lblNomeMotorista.Name = "lblNomeMotorista";
            this.lblNomeMotorista.Size = new System.Drawing.Size(105, 16);
            this.lblNomeMotorista.TabIndex = 3;
            this.lblNomeMotorista.Text = "Nome Motorista:";
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMotorista.Location = new System.Drawing.Point(138, 64);
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(112, 21);
            this.txtNomeMotorista.TabIndex = 2;
            // 
            // lblQtdLotacao
            // 
            this.lblQtdLotacao.AutoSize = true;
            this.lblQtdLotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdLotacao.Location = new System.Drawing.Point(27, 99);
            this.lblQtdLotacao.Name = "lblQtdLotacao";
            this.lblQtdLotacao.Size = new System.Drawing.Size(140, 16);
            this.lblQtdLotacao.TabIndex = 5;
            this.lblQtdLotacao.Text = "Qtde. Lotação veículo:";
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(144, 132);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(107, 23);
            this.btnCadastrarVeiculo.TabIndex = 6;
            this.btnCadastrarVeiculo.Text = "Adicionar Veículo";
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.btnCadastrarVeiculo_Click);
            // 
            // listVeiculos
            // 
            this.listVeiculos.HideSelection = false;
            this.listVeiculos.Location = new System.Drawing.Point(30, 202);
            this.listVeiculos.Name = "listVeiculos";
            this.listVeiculos.Size = new System.Drawing.Size(221, 252);
            this.listVeiculos.TabIndex = 7;
            this.listVeiculos.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Veículos no terminal:";
            // 
            // txtQtdLotacaoVeiculo
            // 
            this.txtQtdLotacaoVeiculo.Location = new System.Drawing.Point(173, 99);
            this.txtQtdLotacaoVeiculo.Name = "txtQtdLotacaoVeiculo";
            this.txtQtdLotacaoVeiculo.Size = new System.Drawing.Size(78, 20);
            this.txtQtdLotacaoVeiculo.TabIndex = 9;
            // 
            // btnAdicionarVisitante
            // 
            this.btnAdicionarVisitante.Location = new System.Drawing.Point(919, 31);
            this.btnAdicionarVisitante.Name = "btnAdicionarVisitante";
            this.btnAdicionarVisitante.Size = new System.Drawing.Size(107, 23);
            this.btnAdicionarVisitante.TabIndex = 15;
            this.btnAdicionarVisitante.Text = "Fazer check-in";
            this.btnAdicionarVisitante.UseVisualStyleBackColor = true;
            this.btnAdicionarVisitante.Click += new System.EventHandler(this.btnAdicionarVisitante_Click);
            // 
            // lblNomeVisitante
            // 
            this.lblNomeVisitante.AutoSize = true;
            this.lblNomeVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVisitante.Location = new System.Drawing.Point(518, 34);
            this.lblNomeVisitante.Name = "lblNomeVisitante";
            this.lblNomeVisitante.Size = new System.Drawing.Size(101, 16);
            this.lblNomeVisitante.TabIndex = 13;
            this.lblNomeVisitante.Text = "Nome Visitante:";
            // 
            // txtNomeVisitante
            // 
            this.txtNomeVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVisitante.Location = new System.Drawing.Point(636, 31);
            this.txtNomeVisitante.Name = "txtNomeVisitante";
            this.txtNomeVisitante.Size = new System.Drawing.Size(267, 21);
            this.txtNomeVisitante.TabIndex = 12;
            // 
            // lblNrInscricao
            // 
            this.lblNrInscricao.AutoSize = true;
            this.lblNrInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrInscricao.Location = new System.Drawing.Point(293, 36);
            this.lblNrInscricao.Name = "lblNrInscricao";
            this.lblNrInscricao.Size = new System.Drawing.Size(84, 16);
            this.lblNrInscricao.TabIndex = 11;
            this.lblNrInscricao.Text = "Nr. Inscrição:";
            // 
            // txtInscricao
            // 
            this.txtInscricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscricao.Location = new System.Drawing.Point(383, 33);
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(112, 21);
            this.txtInscricao.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fila de embarque";
            // 
            // listVisitantes
            // 
            this.listVisitantes.HideSelection = false;
            this.listVisitantes.Location = new System.Drawing.Point(296, 115);
            this.listVisitantes.Name = "listVisitantes";
            this.listVisitantes.Size = new System.Drawing.Size(730, 339);
            this.listVisitantes.TabIndex = 16;
            this.listVisitantes.UseCompatibleStateImageBehavior = false;
            // 
            // btnHistoricoViagens
            // 
            this.btnHistoricoViagens.Location = new System.Drawing.Point(855, 467);
            this.btnHistoricoViagens.Name = "btnHistoricoViagens";
            this.btnHistoricoViagens.Size = new System.Drawing.Size(171, 23);
            this.btnHistoricoViagens.TabIndex = 18;
            this.btnHistoricoViagens.Text = "Ver historico de viagens";
            this.btnHistoricoViagens.UseVisualStyleBackColor = true;
            this.btnHistoricoViagens.Click += new System.EventHandler(this.btnHistoricoViagens_Click);
            // 
            // btnRemueracao
            // 
            this.btnRemueracao.Location = new System.Drawing.Point(80, 460);
            this.btnRemueracao.Name = "btnRemueracao";
            this.btnRemueracao.Size = new System.Drawing.Size(171, 23);
            this.btnRemueracao.TabIndex = 19;
            this.btnRemueracao.Text = "Ver remuneração veículo";
            this.btnRemueracao.UseVisualStyleBackColor = true;
            this.btnRemueracao.Click += new System.EventHandler(this.btnRemueracao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 502);
            this.Controls.Add(this.btnRemueracao);
            this.Controls.Add(this.btnHistoricoViagens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listVisitantes);
            this.Controls.Add(this.btnAdicionarVisitante);
            this.Controls.Add(this.lblNomeVisitante);
            this.Controls.Add(this.txtNomeVisitante);
            this.Controls.Add(this.lblNrInscricao);
            this.Controls.Add(this.txtInscricao);
            this.Controls.Add(this.txtQtdLotacaoVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listVeiculos);
            this.Controls.Add(this.btnCadastrarVeiculo);
            this.Controls.Add(this.lblQtdLotacao);
            this.Controls.Add(this.lblNomeMotorista);
            this.Controls.Add(this.txtNomeMotorista);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdLotacaoVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblNomeMotorista;
        private System.Windows.Forms.Label lblQtdLotacao;
        private System.Windows.Forms.Button btnCadastrarVeiculo;
        private System.Windows.Forms.TextBox txtNomeMotorista;
        private System.Windows.Forms.ListView listVeiculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtQtdLotacaoVeiculo;
        private System.Windows.Forms.Button btnAdicionarVisitante;
        private System.Windows.Forms.Label lblNomeVisitante;
        private System.Windows.Forms.TextBox txtNomeVisitante;
        private System.Windows.Forms.Label lblNrInscricao;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listVisitantes;
        private System.Windows.Forms.Button btnHistoricoViagens;
        private System.Windows.Forms.Button btnRemueracao;
    }
}

