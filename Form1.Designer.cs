namespace ClientSocket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMensagem = new TextBox();
            btEnviar = new Button();
            btLimpar = new Button();
            label2 = new Label();
            txtServidor = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 40);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 0;
            label1.Text = "Digite sua mensagem";
            label1.Click += label1_Click;
            // 
            // txtMensagem
            // 
            txtMensagem.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMensagem.Location = new Point(119, 94);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(624, 134);
            txtMensagem.TabIndex = 1;
            // 
            // btEnviar
            // 
            btEnviar.Location = new Point(327, 253);
            btEnviar.Name = "btEnviar";
            btEnviar.Size = new Size(75, 23);
            btEnviar.TabIndex = 2;
            btEnviar.Text = "Enviar";
            btEnviar.UseVisualStyleBackColor = true;
            btEnviar.Click += btEnviar_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(425, 253);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 3;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 290);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 4;
            label2.Text = "Servidor";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(119, 329);
            txtServidor.Multiline = true;
            txtServidor.Name = "txtServidor";
            txtServidor.ReadOnly = true;
            txtServidor.Size = new Size(624, 65);
            txtServidor.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtServidor);
            Controls.Add(label2);
            Controls.Add(btLimpar);
            Controls.Add(btEnviar);
            Controls.Add(txtMensagem);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMensagem;
        private Button btEnviar;
        private Button btLimpar;
        private Label label2;
        private TextBox txtServidor;
    }
}