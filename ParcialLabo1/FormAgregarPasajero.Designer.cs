namespace ParcialLabo1
{
    partial class FormAgregarPasajero
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
            panel1 = new Panel();
            textBoxDniPasajero = new TextBox();
            textBoxApellidoPasajero = new TextBox();
            textBoxNombrePasajero = new TextBox();
            label2 = new Label();
            label4 = new Label();
            labelAsientos = new Label();
            labelBanios = new Label();
            numericUpDownEdadPasajero = new NumericUpDown();
            labelCantidadAsientos = new Label();
            buttonCancelar = new Button();
            buttonAgregarPasajero = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdadPasajero).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(textBoxDniPasajero);
            panel1.Controls.Add(textBoxApellidoPasajero);
            panel1.Controls.Add(textBoxNombrePasajero);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(labelAsientos);
            panel1.Controls.Add(labelBanios);
            panel1.Controls.Add(numericUpDownEdadPasajero);
            panel1.Controls.Add(labelCantidadAsientos);
            panel1.Location = new Point(53, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 338);
            panel1.TabIndex = 11;
            // 
            // textBoxDniPasajero
            // 
            textBoxDniPasajero.Location = new Point(307, 223);
            textBoxDniPasajero.Name = "textBoxDniPasajero";
            textBoxDniPasajero.Size = new Size(125, 27);
            textBoxDniPasajero.TabIndex = 21;
            textBoxDniPasajero.KeyPress += textBoxDniPasajero_KeyPress;
            // 
            // textBoxApellidoPasajero
            // 
            textBoxApellidoPasajero.Location = new Point(307, 126);
            textBoxApellidoPasajero.Name = "textBoxApellidoPasajero";
            textBoxApellidoPasajero.Size = new Size(125, 27);
            textBoxApellidoPasajero.TabIndex = 20;
            textBoxApellidoPasajero.KeyPress += textBoxApellidoPasajero_KeyPress;
            // 
            // textBoxNombrePasajero
            // 
            textBoxNombrePasajero.Location = new Point(308, 77);
            textBoxNombrePasajero.Name = "textBoxNombrePasajero";
            textBoxNombrePasajero.Size = new Size(125, 27);
            textBoxNombrePasajero.TabIndex = 19;
            textBoxNombrePasajero.KeyPress += textBoxNombrePasajero_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(267, 227);
            label2.Name = "label2";
            label2.Size = new Size(34, 19);
            label2.TabIndex = 18;
            label2.Text = "Dni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(232, 11);
            label4.Name = "label4";
            label4.Size = new Size(248, 36);
            label4.TabIndex = 14;
            label4.Text = "Agregar Pasajero";
            // 
            // labelAsientos
            // 
            labelAsientos.AutoSize = true;
            labelAsientos.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAsientos.Location = new Point(232, 130);
            labelAsientos.Name = "labelAsientos";
            labelAsientos.Size = new Size(71, 19);
            labelAsientos.TabIndex = 11;
            labelAsientos.Text = "Apellido";
            // 
            // labelBanios
            // 
            labelBanios.AutoSize = true;
            labelBanios.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBanios.Location = new Point(257, 181);
            labelBanios.Name = "labelBanios";
            labelBanios.Size = new Size(45, 19);
            labelBanios.TabIndex = 7;
            labelBanios.Text = "Edad";
            // 
            // numericUpDownEdadPasajero
            // 
            numericUpDownEdadPasajero.Location = new Point(307, 173);
            numericUpDownEdadPasajero.Name = "numericUpDownEdadPasajero";
            numericUpDownEdadPasajero.Size = new Size(125, 27);
            numericUpDownEdadPasajero.TabIndex = 6;
            // 
            // labelCantidadAsientos
            // 
            labelCantidadAsientos.AutoSize = true;
            labelCantidadAsientos.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantidadAsientos.Location = new Point(233, 81);
            labelCantidadAsientos.Name = "labelCantidadAsientos";
            labelCantidadAsientos.Size = new Size(70, 19);
            labelCantidadAsientos.TabIndex = 5;
            labelCantidadAsientos.Text = "Nombre";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.Highlight;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancelar.Location = new Point(454, 366);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(156, 63);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAgregarPasajero
            // 
            buttonAgregarPasajero.BackColor = SystemColors.Highlight;
            buttonAgregarPasajero.Cursor = Cursors.Hand;
            buttonAgregarPasajero.FlatStyle = FlatStyle.Flat;
            buttonAgregarPasajero.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarPasajero.ForeColor = SystemColors.ActiveCaptionText;
            buttonAgregarPasajero.Location = new Point(229, 366);
            buttonAgregarPasajero.Name = "buttonAgregarPasajero";
            buttonAgregarPasajero.Size = new Size(156, 63);
            buttonAgregarPasajero.TabIndex = 9;
            buttonAgregarPasajero.Text = "Agregar";
            buttonAgregarPasajero.UseVisualStyleBackColor = false;
            buttonAgregarPasajero.Click += buttonAgregarPasajero_Click;
            // 
            // FormAgregarPasajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAgregarPasajero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAgregarPasajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarPasajero";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdadPasajero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxDniPasajero;
        private TextBox textBoxApellidoPasajero;
        private TextBox textBoxNombrePasajero;
        private Label label2;
        private Label label4;
        private Label labelAsientos;
        private Label labelBanios;
        private NumericUpDown numericUpDownEdadPasajero;
        private Label labelCantidadAsientos;
        private Button buttonCancelar;
        private Button buttonAgregarPasajero;
    }
}