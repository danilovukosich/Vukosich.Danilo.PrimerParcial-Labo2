using ParcialLabo1.Clases;
using System.Collections.Generic;

namespace ParcialLabo1
{
    partial class FormInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            panel1 = new Panel();
            panelLogo = new Panel();
            label3 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxContrasenia = new TextBox();
            buttonLogIn = new Button();
            label1 = new Label();
            buttonCerrar = new PictureBox();
            buttonMinimizar = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            comboBoxInicioSesionRapido = new ComboBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 567);
            panel1.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Controls.Add(label3);
            panelLogo.Controls.Add(label2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 267);
            panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(99, 231);
            label3.Name = "label3";
            label3.Size = new Size(126, 38);
            label3.TabIndex = 1;
            label3.Text = "Express";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 195);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 0;
            label2.Text = "Aerolineas";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.Silver;
            textBoxUsuario.BorderStyle = BorderStyle.None;
            textBoxUsuario.Font = new Font("Microsoft JhengHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsuario.ForeColor = SystemColors.GrayText;
            textBoxUsuario.Location = new Point(388, 270);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(299, 26);
            textBoxUsuario.TabIndex = 1;
            textBoxUsuario.Text = "Usuario";
            textBoxUsuario.Enter += textBoxUsuario_Enter;
            textBoxUsuario.Leave += textBoxUsuario_Leave;
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.BackColor = Color.Silver;
            textBoxContrasenia.BorderStyle = BorderStyle.None;
            textBoxContrasenia.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContrasenia.ForeColor = SystemColors.GrayText;
            textBoxContrasenia.Location = new Point(388, 337);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.Size = new Size(299, 27);
            textBoxContrasenia.TabIndex = 2;
            textBoxContrasenia.Text = "Contraseña";
            textBoxContrasenia.Enter += textBoxContrasenia_Enter;
            textBoxContrasenia.Leave += textBoxContrasenia_Leave;
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.Silver;
            buttonLogIn.Cursor = Cursors.Hand;
            buttonLogIn.FlatAppearance.BorderSize = 0;
            buttonLogIn.FlatStyle = FlatStyle.Flat;
            buttonLogIn.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogIn.Location = new Point(479, 439);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(116, 50);
            buttonLogIn.TabIndex = 3;
            buttonLogIn.Text = "ACCEDER";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(439, 210);
            label1.Name = "label1";
            label1.Size = new Size(196, 39);
            label1.TabIndex = 4;
            label1.Text = "Inicio Sesión";
            label1.Click += label1_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.BackColor = Color.Transparent;
            buttonCerrar.Image = (Image)resources.GetObject("buttonCerrar.Image");
            buttonCerrar.Location = new Point(749, 12);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(29, 26);
            buttonCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonCerrar.TabIndex = 5;
            buttonCerrar.TabStop = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // buttonMinimizar
            // 
            buttonMinimizar.BackColor = Color.Transparent;
            buttonMinimizar.Image = (Image)resources.GetObject("buttonMinimizar.Image");
            buttonMinimizar.Location = new Point(703, 12);
            buttonMinimizar.Name = "buttonMinimizar";
            buttonMinimizar.Size = new Size(29, 26);
            buttonMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonMinimizar.TabIndex = 6;
            buttonMinimizar.TabStop = false;
            buttonMinimizar.Click += buttonMinimizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(344, 328);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(460, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 149);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // comboBoxInicioSesionRapido
            // 
            comboBoxInicioSesionRapido.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxInicioSesionRapido.FormattingEnabled = true;
            comboBoxInicioSesionRapido.Location = new Point(460, 394);
            comboBoxInicioSesionRapido.Name = "comboBoxInicioSesionRapido";
            comboBoxInicioSesionRapido.Size = new Size(151, 27);
            comboBoxInicioSesionRapido.TabIndex = 10;
            comboBoxInicioSesionRapido.SelectedIndexChanged += comboBoxInicioSesionRapido_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(461, 372);
            label4.Name = "label4";
            label4.Size = new Size(150, 19);
            label4.TabIndex = 11;
            label4.Text = "Inicio Sesion Rapido";
            // 
            // FormInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 567);
            Controls.Add(label4);
            Controls.Add(comboBoxInicioSesionRapido);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonMinimizar);
            Controls.Add(buttonCerrar);
            Controls.Add(label1);
            Controls.Add(buttonLogIn);
            Controls.Add(textBoxContrasenia);
            Controls.Add(textBoxUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicioSesion";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioSesion";
            Load += FormInicioSesion_Load;
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelLogo;
        private Label label3;
        private Label label2;
        public Panel panel1;
        public TextBox textBoxUsuario;
        public TextBox textBoxContrasenia;
        public Button buttonLogIn;
        public Label label1;
        public PictureBox buttonCerrar;
        public PictureBox buttonMinimizar;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ComboBox comboBoxInicioSesionRapido;
        private Label label4;
    }
}