namespace ParcialLabo1
{
    partial class FormUsuarioPadre
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioPadre));
            panelMenu = new Panel();
            iconButtonHome = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            label3 = new Label();
            label2 = new Label();
            labelHora = new Label();
            labelFecha = new Label();
            pictureBox1 = new PictureBox();
            labelTipoUsuario = new Label();
            panel2 = new Panel();
            labelCerrarSesion2 = new Label();
            labelCerrarSesion1 = new Label();
            labelNombreUsuario = new Label();
            pictureBoxCerrarSesion = new PictureBox();
            panelDesktop = new Panel();
            timerHoraFecha = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarSesion).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(iconButtonHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(290, 720);
            panelMenu.TabIndex = 1;
            // 
            // iconButtonHome
            // 
            iconButtonHome.BackColor = SystemColors.MenuHighlight;
            iconButtonHome.Cursor = Cursors.Hand;
            iconButtonHome.FlatStyle = FlatStyle.Flat;
            iconButtonHome.ForeColor = Color.Black;
            iconButtonHome.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButtonHome.IconColor = Color.Black;
            iconButtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonHome.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonHome.Location = new Point(0, 273);
            iconButtonHome.Name = "iconButtonHome";
            iconButtonHome.Size = new Size(290, 54);
            iconButtonHome.TabIndex = 1;
            iconButtonHome.Text = "Home";
            iconButtonHome.UseVisualStyleBackColor = false;
            iconButtonHome.Click += iconButtonHome_Click;
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
            panelLogo.Size = new Size(290, 267);
            panelLogo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(102, 227);
            label3.Name = "label3";
            label3.Size = new Size(126, 38);
            label3.TabIndex = 1;
            label3.Text = "Express";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 191);
            label2.Name = "label2";
            label2.Size = new Size(159, 36);
            label2.TabIndex = 0;
            label2.Text = "Aerolineas";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.BackColor = Color.Transparent;
            labelHora.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelHora.Location = new Point(791, 28);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(139, 50);
            labelHora.TabIndex = 12;
            labelHora.Text = "label4";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.Location = new Point(808, 78);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(80, 29);
            labelFecha.TabIndex = 13;
            labelFecha.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelTipoUsuario
            // 
            labelTipoUsuario.AutoSize = true;
            labelTipoUsuario.BackColor = Color.Transparent;
            labelTipoUsuario.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTipoUsuario.ForeColor = Color.Black;
            labelTipoUsuario.Location = new Point(86, 36);
            labelTipoUsuario.Name = "labelTipoUsuario";
            labelTipoUsuario.Size = new Size(126, 39);
            labelTipoUsuario.TabIndex = 9;
            labelTipoUsuario.Text = "Usuario";
            labelTipoUsuario.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(labelCerrarSesion2);
            panel2.Controls.Add(labelCerrarSesion1);
            panel2.Controls.Add(labelNombreUsuario);
            panel2.Controls.Add(labelHora);
            panel2.Controls.Add(pictureBoxCerrarSesion);
            panel2.Controls.Add(labelFecha);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(labelTipoUsuario);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(290, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 125);
            panel2.TabIndex = 11;
            // 
            // labelCerrarSesion2
            // 
            labelCerrarSesion2.AutoSize = true;
            labelCerrarSesion2.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCerrarSesion2.ForeColor = Color.IndianRed;
            labelCerrarSesion2.Location = new Point(1004, 106);
            labelCerrarSesion2.Name = "labelCerrarSesion2";
            labelCerrarSesion2.Size = new Size(57, 19);
            labelCerrarSesion2.TabIndex = 16;
            labelCerrarSesion2.Text = "Sesión";
            labelCerrarSesion2.Click += labelCerrarSesion2_Click;
            // 
            // labelCerrarSesion1
            // 
            labelCerrarSesion1.AutoSize = true;
            labelCerrarSesion1.BackColor = Color.Transparent;
            labelCerrarSesion1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCerrarSesion1.ForeColor = Color.IndianRed;
            labelCerrarSesion1.Location = new Point(1004, 87);
            labelCerrarSesion1.Name = "labelCerrarSesion1";
            labelCerrarSesion1.Size = new Size(54, 19);
            labelCerrarSesion1.TabIndex = 15;
            labelCerrarSesion1.Text = "Cerrar";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.BackColor = Color.Transparent;
            labelNombreUsuario.Font = new Font("Microsoft YaHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreUsuario.ForeColor = Color.Black;
            labelNombreUsuario.Location = new Point(98, 88);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(82, 24);
            labelNombreUsuario.TabIndex = 14;
            labelNombreUsuario.Text = "Nombre";
            // 
            // pictureBoxCerrarSesion
            // 
            pictureBoxCerrarSesion.Image = (Image)resources.GetObject("pictureBoxCerrarSesion.Image");
            pictureBoxCerrarSesion.Location = new Point(1007, 0);
            pictureBoxCerrarSesion.Name = "pictureBoxCerrarSesion";
            pictureBoxCerrarSesion.Size = new Size(51, 125);
            pictureBoxCerrarSesion.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCerrarSesion.TabIndex = 11;
            pictureBoxCerrarSesion.TabStop = false;
            pictureBoxCerrarSesion.Click += pictureBox2_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.WhiteSmoke;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(290, 125);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1070, 595);
            panelDesktop.TabIndex = 12;
            // 
            // timerHoraFecha
            // 
            timerHoraFecha.Enabled = true;
            timerHoraFecha.Tick += timerHoraFecha_Tick;
            // 
            // FormUsuarioPadre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 720);
            Controls.Add(panelDesktop);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuarioPadre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += FormUsuarioPadre_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarSesion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panelMenu;
        public PictureBox pictureBox1;
        public Label label1;
        private PictureBox pictureBox2;
        public Panel panelLogo;
        public Label label3;
        public Label label2;
        public FontAwesome.Sharp.IconButton iconButtonHome;
        public PictureBox pictureBoxCerrarSesion;
        public Label labelFecha;
        public Label labelHora;
        private System.Windows.Forms.Timer timerHoraFecha;
        public Label labelTipoUsuario;
        public Label labelNombreUsuario;
        public Panel panel2;
        public Panel panelDesktop;
        public Label labelCerrarSesion2;
        public Label labelCerrarSesion1;
    }
}