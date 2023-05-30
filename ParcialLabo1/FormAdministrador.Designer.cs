namespace ParcialLabo1
{
    partial class FormAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            labelNombreApellidoUsuario = new Label();
            iconButtonAeronaves = new FontAwesome.Sharp.IconButton();
            iconButtonVuelos = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarSesion).BeginInit();
            panel2.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(iconButtonVuelos);
            panelMenu.Controls.Add(iconButtonAeronaves);
            panelMenu.Controls.SetChildIndex(panelLogo, 0);
            panelMenu.Controls.SetChildIndex(iconButtonHome, 0);
            panelMenu.Controls.SetChildIndex(iconButtonAeronaves, 0);
            panelMenu.Controls.SetChildIndex(iconButtonVuelos, 0);
            // 
            // iconButtonHome
            // 
            iconButtonHome.Click += iconButtonHome_Click;
            // 
            // labelFecha
            // 
            labelFecha.Size = new Size(131, 29);
            labelFecha.Text = "22/5/2023";
            // 
            // labelHora
            // 
            labelHora.Size = new Size(186, 50);
            labelHora.Text = "23:55:08";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.Size = new Size(0, 24);
            labelNombreUsuario.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelNombreApellidoUsuario);
            panel2.Controls.SetChildIndex(labelTipoUsuario, 0);
            panel2.Controls.SetChildIndex(pictureBox1, 0);
            panel2.Controls.SetChildIndex(labelFecha, 0);
            panel2.Controls.SetChildIndex(pictureBoxCerrarSesion, 0);
            panel2.Controls.SetChildIndex(labelHora, 0);
            panel2.Controls.SetChildIndex(labelNombreUsuario, 0);
            panel2.Controls.SetChildIndex(labelCerrarSesion1, 0);
            panel2.Controls.SetChildIndex(labelCerrarSesion2, 0);
            panel2.Controls.SetChildIndex(labelNombreApellidoUsuario, 0);
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(label1);
            panelDesktop.Controls.Add(pictureBox2);
            // 
            // labelNombreApellidoUsuario
            // 
            labelNombreApellidoUsuario.AutoSize = true;
            labelNombreApellidoUsuario.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreApellidoUsuario.Location = new Point(104, 88);
            labelNombreApellidoUsuario.Name = "labelNombreApellidoUsuario";
            labelNombreApellidoUsuario.Size = new Size(69, 25);
            labelNombreApellidoUsuario.TabIndex = 17;
            labelNombreApellidoUsuario.Text = "label1";
            // 
            // iconButtonAeronaves
            // 
            iconButtonAeronaves.BackColor = SystemColors.MenuHighlight;
            iconButtonAeronaves.FlatStyle = FlatStyle.Flat;
            iconButtonAeronaves.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonAeronaves.IconChar = FontAwesome.Sharp.IconChar.PlaneUp;
            iconButtonAeronaves.IconColor = Color.Black;
            iconButtonAeronaves.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAeronaves.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonAeronaves.Location = new Point(0, 333);
            iconButtonAeronaves.Name = "iconButtonAeronaves";
            iconButtonAeronaves.Size = new Size(290, 56);
            iconButtonAeronaves.TabIndex = 2;
            iconButtonAeronaves.Text = "Aeronaves";
            iconButtonAeronaves.UseVisualStyleBackColor = false;
            iconButtonAeronaves.Click += iconButtonViajes_Click;
            // 
            // iconButtonVuelos
            // 
            iconButtonVuelos.BackColor = SystemColors.MenuHighlight;
            iconButtonVuelos.FlatStyle = FlatStyle.Flat;
            iconButtonVuelos.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonVuelos.IconChar = FontAwesome.Sharp.IconChar.PlaneDeparture;
            iconButtonVuelos.IconColor = Color.Black;
            iconButtonVuelos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonVuelos.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonVuelos.Location = new Point(0, 395);
            iconButtonVuelos.Name = "iconButtonVuelos";
            iconButtonVuelos.Size = new Size(290, 56);
            iconButtonVuelos.TabIndex = 3;
            iconButtonVuelos.Text = "Vuelos";
            iconButtonVuelos.UseVisualStyleBackColor = false;
            iconButtonVuelos.Click += iconButtonVuelos_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-278, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(902, 595);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(577, 208);
            label1.Name = "label1";
            label1.Size = new Size(210, 77);
            label1.TabIndex = 1;
            label1.Text = "Home";
            // 
            // FormAdministrador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 720);
            Name = "FormAdministrador";
            Text = "FormAdministrador";
            Load += FormAdministrador_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarSesion).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelNombreApellidoUsuario;
        private FontAwesome.Sharp.IconButton iconButtonAeronaves;
        private FontAwesome.Sharp.IconButton iconButtonVuelos;
        private PictureBox pictureBox2;
        private Label label1;
    }
}