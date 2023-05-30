namespace ParcialLabo1
{
    partial class FormAgregarAeronave
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
            buttonAgregarAeronave = new Button();
            buttonCancelar = new Button();
            numericUpDownAsientosTurista = new NumericUpDown();
            labelCantidadAsientos = new Label();
            numericUpDownBanios = new NumericUpDown();
            labelBanios = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            numericUpDownBodegas = new NumericUpDown();
            groupBoxComida = new GroupBox();
            radioButtonNoOfreceComida = new RadioButton();
            radioButtonSiOfreceComida = new RadioButton();
            groupBoxInternet = new GroupBox();
            radioButtonNoPoseeInternet = new RadioButton();
            radioButtonSiPoseeInternet = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            numericUpDownAsientosPremium = new NumericUpDown();
            labelAsientos = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientosTurista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBanios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBodegas).BeginInit();
            groupBoxComida.SuspendLayout();
            groupBoxInternet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientosPremium).BeginInit();
            SuspendLayout();
            // 
            // buttonAgregarAeronave
            // 
            buttonAgregarAeronave.BackColor = SystemColors.Highlight;
            buttonAgregarAeronave.Cursor = Cursors.Hand;
            buttonAgregarAeronave.FlatStyle = FlatStyle.Flat;
            buttonAgregarAeronave.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAgregarAeronave.ForeColor = SystemColors.ActiveCaptionText;
            buttonAgregarAeronave.Location = new Point(237, 375);
            buttonAgregarAeronave.Name = "buttonAgregarAeronave";
            buttonAgregarAeronave.Size = new Size(156, 63);
            buttonAgregarAeronave.TabIndex = 0;
            buttonAgregarAeronave.Text = "Agregar";
            buttonAgregarAeronave.UseVisualStyleBackColor = false;
            buttonAgregarAeronave.Click += button1_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.Highlight;
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCancelar.Location = new Point(462, 375);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(156, 63);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // numericUpDownAsientosTurista
            // 
            numericUpDownAsientosTurista.Location = new Point(165, 75);
            numericUpDownAsientosTurista.Name = "numericUpDownAsientosTurista";
            numericUpDownAsientosTurista.Size = new Size(125, 27);
            numericUpDownAsientosTurista.TabIndex = 4;
            // 
            // labelCantidadAsientos
            // 
            labelCantidadAsientos.AutoSize = true;
            labelCantidadAsientos.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCantidadAsientos.Location = new Point(88, 65);
            labelCantidadAsientos.Name = "labelCantidadAsientos";
            labelCantidadAsientos.Size = new Size(72, 19);
            labelCantidadAsientos.TabIndex = 5;
            labelCantidadAsientos.Text = "Asientos";
            // 
            // numericUpDownBanios
            // 
            numericUpDownBanios.Location = new Point(165, 181);
            numericUpDownBanios.Name = "numericUpDownBanios";
            numericUpDownBanios.Size = new Size(125, 27);
            numericUpDownBanios.TabIndex = 6;
            // 
            // labelBanios
            // 
            labelBanios.AutoSize = true;
            labelBanios.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBanios.Location = new Point(99, 189);
            labelBanios.Name = "labelBanios";
            labelBanios.Size = new Size(53, 19);
            labelBanios.TabIndex = 7;
            labelBanios.Text = "Baños";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(numericUpDownBodegas);
            panel1.Controls.Add(groupBoxComida);
            panel1.Controls.Add(groupBoxInternet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDownAsientosPremium);
            panel1.Controls.Add(labelAsientos);
            panel1.Controls.Add(labelBanios);
            panel1.Controls.Add(numericUpDownBanios);
            panel1.Controls.Add(numericUpDownAsientosTurista);
            panel1.Controls.Add(labelCantidadAsientos);
            panel1.Location = new Point(61, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 338);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(84, 242);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 19;
            label5.Text = "Bodega";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(75, 223);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 18;
            label2.Text = "Capacidad";
            // 
            // numericUpDownBodegas
            // 
            numericUpDownBodegas.Location = new Point(165, 234);
            numericUpDownBodegas.Name = "numericUpDownBodegas";
            numericUpDownBodegas.Size = new Size(125, 27);
            numericUpDownBodegas.TabIndex = 17;
            // 
            // groupBoxComida
            // 
            groupBoxComida.Controls.Add(radioButtonNoOfreceComida);
            groupBoxComida.Controls.Add(radioButtonSiOfreceComida);
            groupBoxComida.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxComida.Location = new Point(401, 187);
            groupBoxComida.Name = "groupBoxComida";
            groupBoxComida.Size = new Size(192, 125);
            groupBoxComida.TabIndex = 16;
            groupBoxComida.TabStop = false;
            groupBoxComida.Text = "Servicio Comida";
            // 
            // radioButtonNoOfreceComida
            // 
            radioButtonNoOfreceComida.AutoSize = true;
            radioButtonNoOfreceComida.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonNoOfreceComida.Location = new Point(27, 68);
            radioButtonNoOfreceComida.Name = "radioButtonNoOfreceComida";
            radioButtonNoOfreceComida.Size = new Size(51, 23);
            radioButtonNoOfreceComida.TabIndex = 1;
            radioButtonNoOfreceComida.TabStop = true;
            radioButtonNoOfreceComida.Text = "No";
            radioButtonNoOfreceComida.UseVisualStyleBackColor = true;
            // 
            // radioButtonSiOfreceComida
            // 
            radioButtonSiOfreceComida.AutoSize = true;
            radioButtonSiOfreceComida.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonSiOfreceComida.Location = new Point(27, 38);
            radioButtonSiOfreceComida.Name = "radioButtonSiOfreceComida";
            radioButtonSiOfreceComida.Size = new Size(43, 23);
            radioButtonSiOfreceComida.TabIndex = 0;
            radioButtonSiOfreceComida.TabStop = true;
            radioButtonSiOfreceComida.Text = "Si";
            radioButtonSiOfreceComida.UseVisualStyleBackColor = true;
            radioButtonSiOfreceComida.CheckedChanged += radioButtonSiOfreceComida_CheckedChanged;
            // 
            // groupBoxInternet
            // 
            groupBoxInternet.Controls.Add(radioButtonNoPoseeInternet);
            groupBoxInternet.Controls.Add(radioButtonSiPoseeInternet);
            groupBoxInternet.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxInternet.Location = new Point(401, 56);
            groupBoxInternet.Name = "groupBoxInternet";
            groupBoxInternet.Size = new Size(192, 125);
            groupBoxInternet.TabIndex = 15;
            groupBoxInternet.TabStop = false;
            groupBoxInternet.Text = " Servicio Internet";
            // 
            // radioButtonNoPoseeInternet
            // 
            radioButtonNoPoseeInternet.AutoSize = true;
            radioButtonNoPoseeInternet.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonNoPoseeInternet.Location = new Point(27, 75);
            radioButtonNoPoseeInternet.Name = "radioButtonNoPoseeInternet";
            radioButtonNoPoseeInternet.Size = new Size(51, 23);
            radioButtonNoPoseeInternet.TabIndex = 1;
            radioButtonNoPoseeInternet.TabStop = true;
            radioButtonNoPoseeInternet.Text = "No";
            radioButtonNoPoseeInternet.UseVisualStyleBackColor = true;
            // 
            // radioButtonSiPoseeInternet
            // 
            radioButtonSiPoseeInternet.AutoSize = true;
            radioButtonSiPoseeInternet.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonSiPoseeInternet.Location = new Point(27, 41);
            radioButtonSiPoseeInternet.Name = "radioButtonSiPoseeInternet";
            radioButtonSiPoseeInternet.Size = new Size(43, 23);
            radioButtonSiPoseeInternet.TabIndex = 0;
            radioButtonSiPoseeInternet.TabStop = true;
            radioButtonSiPoseeInternet.Text = "Si";
            radioButtonSiPoseeInternet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(209, 0);
            label4.Name = "label4";
            label4.Size = new Size(262, 36);
            label4.TabIndex = 14;
            label4.Text = "Agregar Aeronave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(88, 146);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 13;
            label3.Text = "Premium";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 83);
            label1.Name = "label1";
            label1.Size = new Size(58, 19);
            label1.TabIndex = 12;
            label1.Text = "Turista";
            // 
            // numericUpDownAsientosPremium
            // 
            numericUpDownAsientosPremium.Location = new Point(165, 126);
            numericUpDownAsientosPremium.Name = "numericUpDownAsientosPremium";
            numericUpDownAsientosPremium.Size = new Size(125, 27);
            numericUpDownAsientosPremium.TabIndex = 10;
            // 
            // labelAsientos
            // 
            labelAsientos.AutoSize = true;
            labelAsientos.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAsientos.Location = new Point(88, 126);
            labelAsientos.Name = "labelAsientos";
            labelAsientos.Size = new Size(72, 19);
            labelAsientos.TabIndex = 11;
            labelAsientos.Text = "Asientos";
            // 
            // FormAgregarAeronave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 122, 204);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAgregarAeronave);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "FormAgregarAeronave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarAeronave";
            Load += FormAgregarAeronave_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientosTurista).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBanios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBodegas).EndInit();
            groupBoxComida.ResumeLayout(false);
            groupBoxComida.PerformLayout();
            groupBoxInternet.ResumeLayout(false);
            groupBoxInternet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientosPremium).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAgregarAeronave;
        private Button buttonCancelar;
        private NumericUpDown numericUpDownAsientosTurista;
        private Label labelCantidadAsientos;
        private NumericUpDown numericUpDownBanios;
        private Label labelBanios;
        private Panel panel1;
        private NumericUpDown numericUpDownAsientosPremium;
        private Label labelAsientos;
        private RadioButton radioButtonNoPoseeInternet;
        private RadioButton radioButtonSiPoseeInternet;
        private RadioButton radioButtonNoOfreceComida;
        private RadioButton radioButtonSiOfreceComida;
        private Label label3;
        private Label label1;
        private Label label4;
        private GroupBox groupBoxComida;
        private GroupBox groupBoxInternet;
        private Label label5;
        private Label label2;
        private NumericUpDown numericUpDownBodegas;
    }
}