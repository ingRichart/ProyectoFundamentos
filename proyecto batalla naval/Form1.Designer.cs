namespace proyecto_batalla_naval
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
            groupBox1 = new GroupBox();
            btniniciar = new Button();
            lblnombre1jugador = new Label();
            txtunjugador = new TextBox();
            rbunjugador = new RadioButton();
            lbltitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.Zoom;
            groupBox1.Controls.Add(btniniciar);
            groupBox1.Controls.Add(lblnombre1jugador);
            groupBox1.Controls.Add(txtunjugador);
            groupBox1.Controls.Add(rbunjugador);
            groupBox1.Controls.Add(lbltitulo);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(61, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btniniciar
            // 
            btniniciar.Location = new Point(175, 295);
            btniniciar.Name = "btniniciar";
            btniniciar.Size = new Size(181, 34);
            btniniciar.TabIndex = 7;
            btniniciar.Text = "Iniciar juego";
            btniniciar.UseVisualStyleBackColor = true;
            // 
            // lblnombre1jugador
            // 
            lblnombre1jugador.AutoSize = true;
            lblnombre1jugador.Location = new Point(79, 183);
            lblnombre1jugador.Name = "lblnombre1jugador";
            lblnombre1jugador.Size = new Size(78, 25);
            lblnombre1jugador.TabIndex = 5;
            lblnombre1jugador.Text = "Nombre";
            // 
            // txtunjugador
            // 
            txtunjugador.Location = new Point(71, 218);
            txtunjugador.Name = "txtunjugador";
            txtunjugador.Size = new Size(150, 31);
            txtunjugador.TabIndex = 3;
            // 
            // rbunjugador
            // 
            rbunjugador.AutoSize = true;
            rbunjugador.Location = new Point(71, 130);
            rbunjugador.Name = "rbunjugador";
            rbunjugador.Size = new Size(126, 29);
            rbunjugador.TabIndex = 1;
            rbunjugador.TabStop = true;
            rbunjugador.Text = "Un jugador";
            rbunjugador.UseVisualStyleBackColor = true;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.IndianRed;
            lbltitulo.Location = new Point(257, 27);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(141, 25);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "BATALLA NAVAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.portadabn;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtunjugador;
        private RadioButton rbunjugador;
        private Label lbltitulo;
        private Button btniniciar;
        private Label lblnombre1jugador;
    }
}
