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
            lblTitulo.Location = new Point(26, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(669, 67);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Juego Lanzamiento de dados";
            lblTitulo.Click += label1_Click;
            // 
            // lblCreadores
            // 
            lblCreadores.AutoSize = true;
            lblCreadores.Location = new Point(26, 116);
            lblCreadores.Name = "lblCreadores";
            lblCreadores.Size = new Size(358, 25);
            lblCreadores.TabIndex = 1;
            lblCreadores.Text = "Desarrollado por : Ortiz Erick y Masa Dorian";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 595);
            listView1.Name = "listView1";
            listView1.Size = new Size(713, 171);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblTituloMovimientos
            // 
            lblTituloMovimientos.AutoSize = true;
            lblTituloMovimientos.Location = new Point(12, 567);
            lblTituloMovimientos.Name = "lblTituloMovimientos";
            lblTituloMovimientos.Size = new Size(208, 25);
            lblTituloMovimientos.TabIndex = 3;
            lblTituloMovimientos.Text = "Lanzamientos Realizados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 180);
            label1.Name = "label1";
            label1.Size = new Size(443, 25);
            label1.TabIndex = 4;
            label1.Text = "Escribe Tu nombre(Se usara como usuario para datos):";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(478, 177);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(217, 31);
            txtUsuario.TabIndex = 5;
            // 
            // listBDados
            // 
            listBDados.FormattingEnabled = true;
            listBDados.ItemHeight = 25;
            listBDados.Location = new Point(18, 387);
            listBDados.Name = "listBDados";
            listBDados.Size = new Size(202, 154);
            listBDados.TabIndex = 6;
            listBDados.SelectedIndexChanged += listBDados_SelectedIndexChanged;
            // 
            // lblListaDados
            // 
            lblListaDados.AutoSize = true;
            lblListaDados.Location = new Point(12, 348);
            lblListaDados.Name = "lblListaDados";
            lblListaDados.Size = new Size(221, 25);
            lblListaDados.TabIndex = 7;
            lblListaDados.Text = "Selecciona el tipo de dado";
            // 
            // btnLanzarDado
            // 
            btnLanzarDado.Location = new Point(454, 261);
            btnLanzarDado.Name = "btnLanzarDado";
            btnLanzarDado.Size = new Size(176, 47);
            btnLanzarDado.TabIndex = 8;
            btnLanzarDado.Text = "Sueltalo";
            btnLanzarDado.UseVisualStyleBackColor = true;
            btnLanzarDado.Click += btnLanzarDado_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "https://www.gifsanimados.org/data/media/710/dado-imagen-animada-0095.gif";
            pictureBox1.Location = new Point(478, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 150);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblNumDado
            // 
            lblNumDado.AutoSize = true;
            lblNumDado.Location = new Point(652, 272);
            lblNumDado.Name = "lblNumDado";
            lblNumDado.Size = new Size(33, 25);
            lblNumDado.TabIndex = 10;
            lblNumDado.Text = "X1";
            // 
            // lblTituloNumDados
            // 
            lblTituloNumDados.AutoSize = true;
            lblTituloNumDados.Location = new Point(12, 222);
            lblTituloNumDados.Name = "lblTituloNumDados";
            lblTituloNumDados.Size = new Size(259, 25);
            lblTituloNumDados.TabIndex = 11;
            lblTituloNumDados.Text = "Selecciona el numero de dados";
            // 
            // txtNumDados
            // 
            txtNumDados.Location = new Point(26, 266);
            txtNumDados.Name = "txtNumDados";
            txtNumDados.Size = new Size(217, 31);
            txtNumDados.TabIndex = 12;
            txtNumDados.Text = "1";
            // 
            // FormPaginaJuego
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(737, 778);
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
            Name = "FormPaginaJuego";
            Text = "Form1";
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
