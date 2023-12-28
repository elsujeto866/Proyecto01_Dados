namespace Proyecto1_ErickO_DorianM
{
    partial class FormPaginaJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaginaJuego));
            lblTitulo = new Label();
            lblCreadores = new Label();
            listView1 = new ListView();
            lblTituloMovimientos = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            listBDados = new ListBox();
            lblListaDados = new Label();
            btnLanzarDado = new Button();
            pictureBox1 = new PictureBox();
            lblNumDado = new Label();
            lblTituloNumDados = new Label();
            txtNumDados = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25F);
            lblTitulo.Location = new Point(18, 14);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(455, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Juego Lanzamiento de dados";
            lblTitulo.Click += label1_Click;
            // 
            // lblCreadores
            // 
            lblCreadores.AutoSize = true;
            lblCreadores.Location = new Point(18, 70);
            lblCreadores.Margin = new Padding(2, 0, 2, 0);
            lblCreadores.Name = "lblCreadores";
            lblCreadores.Size = new Size(234, 15);
            lblCreadores.TabIndex = 1;
            lblCreadores.Text = "Desarrollado por : Ortiz Erick y Maza Dorian";
            // 
            // listView1
            // 
            listView1.Location = new Point(8, 357);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 104);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTituloMovimientos
            // 
            lblTituloMovimientos.AutoSize = true;
            lblTituloMovimientos.Location = new Point(8, 340);
            lblTituloMovimientos.Margin = new Padding(2, 0, 2, 0);
            lblTituloMovimientos.Name = "lblTituloMovimientos";
            lblTituloMovimientos.Size = new Size(138, 15);
            lblTituloMovimientos.TabIndex = 3;
            lblTituloMovimientos.Text = "Lanzamientos Realizados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 108);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(293, 15);
            label1.TabIndex = 4;
            label1.Text = "Escribe Tu nombre(Se usara como usuario para datos):";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(335, 106);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(153, 23);
            txtUsuario.TabIndex = 5;
            // 
            // listBDados
            // 
            listBDados.FormattingEnabled = true;
            listBDados.ItemHeight = 15;
            listBDados.Location = new Point(13, 232);
            listBDados.Margin = new Padding(2);
            listBDados.Name = "listBDados";
            listBDados.Size = new Size(143, 94);
            listBDados.TabIndex = 6;
            listBDados.SelectedIndexChanged += listBDados_SelectedIndexChanged;
            // 
            // lblListaDados
            // 
            lblListaDados.AutoSize = true;
            lblListaDados.Location = new Point(8, 209);
            lblListaDados.Margin = new Padding(2, 0, 2, 0);
            lblListaDados.Name = "lblListaDados";
            lblListaDados.Size = new Size(145, 15);
            lblListaDados.TabIndex = 7;
            lblListaDados.Text = "Selecciona el tipo de dado";
            // 
            // btnLanzarDado
            // 
            btnLanzarDado.Location = new Point(318, 157);
            btnLanzarDado.Margin = new Padding(2);
            btnLanzarDado.Name = "btnLanzarDado";
            btnLanzarDado.Size = new Size(123, 28);
            btnLanzarDado.TabIndex = 8;
            btnLanzarDado.Text = "Sueltalo";
            btnLanzarDado.UseVisualStyleBackColor = true;
            btnLanzarDado.Click += btnLanzarDado_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://www.gifsanimados.org/data/media/710/dado-imagen-animada-0095.gif";
            pictureBox1.Location = new Point(335, 209);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 90);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblNumDado
            // 
            lblNumDado.AutoSize = true;
            lblNumDado.Location = new Point(456, 163);
            lblNumDado.Margin = new Padding(2, 0, 2, 0);
            lblNumDado.Name = "lblNumDado";
            lblNumDado.Size = new Size(20, 15);
            lblNumDado.TabIndex = 10;
            lblNumDado.Text = "X1";
            // 
            // lblTituloNumDados
            // 
            lblTituloNumDados.AutoSize = true;
            lblTituloNumDados.Location = new Point(8, 133);
            lblTituloNumDados.Margin = new Padding(2, 0, 2, 0);
            lblTituloNumDados.Name = "lblTituloNumDados";
            lblTituloNumDados.Size = new Size(171, 15);
            lblTituloNumDados.TabIndex = 11;
            lblTituloNumDados.Text = "Selecciona el numero de dados";
            // 
            // txtNumDados
            // 
            txtNumDados.Location = new Point(18, 160);
            txtNumDados.Margin = new Padding(2);
            txtNumDados.Name = "txtNumDados";
            txtNumDados.Size = new Size(153, 23);
            txtNumDados.TabIndex = 12;
            txtNumDados.Text = "1";
            // 
            // FormPaginaJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(516, 449);
            Controls.Add(txtNumDados);
            Controls.Add(lblTituloNumDados);
            Controls.Add(lblNumDado);
            Controls.Add(pictureBox1);
            Controls.Add(btnLanzarDado);
            Controls.Add(lblListaDados);
            Controls.Add(listBDados);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(lblTituloMovimientos);
            Controls.Add(listView1);
            Controls.Add(lblCreadores);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "FormPaginaJuego";
            Text = "Form1";
            Load += FormPaginaJuego_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCreadores;
        private ListView listView1;
        private Label lblTituloMovimientos;
        private Label label1;
        private TextBox txtUsuario;
        private ListBox listBDados;
        private Label lblListaDados;
        private Button btnLanzarDado;
        private PictureBox pictureBox1;
        private Label lblNumDado;
        private Label lblTituloNumDados;
        private TextBox txtNumDados;
    }
}
