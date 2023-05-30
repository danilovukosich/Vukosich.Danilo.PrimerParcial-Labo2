namespace ParcialLabo1
{
    partial class FormSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupervisor));
            iconButtonEstadisticas = new FontAwesome.Sharp.IconButton();
            iconButtonPasajeros = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            labelNombreApellidoUsuario = new Label();
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
            panelMenu.Controls.Add(iconButtonPasajeros);
            panelMenu.Controls.Add(iconButtonEstadisticas);
            panelMenu.Controls.SetChildIndex(panelLogo, 0);
            panelMenu.Controls.SetChildIndex(iconButtonHome, 0);
            panelMenu.Controls.SetChildIndex(iconButtonEstadisticas, 0);
            panelMenu.Controls.SetChildIndex(iconButtonPasajeros, 0);
            // 
            // iconButtonHome
            // 
            iconButtonHome.Click += iconButtonHome_Click_1;
            // 
            // labelFecha
            // 
            labelFecha.Size = new Size(131, 29);
            labelFecha.Text = "26/5/2023";
            // 
            // labelHora
            // 
            labelHora.Size = new Size(186, 50);
            labelHora.Text = "14:32:02";
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
            // iconButtonEstadisticas
            // 
            iconButtonEstadisticas.BackColor = SystemColors.MenuHighlight;
            iconButtonEstadisticas.FlatStyle = FlatStyle.Flat;
            iconButtonEstadisticas.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonEstadisticas.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            iconButtonEstadisticas.IconColor = Color.Black;
            iconButtonEstadisticas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEstadisticas.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonEstadisticas.Location = new Point(0, 333);
            iconButtonEstadisticas.Name = "iconButtonEstadisticas";
            iconButtonEstadisticas.Size = new Size(290, 56);
            iconButtonEstadisticas.TabIndex = 3;
            iconButtonEstadisticas.Text = "Estadisticas";
            iconButtonEstadisticas.UseVisualStyleBackColor = false;
            iconButtonEstadisticas.Click += iconButtonEstadisticas_Click;
            // 
            // iconButtonPasajeros
            // 
            iconButtonPasajeros.BackColor = SystemColors.MenuHighlight;
            iconButtonPasajeros.FlatStyle = FlatStyle.Flat;
            iconButtonPasajeros.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonPasajeros.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconButtonPasajeros.IconColor = Color.Black;
            iconButtonPasajeros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonPasajeros.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonPasajeros.Location = new Point(0, 395);
            iconButtonPasajeros.Name = "iconButtonPasajeros";
            iconButtonPasajeros.Size = new Size(290, 56);
            iconButtonPasajeros.TabIndex = 4;
            iconButtonPasajeros.Text = "Pasajeros";
            iconButtonPasajeros.UseVisualStyleBackColor = false;
            iconButtonPasajeros.Click += iconButtonAgregarPasajero_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(587, 205);
            label1.Name = "label1";
            label1.Size = new Size(210, 77);
            label1.TabIndex = 3;
            label1.Text = "Home";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-268, -3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(902, 595);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // labelNombreApellidoUsuario
            // 
            labelNombreApellidoUsuario.AutoSize = true;
            labelNombreApellidoUsuario.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombreApellidoUsuario.Location = new Point(98, 82);
            labelNombreApellidoUsuario.Name = "labelNombreApellidoUsuario";
            labelNombreApellidoUsuario.Size = new Size(69, 25);
            labelNombreApellidoUsuario.TabIndex = 18;
            labelNombreApellidoUsuario.Text = "label1";
            // 
            // FormSupervisor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 720);
            Name = "FormSupervisor";
            Text = "FormSupervisor";
            Load += FormSupervisor_Load;
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

        private FontAwesome.Sharp.IconButton iconButtonPasajeros;
        private FontAwesome.Sharp.IconButton iconButtonEstadisticas;
        private Label label1;
        private PictureBox pictureBox2;
        private Label labelNombreApellidoUsuario;
    }
}