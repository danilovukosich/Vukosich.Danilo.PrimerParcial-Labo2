namespace ParcialLabo1
{
    partial class FormModificarAeronave
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
            label1 = new Label();
            buttonAceptarModificar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBoxInternet = new GroupBox();
            radioButtonSiInternet = new RadioButton();
            label7 = new Label();
            radioButtonNoInternet = new RadioButton();
            groupBoxComida = new GroupBox();
            radioButtonNoComida = new RadioButton();
            radioButtonSiComida = new RadioButton();
            numericUpDownCantidadBanos = new NumericUpDown();
            numericUpDownCapcidadBodega = new NumericUpDown();
            buttonCancelar = new Button();
            labelMatriculaValor = new Label();
            panel1 = new Panel();
            numericUpDownAsientosPremium = new NumericUpDown();
            numericUpDownAsientosTurista = new NumericUpDown();
            groupBoxInternet.SuspendLayout();
            groupBoxComida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadBanos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapcidadBodega).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientosPremium).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientosTurista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 13);
            label1.Name = "label1";
            label1.Size = new Size(91, 22);
            label1.TabIndex = 0;
            label1.Text = "Matricula";
            // 
            // buttonAceptarModificar
            // 
            buttonAceptarModificar.BackColor = SystemColors.ButtonHighlight;
            buttonAceptarModificar.FlatStyle = FlatStyle.Popup;
            buttonAceptarModificar.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAceptarModificar.Location = new Point(72, 351);
            buttonAceptarModificar.Name = "buttonAceptarModificar";
            buttonAceptarModificar.Size = new Size(151, 61);
            buttonAceptarModificar.TabIndex = 2;
            buttonAceptarModificar.Text = "Modificar";
            buttonAceptarModificar.UseVisualStyleBackColor = false;
            buttonAceptarModificar.Click += buttonAceptarModificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 58);
            label2.Name = "label2";
            label2.Size = new Size(162, 22);
            label2.TabIndex = 4;
            label2.Text = "Asientos Premium";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 97);
            label3.Name = "label3";
            label3.Size = new Size(144, 22);
            label3.TabIndex = 6;
            label3.Text = "Asientos Turista";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(72, 142);
            label4.Name = "label4";
            label4.Size = new Size(141, 22);
            label4.TabIndex = 8;
            label4.Text = "Cantidad Baños";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(68, 189);
            label5.Name = "label5";
            label5.Size = new Size(166, 22);
            label5.TabIndex = 10;
            label5.Text = "Capacidad Bodega";
            // 
            // groupBoxInternet
            // 
            groupBoxInternet.BackColor = Color.FromArgb(0, 122, 204);
            groupBoxInternet.Controls.Add(radioButtonSiInternet);
            groupBoxInternet.Controls.Add(label7);
            groupBoxInternet.Controls.Add(radioButtonNoInternet);
            groupBoxInternet.Location = new Point(113, 222);
            groupBoxInternet.Name = "groupBoxInternet";
            groupBoxInternet.Size = new Size(247, 47);
            groupBoxInternet.TabIndex = 13;
            groupBoxInternet.TabStop = false;
            groupBoxInternet.Text = "Internet";
            // 
            // radioButtonSiInternet
            // 
            radioButtonSiInternet.AutoSize = true;
            radioButtonSiInternet.Location = new Point(79, 17);
            radioButtonSiInternet.Name = "radioButtonSiInternet";
            radioButtonSiInternet.Size = new Size(42, 24);
            radioButtonSiInternet.TabIndex = 2;
            radioButtonSiInternet.TabStop = true;
            radioButtonSiInternet.Text = "Si";
            radioButtonSiInternet.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-80, 10);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 14;
            label7.Text = "label7";
            // 
            // radioButtonNoInternet
            // 
            radioButtonNoInternet.AutoSize = true;
            radioButtonNoInternet.Location = new Point(130, 17);
            radioButtonNoInternet.Name = "radioButtonNoInternet";
            radioButtonNoInternet.Size = new Size(50, 24);
            radioButtonNoInternet.TabIndex = 1;
            radioButtonNoInternet.TabStop = true;
            radioButtonNoInternet.Text = "No";
            radioButtonNoInternet.UseVisualStyleBackColor = true;
            // 
            // groupBoxComida
            // 
            groupBoxComida.BackColor = Color.FromArgb(0, 122, 204);
            groupBoxComida.Controls.Add(radioButtonNoComida);
            groupBoxComida.Controls.Add(radioButtonSiComida);
            groupBoxComida.Location = new Point(113, 289);
            groupBoxComida.Name = "groupBoxComida";
            groupBoxComida.Size = new Size(247, 47);
            groupBoxComida.TabIndex = 15;
            groupBoxComida.TabStop = false;
            groupBoxComida.Text = "Comida";
            // 
            // radioButtonNoComida
            // 
            radioButtonNoComida.AutoSize = true;
            radioButtonNoComida.Location = new Point(130, 17);
            radioButtonNoComida.Name = "radioButtonNoComida";
            radioButtonNoComida.Size = new Size(50, 24);
            radioButtonNoComida.TabIndex = 1;
            radioButtonNoComida.TabStop = true;
            radioButtonNoComida.Text = "No";
            radioButtonNoComida.UseVisualStyleBackColor = true;
            // 
            // radioButtonSiComida
            // 
            radioButtonSiComida.AutoSize = true;
            radioButtonSiComida.Location = new Point(79, 17);
            radioButtonSiComida.Name = "radioButtonSiComida";
            radioButtonSiComida.Size = new Size(42, 24);
            radioButtonSiComida.TabIndex = 0;
            radioButtonSiComida.TabStop = true;
            radioButtonSiComida.Text = "Si";
            radioButtonSiComida.UseVisualStyleBackColor = true;
            // 
            // numericUpDownCantidadBanos
            // 
            numericUpDownCantidadBanos.Location = new Point(263, 141);
            numericUpDownCantidadBanos.Name = "numericUpDownCantidadBanos";
            numericUpDownCantidadBanos.Size = new Size(125, 27);
            numericUpDownCantidadBanos.TabIndex = 16;
            // 
            // numericUpDownCapcidadBodega
            // 
            numericUpDownCapcidadBodega.Location = new Point(263, 189);
            numericUpDownCapcidadBodega.Name = "numericUpDownCapcidadBodega";
            numericUpDownCapcidadBodega.Size = new Size(125, 27);
            numericUpDownCapcidadBodega.TabIndex = 17;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.ButtonHighlight;
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.Red;
            buttonCancelar.Location = new Point(243, 351);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(151, 61);
            buttonCancelar.TabIndex = 18;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelMatriculaValor
            // 
            labelMatriculaValor.AutoSize = true;
            labelMatriculaValor.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatriculaValor.Location = new Point(263, 13);
            labelMatriculaValor.Name = "labelMatriculaValor";
            labelMatriculaValor.Size = new Size(91, 22);
            labelMatriculaValor.TabIndex = 19;
            labelMatriculaValor.Text = "Matricula";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(numericUpDownAsientosPremium);
            panel1.Controls.Add(numericUpDownAsientosTurista);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonCancelar);
            panel1.Controls.Add(labelMatriculaValor);
            panel1.Controls.Add(buttonAceptarModificar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(numericUpDownCapcidadBodega);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDownCantidadBanos);
            panel1.Controls.Add(groupBoxComida);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(groupBoxInternet);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 426);
            panel1.TabIndex = 20;
            // 
            // numericUpDownAsientosPremium
            // 
            numericUpDownAsientosPremium.Location = new Point(263, 53);
            numericUpDownAsientosPremium.Name = "numericUpDownAsientosPremium";
            numericUpDownAsientosPremium.Size = new Size(125, 27);
            numericUpDownAsientosPremium.TabIndex = 21;
            // 
            // numericUpDownAsientosTurista
            // 
            numericUpDownAsientosTurista.Location = new Point(263, 97);
            numericUpDownAsientosTurista.Name = "numericUpDownAsientosTurista";
            numericUpDownAsientosTurista.Size = new Size(125, 27);
            numericUpDownAsientosTurista.TabIndex = 20;
            // 
            // FormModificarAeronave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(471, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormModificarAeronave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormModificarAeronave";
            Load += FormModificarAeronave_Load;
            groupBoxInternet.ResumeLayout(false);
            groupBoxInternet.PerformLayout();
            groupBoxComida.ResumeLayout(false);
            groupBoxComida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadBanos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapcidadBodega).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientosPremium).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientosTurista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonAceptarModificar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBoxInternet;
        private Label label7;
        private RadioButton radioButtonNoInternet;
        private RadioButton radioButton1;
        private GroupBox groupBoxComida;
        private RadioButton radioButtonNoComida;
        private RadioButton radioButtonSiComida;
        private NumericUpDown numericUpDownCantidadBanos;
        private NumericUpDown numericUpDownCapcidadBodega;
        private Button buttonCancelar;
        private Label labelMatriculaValor;
        private Panel panel1;
        private RadioButton radioButtonSiInternet;
        private NumericUpDown numericUpDownAsientosPremium;
        private NumericUpDown numericUpDownAsientosTurista;
    }
}