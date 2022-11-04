namespace ExercicioCadastroJogador
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeDoJogador = new System.Windows.Forms.TextBox();
            this.button_enviar = new System.Windows.Forms.Button();
            this.textBox_listaJogadores = new System.Windows.Forms.TextBox();
            this.textBox_listaEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do jogador";
            // 
            // textBox_nomeDoJogador
            // 
            this.textBox_nomeDoJogador.Location = new System.Drawing.Point(119, 6);
            this.textBox_nomeDoJogador.Name = "textBox_nomeDoJogador";
            this.textBox_nomeDoJogador.Size = new System.Drawing.Size(388, 23);
            this.textBox_nomeDoJogador.TabIndex = 1;
            // 
            // button_enviar
            // 
            this.button_enviar.Location = new System.Drawing.Point(537, 6);
            this.button_enviar.Name = "button_enviar";
            this.button_enviar.Size = new System.Drawing.Size(75, 23);
            this.button_enviar.TabIndex = 2;
            this.button_enviar.Text = "Enviar";
            this.button_enviar.UseVisualStyleBackColor = true;
            this.button_enviar.Click += new System.EventHandler(this.button_enviar_Click);
            // 
            // textBox_listaJogadores
            // 
            this.textBox_listaJogadores.Location = new System.Drawing.Point(12, 35);
            this.textBox_listaJogadores.Multiline = true;
            this.textBox_listaJogadores.Name = "textBox_listaJogadores";
            this.textBox_listaJogadores.ReadOnly = true;
            this.textBox_listaJogadores.Size = new System.Drawing.Size(388, 403);
            this.textBox_listaJogadores.TabIndex = 3;
            // 
            // textBox_listaEmail
            // 
            this.textBox_listaEmail.Location = new System.Drawing.Point(420, 35);
            this.textBox_listaEmail.Multiline = true;
            this.textBox_listaEmail.Name = "textBox_listaEmail";
            this.textBox_listaEmail.ReadOnly = true;
            this.textBox_listaEmail.Size = new System.Drawing.Size(359, 403);
            this.textBox_listaEmail.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_listaEmail);
            this.Controls.Add(this.textBox_listaJogadores);
            this.Controls.Add(this.button_enviar);
            this.Controls.Add(this.textBox_nomeDoJogador);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_nomeDoJogador;
        private Button button_enviar;
        private TextBox textBox_listaJogadores;
        private TextBox textBox_listaEmail;
    }
}