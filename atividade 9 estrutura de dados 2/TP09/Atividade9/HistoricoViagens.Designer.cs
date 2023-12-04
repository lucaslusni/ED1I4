namespace Atividade9
{
    partial class HistoricoViagens
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
            this.label2 = new System.Windows.Forms.Label();
            this.listPassageiros = new System.Windows.Forms.ListView();
            this.lblViagem = new System.Windows.Forms.Label();
            this.listVeiculosViagem = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Passageiros";
            // 
            // listPassageiros
            // 
            this.listPassageiros.Enabled = false;
            this.listPassageiros.HideSelection = false;
            this.listPassageiros.Location = new System.Drawing.Point(257, 46);
            this.listPassageiros.Name = "listPassageiros";
            this.listPassageiros.Size = new System.Drawing.Size(423, 392);
            this.listPassageiros.TabIndex = 20;
            this.listPassageiros.UseCompatibleStateImageBehavior = false;
            // 
            // lblViagem
            // 
            this.lblViagem.AutoSize = true;
            this.lblViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViagem.Location = new System.Drawing.Point(12, 28);
            this.lblViagem.Name = "lblViagem";
            this.lblViagem.Size = new System.Drawing.Size(52, 15);
            this.lblViagem.TabIndex = 19;
            this.lblViagem.Text = "Viagem:";
            // 
            // listVeiculosViagem
            // 
            this.listVeiculosViagem.HideSelection = false;
            this.listVeiculosViagem.Location = new System.Drawing.Point(15, 46);
            this.listVeiculosViagem.Name = "listVeiculosViagem";
            this.listVeiculosViagem.Size = new System.Drawing.Size(221, 392);
            this.listVeiculosViagem.TabIndex = 18;
            this.listVeiculosViagem.UseCompatibleStateImageBehavior = false;
            this.listVeiculosViagem.SelectedIndexChanged += new System.EventHandler(this.listVeiculosViagem_SelectedIndexChanged);
            // 
            // HistoricoViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPassageiros);
            this.Controls.Add(this.lblViagem);
            this.Controls.Add(this.listVeiculosViagem);
            this.Name = "HistoricoViagens";
            this.Text = "HistoricoViagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listPassageiros;
        private System.Windows.Forms.Label lblViagem;
        private System.Windows.Forms.ListView listVeiculosViagem;
    }
}